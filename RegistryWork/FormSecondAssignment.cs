using Microsoft.Win32;
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

            lblRunCount.Text = (trialCount - Properties.Settings.Default.RunCount - 1).ToString();
            if (Properties.Settings.Default.RunCount ==  trialCount)
            {
                lblRunCount.Text = "Пробный период истек!";
                btnRunCountFamiliarized.Text = "Закрыть программу";
            }
            
        }

        private void btnRunCountFamiliarized_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RunCount == trialCount)
            {
                Application.Exit();
            }
            else
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Шамугия", true))
                {
                    Properties.Settings.Default.RunCount++;
                    Properties.Settings.Default.Save();
                    key.SetValue("RunCount", Properties.Settings.Default.RunCount);
                    key.Close();
                }
                this.Close();
            }
        }

    }
}
