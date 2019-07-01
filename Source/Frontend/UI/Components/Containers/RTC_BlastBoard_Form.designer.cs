namespace RTCV.UI
{
    partial class RTC_BlastBoard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTC_BlastBoard_Form));
            this.pnBoard = new System.Windows.Forms.Panel();
            this.btnCorrupt = new System.Windows.Forms.Button();
            this.btnImportStockpile = new System.Windows.Forms.Button();
            this.btnLoadStockpile = new System.Windows.Forms.Button();
            this.pnBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBoard
            // 
            this.pnBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnBoard.Controls.Add(this.btnCorrupt);
            this.pnBoard.Location = new System.Drawing.Point(12, 56);
            this.pnBoard.Name = "pnBoard";
            this.pnBoard.Size = new System.Drawing.Size(328, 223);
            this.pnBoard.TabIndex = 169;
            this.pnBoard.Tag = "color:dark1";
            // 
            // btnCorrupt
            // 
            this.btnCorrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCorrupt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCorrupt.FlatAppearance.BorderSize = 0;
            this.btnCorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrupt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrupt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCorrupt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrupt.Location = new System.Drawing.Point(0, 0);
            this.btnCorrupt.Name = "btnCorrupt";
            this.btnCorrupt.Size = new System.Drawing.Size(128, 64);
            this.btnCorrupt.TabIndex = 138;
            this.btnCorrupt.TabStop = false;
            this.btnCorrupt.Tag = "color:dark2";
            this.btnCorrupt.Text = "End the level immediately and restart the game";
            this.btnCorrupt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorrupt.UseVisualStyleBackColor = false;
            this.btnCorrupt.Visible = false;
            // 
            // btnImportStockpile
            // 
            this.btnImportStockpile.BackColor = System.Drawing.Color.Gray;
            this.btnImportStockpile.FlatAppearance.BorderSize = 0;
            this.btnImportStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportStockpile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnImportStockpile.ForeColor = System.Drawing.Color.White;
            this.btnImportStockpile.Image = ((System.Drawing.Image)(resources.GetObject("btnImportStockpile.Image")));
            this.btnImportStockpile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportStockpile.Location = new System.Drawing.Point(147, 12);
            this.btnImportStockpile.Name = "btnImportStockpile";
            this.btnImportStockpile.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnImportStockpile.Size = new System.Drawing.Size(193, 32);
            this.btnImportStockpile.TabIndex = 168;
            this.btnImportStockpile.TabStop = false;
            this.btnImportStockpile.Tag = "color:light1";
            this.btnImportStockpile.Text = "  Import from Glitch Harvester";
            this.btnImportStockpile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportStockpile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportStockpile.UseVisualStyleBackColor = false;
            // 
            // btnLoadStockpile
            // 
            this.btnLoadStockpile.BackColor = System.Drawing.Color.Gray;
            this.btnLoadStockpile.FlatAppearance.BorderSize = 0;
            this.btnLoadStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStockpile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadStockpile.ForeColor = System.Drawing.Color.White;
            this.btnLoadStockpile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadStockpile.Image")));
            this.btnLoadStockpile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadStockpile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadStockpile.Name = "btnLoadStockpile";
            this.btnLoadStockpile.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnLoadStockpile.Size = new System.Drawing.Size(126, 32);
            this.btnLoadStockpile.TabIndex = 161;
            this.btnLoadStockpile.TabStop = false;
            this.btnLoadStockpile.Tag = "color:light1";
            this.btnLoadStockpile.Text = "  Load Stockpile";
            this.btnLoadStockpile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadStockpile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadStockpile.UseVisualStyleBackColor = false;
            // 
            // RTC_BlastBoard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(352, 291);
            this.Controls.Add(this.pnBoard);
            this.Controls.Add(this.btnImportStockpile);
            this.Controls.Add(this.btnLoadStockpile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(352, 291);
            this.Name = "RTC_BlastBoard_Form";
            this.Tag = "color:dark1";
            this.Text = "BlastBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.Load += new System.EventHandler(this.RTC_BlastBoard_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            this.Resize += new System.EventHandler(this.RTC_BlastBoard_Form_Resize);
            this.pnBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCorrupt;
        private System.Windows.Forms.Button btnLoadStockpile;
        private System.Windows.Forms.Button btnImportStockpile;
        private System.Windows.Forms.Panel pnBoard;
    }
}