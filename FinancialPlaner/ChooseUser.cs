using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialPlanerDB;
using MaterialSkin.Controls;
using SideClass;

namespace FinancialPlaner
{
    public partial class ChooseUser : MaterialForm
    {
        public ChooseUser()
        {
            InitializeComponent();

            customizeLabels(); 
        }


        private void customizeLabels()
        {
            switch (OutputData.isThemeDark)
            {
                case true:
                    label2.BackColor = Color.FromArgb(50, 50, 50);
                    label2.ForeColor = Color.FromArgb(242, 242, 242);
                    label3.BackColor = Color.FromArgb(50, 50, 50);
                    label3.ForeColor = Color.FromArgb(242, 242, 242);

                    username.BackColor = Color.FromArgb(50, 50, 50);
                    username.ForeColor = Color.FromArgb(242, 242, 242);
                    password.BackColor = Color.FromArgb(50, 50, 50);
                    password.ForeColor = Color.FromArgb(242, 242, 242);
                    break;
                case false:
                    label2.BackColor = Color.FromArgb(242, 242, 242);
                    label2.ForeColor = Color.FromArgb(50, 50, 50);
                    label3.BackColor = Color.FromArgb(242, 242, 242);
                    label3.ForeColor = Color.FromArgb(50, 50, 50);

                    username.BackColor = Color.FromArgb(242, 242, 242);
                    username.ForeColor = Color.FromArgb(50, 50, 50);
                    password.BackColor = Color.FromArgb(242, 242, 242);
                    password.ForeColor = Color.FromArgb(50, 50, 50);
                    break;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string realPassword = SQLiter.getUserPassword(username.Text);
                if (realPassword == SQLiter.ComputeHash(password.Text, new SHA256CryptoServiceProvider()))
                {
                    SQLiter.activateCurrentUser(username.Text);
                    LogMessages.successfulLogin();
                    Navigation.toMainForm(new expensesForm(), ActiveForm);
                }
                else LogMessages.wrongData();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
            }

        }


        private void toMainMenu_Click(object sender, EventArgs e)
        {
            OutputData.FromAnotherForm = true;
            Navigation.toMainForm(new MainForm(), ActiveForm);
        }

        
        private void restorePasswordButton_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new RestorePasswordForm(), ActiveForm);
        }
    }
}
