using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74121246_practice_7_1
{
    public partial class ChildForm : Form
    {
        int MAX_REDO_TXT_AMOUNT = 10;
        int MAX_REDO_UNDO_LENGTH = 20;
        string filePath = "";
        Stack<string> undo;
        Stack<string> redo;
        string nowTxT;
        public ChildForm() // 新增檔案
        {
            InitializeComponent();
        }

        public ChildForm(string filePath) // 開啟檔案
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void Open_File() // 真 開啟檔案
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();
            string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine(fileContent);
            switch (fileExtension)
            {
                case ".txt":
                    txt.Text = fileContent;
                    break;
                case ".mytxt":
                    initTxT(fileContent);
                    break;
            }
            txt.Select(0, 0);
            this.Focus();
        }
        private void initTxT(string content) // 檔案變化 (開啟檔案 & redo undo) 拆包
        {
            string[] lines = content.Split(new[] { '\n' }, 2);
            string[] config = lines[0].Split(new[] { ',' });
            if (config.Length == 6) // check
            {
                string fontName = config[0];
                float fontSize = float.Parse(config[1]);
                int A = int.Parse(config[2]);
                int R = int.Parse(config[3]);
                int G = int.Parse(config[4]);
                int B = int.Parse(config[5]);

                txt.Font = new Font(fontName, fontSize);
                txt.ForeColor = Color.FromArgb(A, R, G, B);
                txt.Text = lines[1];
            }
        }
        private void ChildForm_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Load");
            if (menu != null)
            {
                foreach (ToolStripMenuItem item in menu.Items)
                {
                    item.MergeAction = MergeAction.Insert;
                }
                txt.Height = (this.ClientSize.Height - menu.Height);
            }
            else
            {
                Console.WriteLine("child menu null");
            }

            if (filePath != "") Open_File();
            undo = new Stack<string>(MAX_REDO_UNDO_LENGTH);
            redo = new Stack<string>(MAX_REDO_UNDO_LENGTH);
            MnuTUndo.Enabled = false;
            MnuTRedo.Enabled = false;
            nowTxT = Merge_txt();
        }

        private void ChildForm_Resize(object sender, EventArgs e) // 更改視窗大小
        {
            txt.Height = (this.ClientSize.Height - menu.Height);
        }

        private void MnuExit_Click(object sender, EventArgs e) // 離開
        {
            this.Close();
        }

        private void MnuTFont_Click(object sender, EventArgs e) // 更改字型
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txt.Font = fontDialog.Font;
                Save_Undo();
            }
        }

        private void MnuTColor_Click(object sender, EventArgs e) // 更改顏色
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txt.ForeColor = colorDialog.Color;
                Save_Undo();
            }
        }
        string tmpTxt = "";
        private void MnuTCut_Click(object sender, EventArgs e) // 剪下
        {
            tmpTxt = txt.SelectedText;
            txt.SelectedText = "";
        }

        private void MnuTCopy_Click(object sender, EventArgs e) // 複製
        {
            tmpTxt = txt.SelectedText;
        }

        private void MnutPaste_Click(object sender, EventArgs e) // 貼上
        {
            txt.SelectedText = tmpTxt;
        }

        private void MnuTSave_Click(object sender, EventArgs e) // 儲存
        {
            string fileExtension = "";
            if (File.Exists(filePath))
            {
                fileExtension = Path.GetExtension(filePath).ToLower();
                File.Delete(filePath);
                string savetxt = Merge_txt(fileExtension);
                File.WriteAllText(filePath, savetxt);
                MessageBox.Show("存檔成功");
            }
            else
            {
                Save_New();
            }

        }

        private void MnuTSaveNew_Click(object sender, EventArgs e) // 另存新檔
        {
            Save_New();
        }

        private void Save_New() // 真 另存新檔
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文字檔 (*.txt)|*.txt|自訂文字檔 (*.mytxt)|*.mytxt";
            saveFileDialog.InitialDirectory = Path.GetFullPath("../../saves");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();
                string savetxt = Merge_txt(fileExtension);
                File.WriteAllText(filePath, savetxt);
                MessageBox.Show("創建成功");
            }
        }

        private string Merge_txt(string fileExtension) // 拿到儲存文字
        {
            string after = "";
            switch (fileExtension)
            {
                case ".txt":
                    after = txt.Text;
                    break;
                case ".mytxt":
                    after = Merge_txt();
                    break;
            }
            return after;
        }

        private string Merge_txt() // 儲存完整文字 裝包
        {
            return $"{txt.Font.Name},{txt.Font.Size},{txt.ForeColor.A},{txt.ForeColor.R},{txt.ForeColor.G},{txt.ForeColor.B}\n{txt.Text}";
        }

        private void MnuTCount_Click(object sender, EventArgs e) // 字數統計
        {
            int count = 0;
            foreach (char c in txt.Text.ToCharArray())
            {
                if (!char.IsWhiteSpace(c)) count++;
            }
            MessageBox.Show("字數: " + count.ToString(), "字數統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool redoing_and_undoing = false;
        bool undoFinish = false;
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (!redoing_and_undoing) // 存進 undo
            {
                Save_Undo();
            }

            if (!redoing_and_undoing) // 沒在做redo & undo
            {
                if (redo.Count != 0) redo.Clear(); // 刪除 redo 內容
                if (redo.Count == 0) MnuTRedo.Enabled = false;
            }
            else // 正在做 redo & undo 將 redoing_and_undoing 清空
            {
                redoing_and_undoing = false;
            }
        }

        private void Save_Undo()
        {
            if (undo.Count >= MAX_REDO_UNDO_LENGTH) // undo 量爆炸
            {
                Console.WriteLine("bomb !");
                Queue<string> tmp = new Queue<string>(undo.Reverse());
                tmp.Dequeue();
                undo = new Stack<string>(tmp.ToArray());
                testUndoRedo();
            }
            undo.Push(nowTxT);
            nowTxT = Merge_txt();
            if (undo.Count > 0) MnuTUndo.Enabled = true;
            Console.WriteLine("save undo");
        }

        private void MnuTUndo_Click(object sender, EventArgs e) // undo
        {
            
            if (undo.Count > 0)
            {
                redoing_and_undoing = true;
                redo.Push(nowTxT);
                nowTxT = undo.Pop();
                initTxT(nowTxT);
                testUndoRedo();
            }
            
            if (undo.Count == 0)
                MnuTUndo.Enabled = false;
            else 
                MnuTUndo.Enabled = true;
            if (redo.Count == 0)
                MnuTRedo.Enabled = false;
            else
                MnuTRedo.Enabled = true;
        }

        private void MnuTRedo_Click(object sender, EventArgs e) // redo
        {
            
            if (redo.Count > 0)
            {
                redoing_and_undoing = true;
                undo.Push(nowTxT);
                nowTxT = redo.Pop();
                initTxT(nowTxT);
                testUndoRedo();
            }

            if (undo.Count == 0)
                MnuTUndo.Enabled = false;
            else
                MnuTUndo.Enabled = true;
            if (redo.Count == 0)
                MnuTRedo.Enabled = false;
            else
                MnuTRedo.Enabled = true;
        }

        private void testUndoRedo() // print undo and redo
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"undo: {undo.Count}");
            int count = 1;
            foreach (string s in undo)
            {
                Console.WriteLine(count++);
                Console.WriteLine(s.Split(new[] {'\n'}, 2)[1]);
            }
            count = 1;
            Console.WriteLine($"redo: {redo.Count}");
            foreach (string s in redo)
            {
                Console.WriteLine(count++);
                Console.WriteLine(s.Split(new[] { '\n' }, 2)[1]);
            }
        }
    }
}
