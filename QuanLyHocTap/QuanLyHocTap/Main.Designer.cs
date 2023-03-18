namespace QuanLyHocTap
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.qlgvTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlmhTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qllTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlsvTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTMSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTool,
            this.exitTMSItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTool
            // 
            this.menuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlgvTSMItem,
            this.qlmhTSMItem,
            this.qllTSMItem,
            this.qlsvTSMItem});
            this.menuTool.Name = "menuTool";
            this.menuTool.Size = new System.Drawing.Size(60, 24);
            this.menuTool.Text = "Menu";
            // 
            // qlgvTSMItem
            // 
            this.qlgvTSMItem.Name = "qlgvTSMItem";
            this.qlgvTSMItem.Size = new System.Drawing.Size(224, 26);
            this.qlgvTSMItem.Text = "Quản lý giảng viên";
            this.qlgvTSMItem.Click += new System.EventHandler(this.qlgvTSMItem_Click);
            // 
            // qlmhTSMItem
            // 
            this.qlmhTSMItem.Name = "qlmhTSMItem";
            this.qlmhTSMItem.Size = new System.Drawing.Size(224, 26);
            this.qlmhTSMItem.Text = "Quản lý môn học";
            this.qlmhTSMItem.Click += new System.EventHandler(this.qlmhTSMItem_Click);
            // 
            // qllTSMItem
            // 
            this.qllTSMItem.Name = "qllTSMItem";
            this.qllTSMItem.Size = new System.Drawing.Size(224, 26);
            this.qllTSMItem.Text = "Quản lý lớp";
            this.qllTSMItem.Click += new System.EventHandler(this.qllTSMItem_Click);
            // 
            // qlsvTSMItem
            // 
            this.qlsvTSMItem.Name = "qlsvTSMItem";
            this.qlsvTSMItem.Size = new System.Drawing.Size(224, 26);
            this.qlsvTSMItem.Text = "Quản lý sinh viên";
            this.qlsvTSMItem.Click += new System.EventHandler(this.qlsvTSMItem_Click);
            // 
            // exitTMSItem
            // 
            this.exitTMSItem.Name = "exitTMSItem";
            this.exitTMSItem.Size = new System.Drawing.Size(61, 24);
            this.exitTMSItem.Text = "Thoát";
            this.exitTMSItem.Click += new System.EventHandler(this.exitTMSItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 495);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTool;
        private System.Windows.Forms.ToolStripMenuItem qlgvTSMItem;
        private System.Windows.Forms.ToolStripMenuItem qlmhTSMItem;
        private System.Windows.Forms.ToolStripMenuItem qllTSMItem;
        private System.Windows.Forms.ToolStripMenuItem qlsvTSMItem;
        private System.Windows.Forms.ToolStripMenuItem exitTMSItem;
    }
}