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

namespace FinancialPlaner
{
    public partial class DeleteUser : Form
    {
        List<PersonModel> users = new List<PersonModel>();
        public DeleteUser()
        {
            InitializeComponent();
            LoadUsersList();
        }
        private void LoadUsersList()
        {
            users = SQLiter.getUsers();
            WireiUpUsersList();
        }
        private void WireiUpUsersList()
        {
            listUsersListBox.DataSource = null;
            listUsersListBox.DataSource = users;
            listUsersListBox.DisplayMember = "username";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            // string selecteduesr = listUsersListBox.Items[listUsersListBox.SelectedIndex].ToString();
            string selecteduser = listUsersListBox.Text;
            p.username = selecteduser;
            string password = Interaction.InputBox("Введите пароль выбранного пользователя: ", "Введите значение", "", -1);
            string realPassword = SQLiter.getUserPassword(selecteduser);
            if (realPassword == password)
            {
                // Results.setCurrentUser(selecteduser);
                SQLiter.deleteUser(p);
                MessageBox.Show("Удалён пользователь " + listUsersListBox.Text + ".");
                LoadUsersList();

            }
            else MessageBox.Show("Введён неправильный пароль");
         
        }

        private void toMainMenu_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new MainForm(), ActiveForm);
        }
    }
}
