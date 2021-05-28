﻿using System;
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
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string realPassword = SQLiter.getUserPassword(username.Text);
            if (realPassword == SQLiter.ComputeHash(password.Text, new SHA256CryptoServiceProvider()))
            {
                LogMessages.successfulLogin();
                SQLiter.activateCurrentUser(username.Text);
                Navigation.toMainForm(new expensesForm(), ActiveForm);
            }
            else LogMessages.wrongData();
        }


        private void toMainMenu_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new MainForm(), ActiveForm);
        }

        
        private void restorePasswordButton_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new RestorePasswordForm(), ActiveForm);
        }
    }
}
