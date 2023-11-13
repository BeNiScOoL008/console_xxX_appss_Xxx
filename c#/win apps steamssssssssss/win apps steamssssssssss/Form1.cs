namespace win_apps_steamssssssssss
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label13.Text = textBox37.Text.ToLower();
            textBox37.Text = "";
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = textBox37.Text.ToUpper();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label13.Text = textBox37.Text.ToLower();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "FATAL ERROR",
                "PLEASE RESTART IMMEDIATLY",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading);


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}