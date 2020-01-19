using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSScriptLibrary;
using NLog.Layouts;
using NLog.Windows.Forms;
using NLog.Config;
using NLog;

namespace RTCV.CorruptCore.Tools
{
    public partial class ScriptManager : UserControl 
    {
        Logger _logger = null;
        Logger logger
        {
            get
            {
                if (_logger != null)
                    return _logger;

                var config = new NLog.Config.LoggingConfiguration();
                SimpleLayout layout = "${level} ${logger} ${message} ${onexception:|${newline}EXCEPTION OCCURRED\\:${exception:format=type,message,method:maxInnerExceptionLevel=5:innerFormat=shortType,message,method}${newline}";

                var logtextbox = new RichTextBoxTarget()
                {
                    FormName = this.Name,
                    TargetRichTextBox = tbLog,
                    Layout = layout,
                    MaxLines = 10000,
                    AutoScroll = true,
                    UseDefaultRowColoringRules = false,

                };
                logtextbox.RowColoringRules.Add(new RichTextBoxRowColoringRule(
                        "level == LogLevel.Trace", // condition
                        "LightGray", // font color
                        tbLog.BackColor.ToString()
                    ));
                logtextbox.RowColoringRules.Add(new RichTextBoxRowColoringRule(
                        "level == LogLevel.Debug", // condition
                        "Purple", // font color
                        tbLog.BackColor.ToString()
                    ));
                logtextbox.RowColoringRules.Add(new RichTextBoxRowColoringRule(
                        "level == LogLevel.Warn", // condition
                        "Yellow", // font color
                        tbLog.BackColor.ToString()
                    ));
                logtextbox.RowColoringRules.Add(new RichTextBoxRowColoringRule(
                        "level == LogLevel.Error", // condition
                        "Red", // font color
                        tbLog.BackColor.ToString()
                    ));
                logtextbox.RowColoringRules.Add(new RichTextBoxRowColoringRule(
                        "level == LogLevel.Info", // condition
                        "White", // font color
                        tbLog.BackColor.ToString()
                    ));


                config.AddRule(LogLevel.Trace, LogLevel.Fatal, logtextbox);
                _logger = new LogFactory(config).GetCurrentClassLogger();
                return _logger;
            }
        }
        public ScriptManager()
        {
            InitializeComponent();
            CSScript.EvaluatorConfig.Engine = EvaluatorEngine.Roslyn;
            //CSScript.EvaluatorConfig.Access = EvaluatorAccess.Singleton;
        }


        private void btnRunSynchronously_Click(object sender, EventArgs e)
        {
            MethodDelegate scr = null;
            try
            {
                scr = CSScript.Evaluator.CreateDelegate(tbCodeEditor.Text);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception generating script.");
                return;
            }
            try
            {
                scr.Invoke(new[]{logger});
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception running script.");
                return;
            }
        }

        private void btnRunAsync_Click(object sender, EventArgs e)
        {
            MethodDelegate scr = null;
            try
            {
                scr = CSScript.Evaluator.CreateDelegate(tbCodeEditor.Text);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception generating script.");
                return;
            }
            try
            {
                scr.BeginInvoke(new[] { logger }, null, null);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception running script.");
                return;
            }
        }
    }
}
