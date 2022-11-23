using Microsoft.VisualBasic.FileIO;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FromDialog = new FolderBrowserDialog();
            DialogResult result = FromDialog.ShowDialog();
            textBox1.Text = FromDialog.SelectedPath.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ToDialog = new FolderBrowserDialog();
            DialogResult result2 = ToDialog.ShowDialog();
            textBox2.Text = ToDialog.SelectedPath.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Directory.GetFiles(textBox1.Text).Length-1;
                int progress = 0;
                foreach (var file in Directory.GetFiles(textBox1.Text))
                {
                    File.Copy(file, Path.Combine(textBox2.Text, Path.GetFileName(file)));
                    progressBar1.Value = progress++;
                }
                MessageBox.Show("Sao chép thành công");
                progressBar1.Value=0;
            }
            else
                MessageBox.Show("Sao chép thất bại");
        }
    }
}