namespace F74121246_practice_7_1
{
    partial class ChildForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTSaveNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnutPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuText = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txt = new System.Windows.Forms.TextBox();
            this.MnuTUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTCount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFindAndReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.MnuEdit,
            this.MnuText,
            this.MnuFindAndReplace,
            this.MnuExit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(678, 38);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTSave,
            this.MnuTSaveNew});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(77, 34);
            this.mnuFile.Text = "檔案";
            // 
            // MnuTSave
            // 
            this.MnuTSave.Name = "MnuTSave";
            this.MnuTSave.Size = new System.Drawing.Size(270, 38);
            this.MnuTSave.Text = "儲存";
            this.MnuTSave.Click += new System.EventHandler(this.MnuTSave_Click);
            // 
            // MnuTSaveNew
            // 
            this.MnuTSaveNew.Name = "MnuTSaveNew";
            this.MnuTSaveNew.Size = new System.Drawing.Size(270, 38);
            this.MnuTSaveNew.Text = "另存新檔";
            this.MnuTSaveNew.Click += new System.EventHandler(this.MnuTSaveNew_Click);
            // 
            // MnuEdit
            // 
            this.MnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTCut,
            this.MnuTCopy,
            this.MnutPaste,
            this.MnuTUndo,
            this.MnuTRedo,
            this.MnuTCount});
            this.MnuEdit.Name = "MnuEdit";
            this.MnuEdit.Size = new System.Drawing.Size(77, 34);
            this.MnuEdit.Text = "編輯";
            // 
            // MnuTCut
            // 
            this.MnuTCut.Name = "MnuTCut";
            this.MnuTCut.Size = new System.Drawing.Size(270, 38);
            this.MnuTCut.Text = "剪下";
            this.MnuTCut.Click += new System.EventHandler(this.MnuTCut_Click);
            // 
            // MnuTCopy
            // 
            this.MnuTCopy.Name = "MnuTCopy";
            this.MnuTCopy.Size = new System.Drawing.Size(270, 38);
            this.MnuTCopy.Text = "複製";
            this.MnuTCopy.Click += new System.EventHandler(this.MnuTCopy_Click);
            // 
            // MnutPaste
            // 
            this.MnutPaste.Name = "MnutPaste";
            this.MnutPaste.Size = new System.Drawing.Size(270, 38);
            this.MnutPaste.Text = "貼上";
            this.MnutPaste.Click += new System.EventHandler(this.MnutPaste_Click);
            // 
            // MnuText
            // 
            this.MnuText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTFont,
            this.MnuTColor});
            this.MnuText.Name = "MnuText";
            this.MnuText.Size = new System.Drawing.Size(77, 34);
            this.MnuText.Text = "文字";
            // 
            // MnuTFont
            // 
            this.MnuTFont.Name = "MnuTFont";
            this.MnuTFont.Size = new System.Drawing.Size(270, 38);
            this.MnuTFont.Text = "字型";
            this.MnuTFont.Click += new System.EventHandler(this.MnuTFont_Click);
            // 
            // MnuTColor
            // 
            this.MnuTColor.Name = "MnuTColor";
            this.MnuTColor.Size = new System.Drawing.Size(270, 38);
            this.MnuTColor.Text = "顏色";
            this.MnuTColor.Click += new System.EventHandler(this.MnuTColor_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(77, 34);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // txt
            // 
            this.txt.AllowDrop = true;
            this.txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt.Location = new System.Drawing.Point(0, 38);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt.Size = new System.Drawing.Size(678, 405);
            this.txt.TabIndex = 1;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // MnuTUndo
            // 
            this.MnuTUndo.Name = "MnuTUndo";
            this.MnuTUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MnuTUndo.Size = new System.Drawing.Size(270, 38);
            this.MnuTUndo.Text = "undo";
            this.MnuTUndo.Click += new System.EventHandler(this.MnuTUndo_Click);
            // 
            // MnuTRedo
            // 
            this.MnuTRedo.Name = "MnuTRedo";
            this.MnuTRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MnuTRedo.Size = new System.Drawing.Size(270, 38);
            this.MnuTRedo.Text = "redo";
            this.MnuTRedo.Click += new System.EventHandler(this.MnuTRedo_Click);
            // 
            // MnuTCount
            // 
            this.MnuTCount.Name = "MnuTCount";
            this.MnuTCount.Size = new System.Drawing.Size(270, 38);
            this.MnuTCount.Text = "字數統計";
            this.MnuTCount.Click += new System.EventHandler(this.MnuTCount_Click);
            // 
            // MnuFindAndReplace
            // 
            this.MnuFindAndReplace.Name = "MnuFindAndReplace";
            this.MnuFindAndReplace.Size = new System.Drawing.Size(125, 34);
            this.MnuFindAndReplace.Text = "尋找取代";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "ChildForm";
            this.Text = "childForm";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.Resize += new System.EventHandler(this.ChildForm_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuTSave;
        private System.Windows.Forms.ToolStripMenuItem MnuTSaveNew;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit;
        private System.Windows.Forms.ToolStripMenuItem MnuTCut;
        private System.Windows.Forms.ToolStripMenuItem MnuTCopy;
        private System.Windows.Forms.ToolStripMenuItem MnutPaste;
        private System.Windows.Forms.ToolStripMenuItem MnuText;
        private System.Windows.Forms.ToolStripMenuItem MnuTFont;
        private System.Windows.Forms.ToolStripMenuItem MnuTColor;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ToolStripMenuItem MnuTUndo;
        private System.Windows.Forms.ToolStripMenuItem MnuTRedo;
        private System.Windows.Forms.ToolStripMenuItem MnuTCount;
        private System.Windows.Forms.ToolStripMenuItem MnuFindAndReplace;
    }
}

