using System;
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
using SideClass;


namespace FinancialPlaner
{
    public partial class MainForm : Form
    {
        List<PersonModel> users = new List<PersonModel>();
        public MainForm()
        {
            InitializeComponent();
            LoadUsersList();
            SQLiter.clearAllSessions();
            //MessageBox.Show((SQLiter.ComputeHash("q", new SHA256CryptoServiceProvider()) == SQLiter.ComputeHash("q", new SHA256CryptoServiceProvider())).ToString());

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

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new RegisterUser();
            f.Show();
            Hide();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            var f = new DeleteUser();
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите из программы ?", "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigation.toMainForm(new ChooseUser(), ActiveForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
