using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using RTCV.CorruptCore;
using static RTCV.UI.UI_Extensions;
using System.Collections;

namespace RTCV.UI
{
	public partial class RTC_BlastBoard_Form : ComponentForm
	{
		public new void HandleMouseDown(object s, MouseEventArgs e) => base.HandleMouseDown(s, e);
		public new void HandleFormClosing(object s, FormClosingEventArgs e) => base.HandleFormClosing(s, e);

		public RTC_BlastBoard_Form()
		{
			InitializeComponent();

            UICore.SetRTCColor(UICore.GeneralColor, this);

		}


        private void RTC_BlastBoard_Form_Resize(object sender, EventArgs e)
        {

        }

        private void RTC_BlastBoard_Form_Load(object sender, EventArgs e)
        {
   
        }
    }
}
