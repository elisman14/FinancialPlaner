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

namespace FinancialPlaner
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            string username = SQLiter.getActiveUser();
            qurrentPassword.Text = SQLiter.getUserPassword(username);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = SQLiter.ComputeHash(textBox1.Text, new SHA256CryptoServiceProvider());
            string username = SQLiter.getActiveUser();
            DialogResult result = MessageBox.Show("Вы уверены в том, что хотите изменить пароль ?", "Инфо",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SQLiter.changePassword(username, password);
                MessageBox.Show("Пароль успешно изменён");
                Navigation.toMainForm(new expensesForm(), ActiveForm);
            }
        }

        private void dontChange_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new expensesForm(), ActiveForm);
        }
    }
}
