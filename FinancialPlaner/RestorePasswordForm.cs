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
    public partial class RestorePasswordForm : MaterialForm
    {
        public RestorePasswordForm()
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
                    label6.BackColor = Color.FromArgb(50, 50, 50);
                    label6.ForeColor = Color.FromArgb(242, 242, 242);
                    questionLabel.BackColor = Color.FromArgb(50, 50, 50);
                    questionLabel.ForeColor = Color.FromArgb(242, 242, 242);

                    username.BackColor = Color.FromArgb(50, 50, 50);
                    username.ForeColor = Color.FromArgb(242, 242, 242);
                    answerControlQuestion.BackColor = Color.FromArgb(50, 50, 50);
                    answerControlQuestion.ForeColor = Color.FromArgb(242, 242, 242);
                    break;
                case false:
                    label1.BackColor = Color.FromArgb(242, 242, 242);
                    label1.ForeColor = Color.FromArgb(50, 50, 50);
                    label6.BackColor = Color.FromArgb(242, 242, 242);
                    label6.ForeColor = Color.FromArgb(50, 50, 50);
                    questionLabel.BackColor = Color.FromArgb(242, 242, 242);
                    questionLabel.ForeColor = Color.FromArgb(50, 50, 50);

                    username.BackColor = Color.FromArgb(242, 242, 242);
                    username.ForeColor = Color.FromArgb(50, 50, 50);
                    answerControlQuestion.BackColor = Color.FromArgb(242, 242, 242);
                    answerControlQuestion.ForeColor = Color.FromArgb(50, 50, 50);
                    break;
            }
        }

        private void confirmLofinButton_Click(object sender, EventArgs e)
        {
            try
            {
                string question = SQLiter.getQuestion(username.Text);
                questionLabel.Text = question;
            }
            catch (Exception)
            {
                MessageBox.Show("Пользователя с указанным логином не существует");
            }
        }

        private void restorePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQLiter.isAnswerCorrect(answerControlQuestion.Text, username.Text))
                {
                    SQLiter.activateCurrentUser(username.Text);
                    Navigation.toMainForm(new ChangePasswordForm(), ActiveForm);
                }
                else MessageBox.Show("Ответ неверный");
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
            }
            
        }
    }
}
