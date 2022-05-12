using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorShareware
{
    public partial class frmShareware : Form
    {
        public frmShareware()
        {
            InitializeComponent();
        }

        private void frmShareware_Load(object sender, EventArgs e)
        {
            lblRunCount.Text = (Properties.Settings.Default.DemoVersionCount - Properties.Settings.Default.RunCount).ToString();
            if (Properties.Settings.Default.RunCount == Properties.Settings.Default.DemoVersionCount) 
            {
                lblRunCount.Text = "Пробный период истек!";
                btnRunCountFamiliarized.Text = "Закрыть программу";
            }
        }

        private void btnRunCountFamiliarized_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RunCount == Properties.Settings.Default.DemoVersionCount)
            {
                Application.Exit();
            }
            else
            {
                Properties.Settings.Default.RunCount++;
                Properties.Settings.Default.Save();
                this.Close();
            }

        }
    }
}
