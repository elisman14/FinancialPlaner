using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialPlanerDB;
using MaterialSkin.Controls;
using SideClass;

namespace FinancialPlaner
{
    public partial class RegisterUser : MaterialForm
    {
        public RegisterUser()
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
                    label1.BackColor = Color.FromArgb(50, 50, 50);
                    label1.ForeColor = Color.FromArgb(242, 242, 242);
                    label5.BackColor = Color.FromArgb(50, 50, 50);
                    label5.ForeColor = Color.FromArgb(242, 242, 242);
                    label6.BackColor = Color.FromArgb(50, 50, 50);
                    label6.ForeColor = Color.FromArgb(242, 242, 242);
                    label7.BackColor = Color.FromArgb(50, 50, 50);
                    label7.ForeColor = Color.FromArgb(242, 242, 242);

                    username.BackColor = Color.FromArgb(50, 50, 50);
                    username.ForeColor = Color.FromArgb(242, 242, 242);
                    password.BackColor = Color.FromArgb(50, 50, 50);
                    password.ForeColor = Color.FromArgb(242, 242, 242);
                    name.BackColor = Color.FromArgb(50, 50, 50);
                    name.ForeColor = Color.FromArgb(242, 242, 242);
                    controlQuestion.BackColor = Color.FromArgb(50, 50, 50);
                    controlQuestion.ForeColor = Color.FromArgb(242, 242, 242);
                    answerControlQuestion.BackColor = Color.FromArgb(50, 50, 50);
                    answerControlQuestion.ForeColor = Color.FromArgb(242, 242, 242);
                    break;
                case false:
                    label2.BackColor = Color.FromArgb(242, 242, 242);
                    label2.ForeColor = Color.FromArgb(50, 50, 50);
                    label1.BackColor = Color.FromArgb(242, 242, 242);
                    label1.ForeColor = Color.FromArgb(50, 50, 50);
                    label5.BackColor = Color.FromArgb(242, 242, 242);
                    label5.ForeColor = Color.FromArgb(50, 50, 50);
                    label6.BackColor = Color.FromArgb(242, 242, 242);
                    label6.ForeColor = Color.FromArgb(50, 50, 50);
                    label7.BackColor = Color.FromArgb(242, 242, 242);
                    label7.ForeColor = Color.FromArgb(50, 50, 50);

                    username.BackColor = Color.FromArgb(242, 242, 242);
                    username.ForeColor = Color.FromArgb(50, 50, 50);
                    password.BackColor = Color.FromArgb(242, 242, 242);
                    password.ForeColor = Color.FromArgb(50, 50, 50);
                    name.BackColor = Color.FromArgb(242, 242, 242);
                    name.ForeColor = Color.FromArgb(50, 50, 50);
                    controlQuestion.BackColor = Color.FromArgb(242, 242, 242);
                    controlQuestion.ForeColor = Color.FromArgb(50, 50, 50);
                    answerControlQuestion.BackColor = Color.FromArgb(242, 242, 242);
                    answerControlQuestion.ForeColor = Color.FromArgb(50, 50, 50);
                    break;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                PersonModel p = new PersonModel();
                p.name = name.Text;
                p.username = username.Text;
                p.password = password.Text;
                p.question = controlQuestion.Text;
                p.questionAnswer = answerControlQuestion.Text;
                
                try
                {
                    SQLiter.saveUser(p);
                    MessageBox.Show("Успешно зарегестрирован пользователь " + p.username);
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так");
                }

                
                Navigation.toMainForm(new MainForm(), ActiveForm);
            }
        }

        private void toMainMenu_Click_1(object sender, EventArgs e)
        {
            OutputData.FromAnotherForm = true;
            Navigation.toMainForm(new MainForm(), ActiveForm);
        }
    }
}
