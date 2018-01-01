namespace Stock
{
    partial class StockMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.מוצרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מלאיToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.דיווחToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רשימתמוצריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רשימתמלאיToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מוצרToolStripMenuItem,
            this.מלאיToolStripMenuItem,
            this.דיווחToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(280, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // מוצרToolStripMenuItem
            // 
            this.מוצרToolStripMenuItem.Name = "מוצרToolStripMenuItem";
            this.מוצרToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.מוצרToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.מוצרToolStripMenuItem.Text = "מוצר";
            this.מוצרToolStripMenuItem.Click += new System.EventHandler(this.מוצרToolStripMenuItem_Click);
            // 
            // מלאיToolStripMenuItem
            // 
            this.מלאיToolStripMenuItem.Name = "מלאיToolStripMenuItem";
            this.מלאיToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.מלאיToolStripMenuItem.Text = "מלאי";
            // 
            // דיווחToolStripMenuItem
            // 
            this.דיווחToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.רשימתמוצריםToolStripMenuItem,
            this.רשימתמלאיToolStripMenuItem});
            this.דיווחToolStripMenuItem.Name = "דיווחToolStripMenuItem";
            this.דיווחToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.דיווחToolStripMenuItem.Text = "דיווח";
            // 
            // רשימתמוצריםToolStripMenuItem
            // 
            this.רשימתמוצריםToolStripMenuItem.Name = "רשימתמוצריםToolStripMenuItem";
            this.רשימתמוצריםToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.רשימתמוצריםToolStripMenuItem.Text = "רשימת מוצרים";
            // 
            // רשימתמלאיToolStripMenuItem
            // 
            this.רשימתמלאיToolStripMenuItem.Name = "רשימתמלאיToolStripMenuItem";
            this.רשימתמלאיToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.רשימתמלאיToolStripMenuItem.Text = "רשימת מלאי";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // StockMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "StockMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockMain_FormClosing);
            this.Load += new System.EventHandler(this.StockMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem מוצרToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מלאיToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem דיווחToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימתמוצריםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימתמלאיToolStripMenuItem;
    }
}



