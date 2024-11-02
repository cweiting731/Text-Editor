using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace F74121246_practice_7_1
{
    public partial class ParentForm : Form
    {

        public ParentForm()
        {
            InitializeComponent();
        }
        private void ParentForm_Load(object sender, EventArgs e) // 初始化
        {
            menu.MdiWindowListItem = FileMnu;
        }

        private void FinishToolStripMenuItem_Click(object sender, EventArgs e) // 結束
        {
            Application.Exit();
        }

        private void AddNewPage_Click(object sender, EventArgs e) // 新增檔案
        {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Text = "newPage";
            childForm.Show();
        }

        private void MnuTOpenFile_Click(object sender, EventArgs e) // 開啟檔案
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文字檔 (*.txt)|*.txt|自訂文字檔 (*.mytxt)|*.mytxt";
            openFileDialog.InitialDirectory = Path.GetFullPath("../../saves");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ChildForm childForm = new ChildForm(filePath);
                childForm.MdiParent = this;
                childForm.Text = Path.GetFileNameWithoutExtension(filePath);
                childForm.Show();
            }
        }
    }
}
