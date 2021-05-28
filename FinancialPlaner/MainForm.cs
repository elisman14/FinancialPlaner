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
using MaterialSkin;
using MaterialSkin.Controls;
using SideClass;


namespace FinancialPlaner
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int colorSchemeIndex = 0;

        List<PersonModel> users = new List<PersonModel>();
        public MainForm()
        {
            InitializeComponent();
            LoadUsersList();
            SQLiter.clearAllSessions();
            
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            customization();
        }

        public void theme()
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        
        public void customization()
        {
            if(colorSchemeIndex > 2) colorSchemeIndex = 0;
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
            colorSchemeIndex++;
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

        private void customizeButton_Click(object sender, EventArgs e)
        {
            customization();
        }

        private void themeButton_Click(object sender, EventArgs e)
        {
            theme();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
