using System.Windows.Forms;

namespace wage_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            double hoen2 = Convert.ToDouble(hoen.Text);
            double paen2 = Convert.ToDouble(paen.Text);
            double irsbad = Convert.ToDouble(textBox67.Text);
            double dollas = paen2 * hoen2;
            double dollas2 = dollas * ((100 - irsbad) / 100);
            MessageBox.Show("your pay is " + dollas2,
           dollas2.ToString(),
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);

        }

        private void paen_TextChanged(object sender, EventArgs e)
        {

        }

        private void hoen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}