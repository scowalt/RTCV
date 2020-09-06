namespace RTCV.Launcher
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class LauncherConf
    {
        public string launcherAssetLocation { get; private set; }
        private string launcherConfLocation;
        public string batchFilesLocation { get; private set; }
        public string version { get; private set; }

        public LauncherConfItem[] items { get; private set; } = { };

        public LauncherConf(string _version)
        {
            version = _version;
            launcherAssetLocation = Path.Combine(MainForm.launcherDir, "VERSIONS" + Path.DirectorySeparatorChar + version + Path.DirectorySeparatorChar + "Launcher");
            launcherConfLocation = Path.Combine(launcherAssetLocation, "launcher.ini");
            batchFilesLocation = Path.Combine(MainForm.launcherDir, "VERSIONS", version);

            if (!File.Exists(launcherConfLocation))
                return;

            string[] confLines = File.ReadAllLines(launcherConfLocation);

            items = confLines.Select(it => new LauncherConfItem(this, it)).ToArray();
        }
    }

    public class LauncherConfItem
    {
        public string imageLocation { get; private set; }
        public string batchName { get; private set; }
        public string batchLocation { get; private set; }
        public string folderName { get; private set; }
        public string folderLocation { get; private set; }
        public string downloadVersion { get; private set; }
        public string line { get; private set; }

        public LauncherConfItem(LauncherConf lc, string _line)
        {
            line = _line;
            var lineItems = _line.Split('|');
            imageLocation = Path.Combine(lc.launcherAssetLocation, lineItems[0]);
            batchName = lineItems[1];
            batchLocation = Path.Combine(lc.batchFilesLocation, batchName);
            folderName = lineItems[2];
            folderLocation = Path.Combine(lc.batchFilesLocation, folderName);
            downloadVersion = lineItems[3];
        }
    }

    public class ExecutableCommand
    {
        private string DisplayName;
        private string FileName;
        private string Arguments;
        private bool WaitForExit;
        private int WaitForExitTimeout = int.MaxValue;

        [JsonConverter(typeof(StringEnumConverter))]
        private ProcessWindowStyle WindowStyle = ProcessWindowStyle.Normal;
        private List<ExecutableCommand> PreExecuteCommands = new List<ExecutableCommand>();
        private List<ExecutableCommand> PostExecuteCommands = new List<ExecutableCommand>();

        public ExecutableCommand(string displayName, string fileName, string arguments, bool waitForExit)
        {
            DisplayName = displayName;
            FileName = fileName;
            Arguments = arguments;
            WaitForExit = waitForExit;
        }

        public bool Execute(bool runPreExecute = true, bool runPostExecute = true)
        {
            bool success = true;

            if (runPreExecute)
            {
                foreach (var exe in PreExecuteCommands)
                {
                    if (!exe.Execute())
                        Console.WriteLine($"Executing PreExecuteCommand {exe.DisplayName} failed!");
                }
            }

            var psi = new ProcessStartInfo
            {
                WindowStyle = WindowStyle,
                Arguments = Arguments,
                UseShellExecute = true
            };

            if (File.Exists(Path.GetFullPath(FileName)))
            {
                psi.FileName = Path.GetFullPath(FileName);
                psi.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(FileName)) ?? "";
            }
            else
                psi.FileName = FileName;

            try
            {
                var p = Process.Start(psi);

                if (WaitForExit)
                    success = p?.WaitForExit(WaitForExitTimeout) ?? false;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to start process {psi.FileName}.\nException: {e.Message}");
            }

            if (runPostExecute)
            {
                foreach (var exe in PostExecuteCommands)
                {
                    if (!exe.Execute())
                        Console.WriteLine($"Executing PostExecuteCommand {exe.DisplayName} failed!");
                }
            }

            return success;
        }
    }

    public class LauncherConfJson
    {
        public string LauncherAssetLocation { get; private set; }
        public string VersionLocation { get; private set; }
        public string Version { get; private set; }

        public LauncherConfJsonItem[] Items { get; private set; } = { };

        public LauncherConfJson(string _version)
        {
            Version = _version;
            LauncherAssetLocation = Path.Combine(MainForm.launcherDir, "VERSIONS", Version, "Launcher");
            var launcherConfLocation = Path.Combine(LauncherAssetLocation, "launcher.json");

            string[] launcherAddonConfLocations = { };
            if (Directory.Exists(LauncherAssetLocation))
                launcherAddonConfLocations = Directory.GetFiles(LauncherAssetLocation).Where(it => it.Contains("addon_") && it.Contains(".json")).ToArray();

            VersionLocation = Path.Combine(MainForm.launcherDir, "VERSIONS", Version);

            if (!File.Exists(launcherConfLocation))
                return;

            Directory.SetCurrentDirectory(VersionLocation); //Move ourselves to this working directory


            var launcherJson = File.ReadAllText(launcherConfLocation);
            List<LauncherConfJsonItem> lcjiList = new List<LauncherConfJsonItem>();
            lcjiList.AddRange(JsonConvert.DeserializeObject<LauncherConfJsonItem[]>(launcherJson));

            foreach (var addonJsonConfLocation in launcherAddonConfLocations)
            {
                try
                {
                    var addonJson = File.ReadAllText(addonJsonConfLocation);
                    var addonConfigs = JsonConvert.DeserializeObject<LauncherConfJsonItem[]>(addonJson);

                    foreach (var conf in addonConfigs)
                    {
                        conf.ConfigFilename = addonJsonConfLocation;
                        conf.IsAddon = true;
                    }

                    lcjiList.AddRange(addonConfigs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not load addon json config file at\n{addonJsonConfLocation}\n\n{ex.ToString()}\n\n{(ex.InnerException != null ? ex.InnerException.ToString() : "")}");
                    //eat it
                }
            }

            if (lcjiList[0].ItemSubtitle != null) //means we can use metadata to reorder in categories
            {
                var vanguardImplementations = lcjiList.Where(it => it.ItemSubtitle != null && it.ItemSubtitle.ToUpper().Contains("VANGUARD")).ToList();
                var stubVanguardImplementations = lcjiList.Where(it => it.ItemSubtitle != null && it.ItemSubtitle.ToUpper().Contains("STUB")).ToList();
                var everythingElse = lcjiList.Where(it => it.ItemSubtitle != null && !it.ItemSubtitle.ToUpper().Contains("STUB") && !it.ItemSubtitle.ToUpper().Contains("VANGUARD")).ToList();
                var addButton = lcjiList.FirstOrDefault(it => it.ImageName == "Add.png");

                lcjiList.Clear();
                lcjiList.AddRange(vanguardImplementations);
                lcjiList.AddRange(stubVanguardImplementations);
                lcjiList.AddRange(everythingElse);
                lcjiList.Add(addButton);
            }

            Items = lcjiList.ToArray();
        }
    }

    public class LauncherConfJsonItem
    {
        [JsonProperty]
        public readonly string FolderName;
        [JsonProperty]
        public readonly string ImageName;
        [JsonProperty]
        public readonly string DownloadVersion;
        [JsonProperty]
        public readonly ReadOnlyDictionary<string, ExecutableCommand> ExecutableCommands;

        //Used for the sidepanel and ordering of cards
        [JsonProperty]
        public readonly string ItemName;
        [JsonProperty]
        public readonly string ItemSubtitle;
        [JsonProperty]
        public readonly string ItemDescription;

        [JsonProperty]
        public readonly bool HideItem; //makes the card hide

        //Addon vars that are automatically set when the json is loaded
        public bool IsAddon;
        public string ConfigFilename;


        public LauncherConfJsonItem(string imageName, string downloadVersion, string folderName, ReadOnlyDictionary<string, ExecutableCommand> executableCommands, string itemName, string itemSubtitle, string itemDescription, bool hideItem, bool isAddon, string configFilename)
        {
            ImageName = imageName;
            DownloadVersion = downloadVersion;
            FolderName = folderName;
            ExecutableCommands = executableCommands;

            ItemName = itemName;
            ItemSubtitle = itemSubtitle;
            ItemDescription = itemDescription;

            HideItem = hideItem;
            IsAddon = isAddon;
            ConfigFilename = configFilename;
        }

        public bool Execute(bool runPreExecute = true, bool runPostExecute = true)
        {
            bool success = true;
            foreach (var e in ExecutableCommands.Values)
                success = (e.Execute(runPreExecute, runPostExecute) & success);
            return success;
        }

        public bool Execute(string key, bool runPreExecute = true, bool runPostExecute = true)
        {
            ExecutableCommands.TryGetValue(key, out ExecutableCommand e);
            return e?.Execute(runPreExecute, runPostExecute) ?? false;
        }
    }
}
