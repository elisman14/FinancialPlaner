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

            customizeLabels();
        }

        private void customizeLabels()
        {
            switch (OutputData.isThemeDark)
            {
                case true:
                    label1.BackColor = Color.FromArgb(50, 50, 50);
                    label1.ForeColor = Color.FromArgb(242, 242, 242);
                    label3.BackColor = Color.FromArgb(50, 50, 50);
                    label3.ForeColor = Color.FromArgb(242, 242, 242);

                    textBox1.BackColor = Color.FromArgb(50, 50, 50);
                    textBox1.ForeColor = Color.FromArgb(242, 242, 242);
                    TextBox2.BackColor = Color.FromArgb(50, 50, 50);
                    TextBox2.ForeColor = Color.FromArgb(242, 242, 242);
                    break;
                case false:
                    label1.BackColor = Color.FromArgb(242, 242, 242);
                    label1.ForeColor = Color.FromArgb(50, 50, 50);
                    label3.BackColor = Color.FromArgb(242, 242, 242);
                    label3.ForeColor = Color.FromArgb(50, 50, 50);

                    textBox1.BackColor = Color.FromArgb(242, 242, 242);
                    textBox1.ForeColor = Color.FromArgb(50, 50, 50);
                    TextBox2.BackColor = Color.FromArgb(242, 242, 242);
                    TextBox2.ForeColor = Color.FromArgb(50, 50, 50);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == TextBox2.Text)
            {
                if (SQLiter.ComputeHash(textBox1.Text, new SHA256CryptoServiceProvider()) != SQLiter.getUserPassword(SQLiter.getActiveUser()))
                {
                    DialogResult result = MessageBox.Show("Вы уверены в том, что хотите изменить пароль ?", "Инфо",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SQLiter.changePassword(SQLiter.getActiveUser(), SQLiter.ComputeHash(textBox1.Text, new SHA256CryptoServiceProvider()));
                            MessageBox.Show("Пароль успешно изменён");
                            Navigation.toMainForm(new expensesForm(), ActiveForm);
                        } catch (Exception)
                        {
                            MessageBox.Show("Что-то пошло не так");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Новый пароль совпадает со старым");
                    TextBox2.Text = "";
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают! Введите пароли еще раз, пожалуйста!");
                textBox1.Text = "";
                TextBox2.Text = "";
            }
        }

    }
}
