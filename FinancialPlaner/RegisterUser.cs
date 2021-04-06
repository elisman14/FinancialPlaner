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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
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
                SQLiter.saveUser(p);
                MessageBox.Show("Успешно зарегестрирован пользователь " + p.username);
                Navigation.toMainForm(new MainForm(), ActiveForm);
            }
        }

        private void toMainMenu_Click_1(object sender, EventArgs e)
        {
            Navigation.toMainForm(new MainForm(), ActiveForm);
        }
    }
}
