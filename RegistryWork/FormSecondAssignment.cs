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
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Шамугия");
            lblRunCount.Text = (trialCount - Properties.Settings.Default.RunCount).ToString() + " " + key.GetValue("RunCount").ToString();
            key.Close();

            if (Properties.Settings.Default.RunCount >=  trialCount + 1)
            {
                lblRunCount.Text = "Пробная версия истекла";
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
