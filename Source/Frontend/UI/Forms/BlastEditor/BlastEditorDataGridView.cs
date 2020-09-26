namespace RTCV.UI.Forms.BlastEditor
{
    using System;
    using System.Windows.Forms;
    using RTCV.Common;
    using RTCV.CorruptCore;
    using RTCV.NetCore;

    internal partial class BlastEditorDataGridView : DataGridView
    {
        private ContextMenuStrip _cms;

        internal BlastEditorDataGridView() : base()
        {
            CellFormatting += OnCellFormatting;
        }

        private void OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Bug in DGV. If you don't read the value back, it goes into edit mode on first click if you read the selectedrow within SelectionChanged. Why? No idea.
            _ = Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
