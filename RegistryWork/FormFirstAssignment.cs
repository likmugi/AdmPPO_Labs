using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace RegistryWork
{
    public partial class frmRegistryWork : Form
    {
        public frmRegistryWork()
        {
            InitializeComponent();

        }

        private void frmRegistryWork_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsFirstRun)
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Шамугия") != null)
                {
                    Registry.CurrentUser.DeleteSubKey(@"Software\Шамугия");
                }
                Properties.Settings.Default.IsFirstRun = false;
                Properties.Settings.Default.RunCount = 0;
                Properties.Settings.Default.Save();

                Registry.CurrentUser.CreateSubKey(@"Software\Шамугия");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Шамугия", true);
                key.SetValue("RunCount", Properties.Settings.Default.RunCount + 1, RegistryValueKind.DWord);
                key.Close();
            }
        }


        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.CreateSubKey("AdmPPO");
            Registry.CurrentUser.CreateSubKey(@"AdmPPO\Lecture");
            Registry.CurrentUser.CreateSubKey(@"AdmPPO\Practice");
        }

        private void btnCreateParam_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AdmPPO\Lecture", true);
            key.SetValue("Лекция 1", "Установка ПО");
            key.SetValue("Лекция 2", "Лицензирование ПО");
            key.Close();

            Registry.CurrentUser.CreateSubKey(@"AdmPPO\Practice").SetValue("Result", 15);
        }

        private void btnGetValueLecture1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AdmPPO\Lecture");
            txtbLecture1.Text = key.GetValue("Лекция 1").ToString();
            key.Close();
        }

        private void btnSetValueLecture1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AdmPPO\Lecture", true);
            key.SetValue("Лекция 1", txtbLecture1.Text);
            key.Close();
        }

        private void frmRegistryWork_Shown(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.RunCount != 0)
            {
               
                frmShareware sharewareForm = new frmShareware();
                sharewareForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Вы пользуетесь пробной версией программы. Ограничение пробной версии: " + Properties.Settings.Default.TrialVersionRuns + " запусков программы. Для полнофункционального пользования приобретите лицензию.");
                Properties.Settings.Default.RunCount++;
                Properties.Settings.Default.Save();
            }

            //modificated
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AdmPPO\Practice");
            if (key != null)
            {
                nudSetResult.Value = int.Parse(key.GetValue("Result").ToString());
                key.Close();
            }
        }

        private void nudSetResult_ValueChanged(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AdmPPO\Practice", true);
            key.SetValue("Result", nudSetResult.Value, RegistryValueKind.DWord);
            key.Close();
        }

        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AdmPPO\Practice", true))
            {
                if (key != null)
                {
                    if (key.GetValue("Result") != null)
                    {
                        key.DeleteValue("Result");
                    }
                }
            }
        }

        private void btnDeleteLectureKey_Click(object sender, EventArgs e)
        {

            if (Registry.CurrentUser.OpenSubKey(@"AdmPPO\Lecture") != null)
            {
                Registry.CurrentUser.DeleteSubKey(@"AdmPPO\Lecture");
            }

        }

        private void btnDeleteAdmPPOKey_Click(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey(@"AdmPPO") != null)
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"AdmPPO");
            }
        }

    }
}
