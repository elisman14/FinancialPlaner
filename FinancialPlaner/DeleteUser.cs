using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SideClass;
using FinancialPlanerDB;
using System.Security.Cryptography;
using MaterialSkin.Controls;

namespace FinancialPlaner
{
    public partial class DeleteUser : MaterialForm
    {
        List<PersonModel> users = new List<PersonModel>();
        public DeleteUser()
        {
            InitializeComponent();
            LoadUsersList();

            CheckThemeStatus();
            customizPanel();
            customizeLabels();
        }

        private void customizeLabels()
        {
            switch (OutputData.isThemeDark)
            {
                case true:
                    label1.BackColor = Color.FromArgb(50, 50, 50);
                    label1.ForeColor = Color.FromArgb(242, 242, 242);
                    
                    break;
                case false:
                    label1.BackColor = Color.FromArgb(242, 242, 242);
                    label1.ForeColor = Color.FromArgb(50, 50, 50);
                    break;
            }
        }
        private void LoadUsersList()
        {
            users = SQLiter.getUsers();
            WireiUpUsersList();
        }
        private void WireiUpUsersList()
        {
            try
            {
                listUsersListBox.DataSource = null;
                listUsersListBox.DataSource = users;
                listUsersListBox.DisplayMember = "username";
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void CheckThemeStatus()
        {
            switch (OutputData.isThemeDark)
            {
                case true:
                    listUsersListBox.BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case false:
                    listUsersListBox.BackColor = Color.FromArgb(242, 242, 242);
                    break;
            }
        }

        public void customizPanel()
        {
            switch (OutputData.colorSchemeIndex - 1)
            {
                case 0:
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(55, 71, 79);
                    break;
                case 1:
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(63, 81, 181);
                    break;
                case 2:
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(67, 160, 71);
                    break;
                default:
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(67, 160, 71);
                    break;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            // string selecteduesr = listUsersListBox.Items[listUsersListBox.SelectedIndex].ToString();
            string selecteduser = listUsersListBox.Text;
            p.username = selecteduser;
            string password = Interaction.InputBox("Введите пароль выбранного пользователя: ", "Введите значение", "", -1);
            try
            {
                string realPassword = SQLiter.getUserPassword(selecteduser);

                if (realPassword == SQLiter.ComputeHash(password, new SHA256CryptoServiceProvider()))
                {
                    // Results.setCurrentUser(selecteduser);
                    SQLiter.deleteUser(p);
                    MessageBox.Show("Удалён пользователь " + listUsersListBox.Text + ".");
                    LoadUsersList();

                }
                else MessageBox.Show("Введён неправильный пароль");
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
    }
}
