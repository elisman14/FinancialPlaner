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

        List<PersonModel> users = new List<PersonModel>();
        public MainForm()
        {
            InitializeComponent();
            LoadUsersList();
            SQLiter.clearAllSessions();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            customizPanel();
            if (!OutputData.FromAnotherForm)
            {
                customization(); 
                listUsersListBox.BackColor = Color.FromArgb(242, 242, 242);
            }
        }

        public void theme()
        {
            switch(materialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                case true:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    listUsersListBox.BackColor = Color.FromArgb(242, 242, 242);
                    customizPanel();
                    OutputData.isThemeDark = false;
                    break;
                case false:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                    listUsersListBox.BackColor = Color.FromArgb(50, 50, 50);
                    customizPanel();
                    OutputData.isThemeDark = true;
                    break;
            }
        }

        
        public void customization()
        {
            if(OutputData.colorSchemeIndex > 2) OutputData.colorSchemeIndex = 0;
            switch (OutputData.colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(55, 71, 79);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(63, 81, 181);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    panel1.Visible = true;
                    panel1.BackColor = Color.FromArgb(67, 160, 71);
                    break;
            }
            OutputData.colorSchemeIndex++;
        }

        private void LoadUsersList()
        {
            try
            {
                users = SQLiter.getUsers();
                WireiUpUsersList();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
            }
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
    }
}
