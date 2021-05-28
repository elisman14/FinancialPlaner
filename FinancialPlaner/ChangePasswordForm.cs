using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SideClass;
using FinancialPlanerDB;
using System.Security.Cryptography;
using MaterialSkin.Controls;

namespace FinancialPlaner
{
    public partial class ChangePasswordForm : MaterialForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == TextBox2.Text)
            {
                DialogResult result = MessageBox.Show("Вы уверены в том, что хотите изменить пароль ?", "Инфо",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SQLiter.changePassword(SQLiter.getActiveUser(), SQLiter.ComputeHash(textBox1.Text, new SHA256CryptoServiceProvider()));
                    MessageBox.Show("Пароль успешно изменён");
                    Navigation.toMainForm(new expensesForm(), ActiveForm);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают! Введите пароли еще раз, пожалуйста!");
                textBox1.Text = "";
                TextBox2.Text = "";
            }
        }

        private void dontChange_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new expensesForm(), ActiveForm);
        }
    }
}
