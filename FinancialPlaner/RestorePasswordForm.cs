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
using SideClass;

namespace FinancialPlaner
{
    public partial class RestorePasswordForm : Form
    {
        public RestorePasswordForm()
        {
            InitializeComponent();
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

                if (SQLiter.isAnswerCorrect(answerControlQuestion.Text, username.Text))
                    Navigation.toMainForm(new ChangePasswordForm(), ActiveForm);
                else MessageBox.Show("Ответ неверный");

        }
    }
}
