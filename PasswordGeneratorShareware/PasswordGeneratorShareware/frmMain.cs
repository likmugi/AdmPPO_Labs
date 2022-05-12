using Microsoft.Win32;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Работа самого приложения

        int[] IntCount = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] SpecialItems = { "%", "*", "(", ")", "?", "!", "~", "#", "^", "&" };
        Random dice = new Random();

        private void btnPasswordGenerated_Click(object sender, EventArgs e)
        {
            if (cldPassword.CheckedItems.Count == 0) return;
            string PSW = "";
            for (int i = 0; i < nudPasswordLength.Value; i++)
            {
                int n = dice.Next(0, cldPassword.CheckedItems.Count);
                string s = cldPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        PSW += IntCount[dice.Next(IntCount.Length)].ToString();
                        break;

                    case "Прописные буквы":
                        PSW += Convert.ToChar(dice.Next(65, 88));
                        break;

                    case "Строчные буквы":
                        PSW += Convert.ToChar(dice.Next(97, 122));
                        break;

                    case "Спец. символы: %, *, ), ?, !, ~, #, ^, &":
                        PSW += SpecialItems[dice.Next(SpecialItems.Length)];
                        break;
                }
            }
            txtbPasswordGenerated.Text = PSW;
        }

        //Shareware 
        private void firstSettings()
        {
            if (Registry.CurrentUser.OpenSubKey(@"Software\Шамугия") == null)
            {
                Registry.CurrentUser.CreateSubKey(@"Software\Шамугия");
            }
            Properties.Settings.Default.IsFirstRun = false;
            Properties.Settings.Default.RunCount = 0;
            Properties.Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsFirstRun)
            {
                firstSettings();

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Шамугия", true);
                key.SetValue("RunCount", Properties.Settings.Default.RunCount + 1, RegistryValueKind.DWord);
                key.Close();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RunCount != 0)
            {

                frmShareware sharewareForm = new frmShareware();
                sharewareForm.ShowDialog();

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Шамугия", true);
                key.SetValue("RunCount", Properties.Settings.Default.RunCount);
                key.Close();

            }
            else
            {
                MessageBox.Show("Вы пользуетесь пробной версией программы. Ограничение пробной версии: " + Properties.Settings.Default.DemoVersionCount + " запусков программы. " +
                    "Для полнофункционального пользования приобретите лицензию.");
                Properties.Settings.Default.RunCount++;
                Properties.Settings.Default.Save();
            }
        }

    }
}
