using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml;

namespace Bai4
{
    public partial class Form1 : Form
    {
        string FilePath = "";
        public Form1()
        {
            InitializeComponent();
            richTextBox1.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                CBFontFamily.Items.Add(font.Name);
            }
            CBFontFamily.Text = "Tahoma";
            CBFontSize.Text = "14";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tạoVănBảnMớiToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lưuNộiDungVănBảnToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Underline);
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            FilePath = "";
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "Select a text file";
            dialog.Filter = "txt file (*txt)|*.txt|rtf file (*.rtf)|*.rtf";
            dialog.Title = "Open text file";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
                StreamReader streamReader = new StreamReader(FilePath);
                richTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save text files";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = "*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                    FilePath = saveFileDialog.FileName;
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(FilePath);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Bold);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Italic);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK || fontDialog.ShowApply)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                CBFontFamily.Text = fontDialog.Font.Name;
                CBFontSize.Text = fontDialog.Font.Size.ToString();
            }
        }
    }
}