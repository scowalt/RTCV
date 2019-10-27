﻿namespace RTCV.UI
{
    partial class RTC_SimpleMode_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTC_SimpleMode_Form));
            this.btnBlastToggle = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTargetType = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.btnShuffleAlgorithm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearInfiniteUnits = new System.Windows.Forms.Button();
            this.gbEngineParameters = new System.Windows.Forms.GroupBox();
            this.pnIntensity = new System.Windows.Forms.Panel();
            this.btnManualBlast = new System.Windows.Forms.Button();
            this.btnAutoCorrupt = new System.Windows.Forms.Button();
            this.gbRealTimeCorruption = new System.Windows.Forms.GroupBox();
            this.lbIntensityHelp = new System.Windows.Forms.Label();
            this.gbIterativeCorruption = new System.Windows.Forms.GroupBox();
            this.lbSimpleGlitchHarvesterHelp = new System.Windows.Forms.Label();
            this.btnSaveSavestateList = new System.Windows.Forms.Button();
            this.btnCorrupt = new System.Windows.Forms.Button();
            this.btnSwitchNormalMode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbTargetType.SuspendLayout();
            this.gbEngineParameters.SuspendLayout();
            this.gbRealTimeCorruption.SuspendLayout();
            this.gbIterativeCorruption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBlastToggle
            // 
            this.btnBlastToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlastToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBlastToggle.FlatAppearance.BorderSize = 0;
            this.btnBlastToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlastToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBlastToggle.ForeColor = System.Drawing.Color.White;
            this.btnBlastToggle.Location = new System.Drawing.Point(14, 512);
            this.btnBlastToggle.Name = "btnBlastToggle";
            this.btnBlastToggle.Size = new System.Drawing.Size(453, 32);
            this.btnBlastToggle.TabIndex = 131;
            this.btnBlastToggle.TabStop = false;
            this.btnBlastToggle.Tag = "color:dark2";
            this.btnBlastToggle.Text = "BlastLayer : OFF    (Attempts to uncorrupt/recorrupt in real-time)";
            this.btnBlastToggle.UseVisualStyleBackColor = false;
            this.btnBlastToggle.Visible = false;
            this.btnBlastToggle.Click += new System.EventHandler(this.btnBlastToggle_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 238;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 45F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Game";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 113;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 45F;
            this.dataGridViewTextBoxColumn3.HeaderText = "System";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 40F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Core";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 41);
            this.label2.TabIndex = 83;
            this.label2.Text = "Simple Mode";
            // 
            // gbTargetType
            // 
            this.gbTargetType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTargetType.Controls.Add(this.button1);
            this.gbTargetType.Controls.Add(this.radioButton2);
            this.gbTargetType.Controls.Add(this.radioButton1);
            this.gbTargetType.Controls.Add(this.lbConnectionStatus);
            this.gbTargetType.ForeColor = System.Drawing.Color.White;
            this.gbTargetType.Location = new System.Drawing.Point(13, 62);
            this.gbTargetType.Name = "gbTargetType";
            this.gbTargetType.Size = new System.Drawing.Size(680, 81);
            this.gbTargetType.TabIndex = 132;
            this.gbTargetType.TabStop = false;
            this.gbTargetType.Text = "Target Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioButton2.Location = new System.Drawing.Point(357, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(286, 23);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Modern Platforms (32bit/64bit, 3d games)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioButton1.Location = new System.Drawing.Point(47, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(269, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Classic Platforms (8bit/16bit, 2d games)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.lbConnectionStatus.Location = new System.Drawing.Point(152, 15);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(391, 19);
            this.lbConnectionStatus.TabIndex = 2;
            this.lbConnectionStatus.Text = "What would best describe the game you are trying to corrupt?";
            // 
            // btnShuffleAlgorithm
            // 
            this.btnShuffleAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShuffleAlgorithm.BackColor = System.Drawing.Color.Gray;
            this.btnShuffleAlgorithm.FlatAppearance.BorderSize = 0;
            this.btnShuffleAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffleAlgorithm.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnShuffleAlgorithm.ForeColor = System.Drawing.Color.White;
            this.btnShuffleAlgorithm.Location = new System.Drawing.Point(455, 22);
            this.btnShuffleAlgorithm.Name = "btnShuffleAlgorithm";
            this.btnShuffleAlgorithm.Size = new System.Drawing.Size(206, 23);
            this.btnShuffleAlgorithm.TabIndex = 179;
            this.btnShuffleAlgorithm.TabStop = false;
            this.btnShuffleAlgorithm.Tag = "color:light1";
            this.btnShuffleAlgorithm.Text = "Shuffle algorithm (Spice things up)";
            this.btnShuffleAlgorithm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Auto-Selected Engine: Vector Engine \nParameters: Limiter:One , Value:Two\n\nThis en" +
    "gine is made for corrupting 3d games \nand 2d games made for 3d-era consoles.";
            // 
            // btnClearInfiniteUnits
            // 
            this.btnClearInfiniteUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInfiniteUnits.BackColor = System.Drawing.Color.Gray;
            this.btnClearInfiniteUnits.FlatAppearance.BorderSize = 0;
            this.btnClearInfiniteUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInfiniteUnits.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnClearInfiniteUnits.ForeColor = System.Drawing.Color.White;
            this.btnClearInfiniteUnits.Location = new System.Drawing.Point(455, 51);
            this.btnClearInfiniteUnits.Name = "btnClearInfiniteUnits";
            this.btnClearInfiniteUnits.Size = new System.Drawing.Size(206, 23);
            this.btnClearInfiniteUnits.TabIndex = 180;
            this.btnClearInfiniteUnits.TabStop = false;
            this.btnClearInfiniteUnits.Tag = "color:light1";
            this.btnClearInfiniteUnits.Text = "Clear infinite units";
            this.btnClearInfiniteUnits.UseVisualStyleBackColor = false;
            this.btnClearInfiniteUnits.Visible = false;
            // 
            // gbEngineParameters
            // 
            this.gbEngineParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEngineParameters.Controls.Add(this.btnClearInfiniteUnits);
            this.gbEngineParameters.Controls.Add(this.label1);
            this.gbEngineParameters.Controls.Add(this.btnShuffleAlgorithm);
            this.gbEngineParameters.ForeColor = System.Drawing.Color.White;
            this.gbEngineParameters.Location = new System.Drawing.Point(13, 155);
            this.gbEngineParameters.Name = "gbEngineParameters";
            this.gbEngineParameters.Size = new System.Drawing.Size(678, 92);
            this.gbEngineParameters.TabIndex = 133;
            this.gbEngineParameters.TabStop = false;
            this.gbEngineParameters.Text = "Engine Parameters";
            this.gbEngineParameters.Visible = false;
            // 
            // pnIntensity
            // 
            this.pnIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnIntensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnIntensity.Location = new System.Drawing.Point(3, 14);
            this.pnIntensity.Name = "pnIntensity";
            this.pnIntensity.Size = new System.Drawing.Size(377, 97);
            this.pnIntensity.TabIndex = 134;
            // 
            // btnManualBlast
            // 
            this.btnManualBlast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManualBlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnManualBlast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnManualBlast.FlatAppearance.BorderSize = 0;
            this.btnManualBlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualBlast.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnManualBlast.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnManualBlast.Image = ((System.Drawing.Image)(resources.GetObject("btnManualBlast.Image")));
            this.btnManualBlast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualBlast.Location = new System.Drawing.Point(383, 26);
            this.btnManualBlast.Name = "btnManualBlast";
            this.btnManualBlast.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnManualBlast.Size = new System.Drawing.Size(118, 34);
            this.btnManualBlast.TabIndex = 121;
            this.btnManualBlast.TabStop = false;
            this.btnManualBlast.Tag = "color:dark3";
            this.btnManualBlast.Text = " Manual Blast";
            this.btnManualBlast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualBlast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManualBlast.UseVisualStyleBackColor = false;
            // 
            // btnAutoCorrupt
            // 
            this.btnAutoCorrupt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoCorrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAutoCorrupt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAutoCorrupt.FlatAppearance.BorderSize = 0;
            this.btnAutoCorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoCorrupt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAutoCorrupt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAutoCorrupt.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoCorrupt.Image")));
            this.btnAutoCorrupt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoCorrupt.Location = new System.Drawing.Point(513, 26);
            this.btnAutoCorrupt.Name = "btnAutoCorrupt";
            this.btnAutoCorrupt.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAutoCorrupt.Size = new System.Drawing.Size(150, 34);
            this.btnAutoCorrupt.TabIndex = 122;
            this.btnAutoCorrupt.TabStop = false;
            this.btnAutoCorrupt.Tag = "color:dark3";
            this.btnAutoCorrupt.Text = " Start Auto-Corrupt";
            this.btnAutoCorrupt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoCorrupt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoCorrupt.UseVisualStyleBackColor = false;
            // 
            // gbRealTimeCorruption
            // 
            this.gbRealTimeCorruption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRealTimeCorruption.Controls.Add(this.lbIntensityHelp);
            this.gbRealTimeCorruption.Controls.Add(this.pnIntensity);
            this.gbRealTimeCorruption.Controls.Add(this.btnManualBlast);
            this.gbRealTimeCorruption.Controls.Add(this.btnAutoCorrupt);
            this.gbRealTimeCorruption.ForeColor = System.Drawing.Color.White;
            this.gbRealTimeCorruption.Location = new System.Drawing.Point(13, 260);
            this.gbRealTimeCorruption.Name = "gbRealTimeCorruption";
            this.gbRealTimeCorruption.Size = new System.Drawing.Size(678, 119);
            this.gbRealTimeCorruption.TabIndex = 181;
            this.gbRealTimeCorruption.TabStop = false;
            this.gbRealTimeCorruption.Text = "Real-Time Corruption";
            this.gbRealTimeCorruption.Visible = false;
            // 
            // lbIntensityHelp
            // 
            this.lbIntensityHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIntensityHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbIntensityHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbIntensityHelp.ForeColor = System.Drawing.Color.White;
            this.lbIntensityHelp.Location = new System.Drawing.Point(396, 70);
            this.lbIntensityHelp.Name = "lbIntensityHelp";
            this.lbIntensityHelp.Size = new System.Drawing.Size(265, 37);
            this.lbIntensityHelp.TabIndex = 5;
            this.lbIntensityHelp.Text = "The intensity controls the power of a Manual Blast. Auto-Corrupt fires a Blast ev" +
    "ery frame.";
            // 
            // gbIterativeCorruption
            // 
            this.gbIterativeCorruption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIterativeCorruption.Controls.Add(this.lbSimpleGlitchHarvesterHelp);
            this.gbIterativeCorruption.Controls.Add(this.btnSaveSavestateList);
            this.gbIterativeCorruption.Controls.Add(this.btnCorrupt);
            this.gbIterativeCorruption.ForeColor = System.Drawing.Color.White;
            this.gbIterativeCorruption.Location = new System.Drawing.Point(14, 391);
            this.gbIterativeCorruption.Name = "gbIterativeCorruption";
            this.gbIterativeCorruption.Size = new System.Drawing.Size(677, 108);
            this.gbIterativeCorruption.TabIndex = 182;
            this.gbIterativeCorruption.TabStop = false;
            this.gbIterativeCorruption.Text = "Iterative Corruption";
            this.gbIterativeCorruption.Visible = false;
            // 
            // lbSimpleGlitchHarvesterHelp
            // 
            this.lbSimpleGlitchHarvesterHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSimpleGlitchHarvesterHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbSimpleGlitchHarvesterHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbSimpleGlitchHarvesterHelp.ForeColor = System.Drawing.Color.White;
            this.lbSimpleGlitchHarvesterHelp.Location = new System.Drawing.Point(392, 32);
            this.lbSimpleGlitchHarvesterHelp.Name = "lbSimpleGlitchHarvesterHelp";
            this.lbSimpleGlitchHarvesterHelp.Size = new System.Drawing.Size(271, 53);
            this.lbSimpleGlitchHarvesterHelp.TabIndex = 135;
            this.lbSimpleGlitchHarvesterHelp.Text = "This is a very simplified version of RTC\'s Glitch Harvester. It allows you to cre" +
    "ate a savestate and then corrupt it as many times you want.";
            // 
            // btnSaveSavestateList
            // 
            this.btnSaveSavestateList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSavestateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaveSavestateList.FlatAppearance.BorderSize = 0;
            this.btnSaveSavestateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSavestateList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveSavestateList.ForeColor = System.Drawing.Color.White;
            this.btnSaveSavestateList.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSavestateList.Image")));
            this.btnSaveSavestateList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSavestateList.Location = new System.Drawing.Point(11, 22);
            this.btnSaveSavestateList.Name = "btnSaveSavestateList";
            this.btnSaveSavestateList.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnSaveSavestateList.Size = new System.Drawing.Size(364, 32);
            this.btnSaveSavestateList.TabIndex = 169;
            this.btnSaveSavestateList.TabStop = false;
            this.btnSaveSavestateList.Tag = "color:dark2";
            this.btnSaveSavestateList.Text = "  Create and select a Glitch Harvester savestate";
            this.btnSaveSavestateList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSavestateList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSavestateList.UseVisualStyleBackColor = false;
            // 
            // btnCorrupt
            // 
            this.btnCorrupt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCorrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCorrupt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCorrupt.FlatAppearance.BorderSize = 0;
            this.btnCorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrupt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCorrupt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCorrupt.Image = ((System.Drawing.Image)(resources.GetObject("btnCorrupt.Image")));
            this.btnCorrupt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrupt.Location = new System.Drawing.Point(12, 62);
            this.btnCorrupt.Name = "btnCorrupt";
            this.btnCorrupt.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnCorrupt.Size = new System.Drawing.Size(363, 32);
            this.btnCorrupt.TabIndex = 138;
            this.btnCorrupt.TabStop = false;
            this.btnCorrupt.Tag = "color:dark2";
            this.btnCorrupt.Text = "  Load the savestate and Corrupt the game";
            this.btnCorrupt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrupt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorrupt.UseVisualStyleBackColor = false;
            // 
            // btnSwitchNormalMode
            // 
            this.btnSwitchNormalMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSwitchNormalMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSwitchNormalMode.FlatAppearance.BorderSize = 0;
            this.btnSwitchNormalMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchNormalMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSwitchNormalMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchNormalMode.Location = new System.Drawing.Point(482, 512);
            this.btnSwitchNormalMode.Name = "btnSwitchNormalMode";
            this.btnSwitchNormalMode.Size = new System.Drawing.Size(209, 32);
            this.btnSwitchNormalMode.TabIndex = 183;
            this.btnSwitchNormalMode.TabStop = false;
            this.btnSwitchNormalMode.Tag = "color:dark2";
            this.btnSwitchNormalMode.Text = "Switch to Normal Mode";
            this.btnSwitchNormalMode.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 7F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(655, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 184;
            this.button1.TabStop = false;
            this.button1.Tag = "color:dark2";
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RTC_SimpleMode_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(705, 558);
            this.Controls.Add(this.btnSwitchNormalMode);
            this.Controls.Add(this.gbIterativeCorruption);
            this.Controls.Add(this.gbRealTimeCorruption);
            this.Controls.Add(this.gbEngineParameters);
            this.Controls.Add(this.gbTargetType);
            this.Controls.Add(this.btnBlastToggle);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 515);
            this.Name = "RTC_SimpleMode_Form";
            this.Tag = "color:dark1";
            this.Text = "Stockpile Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RTC_SimpleMode_Form_FormClosing);
            this.gbTargetType.ResumeLayout(false);
            this.gbTargetType.PerformLayout();
            this.gbEngineParameters.ResumeLayout(false);
            this.gbEngineParameters.PerformLayout();
            this.gbRealTimeCorruption.ResumeLayout(false);
            this.gbIterativeCorruption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		public System.Windows.Forms.Button btnBlastToggle;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTargetType;
        public System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Button btnShuffleAlgorithm;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearInfiniteUnits;
        private System.Windows.Forms.GroupBox gbEngineParameters;
        public System.Windows.Forms.Button btnManualBlast;
        public System.Windows.Forms.Button btnAutoCorrupt;
        private System.Windows.Forms.GroupBox gbRealTimeCorruption;
        private System.Windows.Forms.GroupBox gbIterativeCorruption;
        public System.Windows.Forms.Label lbIntensityHelp;
        public System.Windows.Forms.Button btnCorrupt;
        public System.Windows.Forms.Label lbSimpleGlitchHarvesterHelp;
        private System.Windows.Forms.Button btnSaveSavestateList;
        public System.Windows.Forms.Panel pnIntensity;
        public System.Windows.Forms.Button btnSwitchNormalMode;
        public System.Windows.Forms.Button button1;
    }
}