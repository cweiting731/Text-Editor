namespace F74121246_practice_7_1
{
    partial class ParentForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.FileMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FinishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMnu,
            this.FinishToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(728, 38);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // FileMnu
            // 
            this.FileMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewPage,
            this.MnuTOpenFile});
            this.FileMnu.Name = "FileMnu";
            this.FileMnu.Size = new System.Drawing.Size(77, 34);
            this.FileMnu.Text = "檔案";
            // 
            // AddNewPage
            // 
            this.AddNewPage.Name = "AddNewPage";
            this.AddNewPage.Size = new System.Drawing.Size(212, 38);
            this.AddNewPage.Text = "新增";
            this.AddNewPage.Click += new System.EventHandler(this.AddNewPage_Click);
            // 
            // MnuTOpenFile
            // 
            this.MnuTOpenFile.Name = "MnuTOpenFile";
            this.MnuTOpenFile.Size = new System.Drawing.Size(212, 38);
            this.MnuTOpenFile.Text = "開啟舊檔";
            this.MnuTOpenFile.Click += new System.EventHandler(this.MnuTOpenFile_Click);
            // 
            // FinishToolStripMenuItem
            // 
            this.FinishToolStripMenuItem.Name = "FinishToolStripMenuItem";
            this.FinishToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.FinishToolStripMenuItem.Text = "結束";
            this.FinishToolStripMenuItem.Click += new System.EventHandler(this.FinishToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 944);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem FileMnu;
        private System.Windows.Forms.ToolStripMenuItem AddNewPage;
        private System.Windows.Forms.ToolStripMenuItem MnuTOpenFile;
        private System.Windows.Forms.ToolStripMenuItem FinishToolStripMenuItem;
    }
}