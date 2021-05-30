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
using Microsoft.VisualBasic;

using SideClass;

namespace FinancialPlaner
{
    public partial class expensesForm : MaterialForm
    {
        List<CategoryModel> categories = new List<CategoryModel>();

        public expensesForm()
        {
            InitializeComponent();
            LoadCategoriesList();
            OutputStat();

            CheckThemeStatus();
            customizPanel();
            customizeLabels();
        }

        private void CheckThemeStatus()
        {
            switch(OutputData.isThemeDark)
            {
                case true:
                    tabPage1.BackColor = Color.FromArgb(50, 50, 50);
                    tabPage2.BackColor = Color.FromArgb(50, 50, 50);
                    tabPage3.BackColor = Color.FromArgb(50, 50, 50);
                    tabPage4.BackColor = Color.FromArgb(50, 50, 50);
                    categoriesListBox.BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case false:
                    tabPage1.BackColor = Color.FromArgb(242,242,242);
                    tabPage2.BackColor = Color.FromArgb(242, 242, 242);
                    tabPage3.BackColor = Color.FromArgb(242, 242, 242);
                    tabPage4.BackColor = Color.FromArgb(242, 242, 242);
                    categoriesListBox.BackColor = Color.FromArgb(242, 242, 242);
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

        private void LoadCategoriesList()
        {
            try 
            {
                categories = SQLiter.getCategories();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
            }
            
            WireiUpUsersList();
        }
        private void WireiUpUsersList()
        {
            categoriesListBox.DataSource = null;
            categoriesListBox.DataSource = categories;
            categoriesListBox.DisplayMember = "name";

        }

        private void OutputStat()
        {
            OutputData.outputStat(MonthlyStat_DGV, SQLiter.takeMonthFromCurrentDate(), "m", true);
            CurrentMonth_label.Text = "Отображается статистика за " + SQLiter.takeMonthFromCurrentDate().Replace("0", "") + " месяц!";
            OutputData.outputStat(YearlyStat_DGV, SQLiter.takeYearFromCurrentDate(), "Y", true);
            CurrentYear_label.Text = "Отображается статистика за " + SQLiter.takeYearFromCurrentDate() + " год!";
            OutputData.outputStat(AllTimeStat_DGV, "", "", false);
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                var category = categoriesListBox.SelectedItem as CategoryModel;
                if (category != null)
                {
                    categoryLabel.Text = category.name;

                    try 
                    {
                        OutputData.outputExpensesToDgv(dataGridView1, category.name);

                        var mlrArray = SQLiter.getMLRSum(category.name);
                        maxSumLabel.Text = mlrArray[0].ToString();
                        lostSumLabel.Text = mlrArray[1].ToString();
                        remainingSumLabel.Text = mlrArray[2].ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                    
                }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name, maxSum;
                name = Interaction.InputBox("Введите названия новой категории:");
                maxSum = Interaction.InputBox("Введите максимальную сумму новой категории:");
                SQLiter.createNewCategory(name, maxSum);
                LoadCategoriesList();
            } catch (Exception)
            {
                MessageBox.Show("Такая категория уже существует.");
            }
        }

        private void addPaynment_Click(object sender, EventArgs e)
        {
            string name, cost, user;
            name = Interaction.InputBox("Введите названия новой покупки:");
            cost = Interaction.InputBox("Введите сумму новой покупки:");
            try
            {
                user = SQLiter.getActiveUser();
                SQLiter.addPaynment(name, categoryLabel.Text, cost, user);
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
            }
            
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            var category = categoriesListBox.SelectedItem as CategoryModel;
            DialogResult result = MessageBox.Show("Вы точно хотите удалить категорию " + category.name +" ?", "Удаление",
                                                    MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SQLiter.deleteCategory(category.name);
                    MessageBox.Show("Категория успешно удалена");
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так");
                }
                LoadCategoriesList();
            }
        }

        
    private void toMainMenu_Click(object sender, EventArgs e)
        {
            OutputData.FromAnotherForm = true;
            Navigation.toMainForm(new MainForm(), ActiveForm);
        }

        private void displayStatForAnotherMonth_button_Click(object sender, EventArgs e)
        {
            String month = Interaction.InputBox("Необходимо ввести 2 цифры", "Введите месяц", SQLiter.takeMonthFromCurrentDate());
            OutputData.outputStat(MonthlyStat_DGV, month, "m", true);
            CurrentMonth_label.Text = "Отображается статистика за " + month.Replace("0", "") + " месяц!";
        }

        private void displayStatForAnotherYear_button_Click(object sender, EventArgs e)
        {
            String year = Interaction.InputBox("Необходимо ввести 4 цифры", "Введите год", SQLiter.takeYearFromCurrentDate());
            OutputData.outputStat(YearlyStat_DGV, year, "Y", true);
            CurrentYear_label.Text = "Отображается статистика за " + year + " год!";
        }

        private void WriteToExcel_button_Click(object sender, EventArgs e)
        {
            OutputData.outputDataToExcel(MonthlyStat_DGV);
        }

        private void WriteToWord_button_Click(object sender, EventArgs e)
        {
            OutputData.outputDataToWord(MonthlyStat_DGV);
        }

        private void WriteYearlyStatToWord_button_Click(object sender, EventArgs e)
        {
            OutputData.outputDataToWord(YearlyStat_DGV);
        }

        private void button1WriteYearlyStatToExcel_button_Click(object sender, EventArgs e)
        {
            OutputData.outputDataToExcel(YearlyStat_DGV);
        }

        private void WriteAllTimeStatToExcel_button_Click(object sender, EventArgs e)
        {
            OutputData.outputDataToExcel(AllTimeStat_DGV);
        }

        private void WriteAllTimeStatToWord_button_Click(object sender, EventArgs e)
        {
            OutputData.outputDataToWord(AllTimeStat_DGV);
        }

        private void customizeLabels()
        {
            switch (OutputData.isThemeDark)
            {
                case true:
                    label1.BackColor = Color.FromArgb(50, 50, 50);
                    label1.ForeColor = Color.FromArgb(242, 242, 242);
                    label2.BackColor = Color.FromArgb(50, 50, 50);
                    label2.ForeColor = Color.FromArgb(242, 242, 242);
                    label3.BackColor = Color.FromArgb(50, 50, 50);
                    label3.ForeColor = Color.FromArgb(242, 242, 242);
                    label4.BackColor = Color.FromArgb(50, 50, 50);
                    label4.ForeColor = Color.FromArgb(242, 242, 242);
                    label5.BackColor = Color.FromArgb(50, 50, 50);
                    label5.ForeColor = Color.FromArgb(242, 242, 242);
                    categoryLabel.BackColor = Color.FromArgb(50, 50, 50);
                    categoryLabel.ForeColor = Color.FromArgb(242, 242, 242);
                    maxSumLabel.BackColor = Color.FromArgb(50, 50, 50);
                    maxSumLabel.ForeColor = Color.FromArgb(242, 242, 242);
                    lostSumLabel.BackColor = Color.FromArgb(50, 50, 50);
                    lostSumLabel.ForeColor = Color.FromArgb(242, 242, 242);
                    remainingSumLabel.BackColor = Color.FromArgb(50, 50, 50);
                    remainingSumLabel.ForeColor = Color.FromArgb(242, 242, 242);
                    CurrentMonth_label.BackColor = Color.FromArgb(50, 50, 50);
                    CurrentMonth_label.ForeColor = Color.FromArgb(242, 242, 242);
                    CurrentYear_label.BackColor = Color.FromArgb(50, 50, 50);
                    CurrentYear_label.ForeColor = Color.FromArgb(242, 242, 242);
                    break;
                case false:
                    label2.BackColor = Color.FromArgb(242, 242, 242);
                    label2.ForeColor = Color.FromArgb(50, 50, 50);
                    label3.BackColor = Color.FromArgb(242, 242, 242);
                    label3.ForeColor = Color.FromArgb(50, 50, 50);
                    label2.BackColor = Color.FromArgb(242, 242, 242);
                    label2.ForeColor = Color.FromArgb(50, 50, 50);
                    break;
            }
        }
        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
