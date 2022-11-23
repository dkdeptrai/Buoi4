namespace Bai2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer tmr = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            StartTimer();
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

    }
}