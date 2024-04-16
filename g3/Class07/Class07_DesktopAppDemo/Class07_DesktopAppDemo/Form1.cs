namespace Class07_DesktopAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Hide();
            label5.Hide();
            if(!int.TryParse(textBox1.Text, out int number1)) {
                label4.Show();
                return;
            }

            if (!int.TryParse(textBox2.Text, out int number2))
            {
                label5.Show();
                return;
            }

            int result = number1 + number2;

            textBox3.Text = result.ToString();
        }
    }
}
