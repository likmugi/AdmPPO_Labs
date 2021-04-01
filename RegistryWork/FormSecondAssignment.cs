using System;
using System.Windows.Forms;

namespace RegistryWork
{
    public partial class frmShareware : Form
    {
        
        public frmShareware()
        {
            InitializeComponent();

        }
        public int trialCount = Properties.Settings.Default.TrialVersionRuns;
        private void frmShareware_Load(object sender, EventArgs e)
        {

            lblRunCount.Text = (trialCount - Properties.Settings.Default.RunCount).ToString();
            if (Properties.Settings.Default.RunCount >=  trialCount + 1)
            {
                lblRunCount.Text = "Пробный период истек!";
                btnRunCountFamiliarized.Text = "Закрыть программу";
            }
            
        }

        private void btnRunCountFamiliarized_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RunCount >= trialCount + 1)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

    }
}
