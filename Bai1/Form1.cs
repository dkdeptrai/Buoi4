namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point MouseLocation = e.Location;
            if(e.Button == MouseButtons.Left)
            {
                MessageBox.Show($"Vị trí của con trỏ khỉ click: {MouseLocation.X}, {MouseLocation.Y}", "Chuột Trái Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Vị trí của con trỏ khỉ click: {MouseLocation.X}, {MouseLocation.Y}", "Chuột Phải Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show($"Vị trí của con trỏ khỉ click: {MouseLocation.X}, {MouseLocation.Y}", "Con Lăn Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "";
            string Key = e.KeyData.ToString();
            string KeyCode = e.KeyValue.ToString();
            label1.Text = $"{Key}, ASCII Code: {KeyCode}";
        }
    }
}