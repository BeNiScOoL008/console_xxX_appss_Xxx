namespace translateor_9000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "صباح الخير";
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "Buenos días";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "Guten Morgen";
        }
    }
}