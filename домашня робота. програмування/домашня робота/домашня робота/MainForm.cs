namespace домашня_робота
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string a = TxtBox1.Text;
            string b = TxtBox2.Text;
            label1.Text = "Відповідь: " + (Convert.ToDouble(a) - Convert.ToDouble(b)).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string a = TxtBox1.Text;
            string b = TxtBox2.Text;
            label1.Text = "Відповідь: " + (Convert.ToDouble(a) * Convert.ToDouble(b)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string a = TxtBox1.Text;
            string b = TxtBox2.Text;
            label1.Text = "Відповідь: " + (Convert.ToDouble(a) / Convert.ToDouble(b)).ToString();
        }
    }
}
