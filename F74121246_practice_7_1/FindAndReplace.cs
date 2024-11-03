using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74121246_practice_7_1
{
    public partial class FindAndReplace : Form
    {
        public event EventHandler<FindAndReplace_Package> Find;
        public event EventHandler<FindAndReplace_Package> Replace;
        public event EventHandler<FindAndReplace_Package> ReplaceAll;
        public FindAndReplace()
        {
            InitializeComponent();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Find?.Invoke(this, new FindAndReplace_Package(txtFind.Text, ""));
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtReplace.Text == "")
            {
                MessageBox.Show("請輸入要替換的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Replace?.Invoke(this, new FindAndReplace_Package(txtFind.Text, txtReplace.Text));
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtReplace.Text == "")
            {
                MessageBox.Show("請輸入要替換的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReplaceAll?.Invoke(this, new FindAndReplace_Package(txtFind.Text, txtReplace.Text));
        }
    }

    public class FindAndReplace_Package : EventArgs
    {
        public string txtFind;
        public string txtReplace;
        public FindAndReplace_Package(string txtFind, string txtReplace)
        {
            this.txtFind = txtFind;
            this.txtReplace = txtReplace;
        }
    }
}
