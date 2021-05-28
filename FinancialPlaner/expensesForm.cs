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
using Microsoft.VisualBasic;

using SideClass;

namespace FinancialPlaner
{
    public partial class expensesForm : Form
    {
        List<CategoryModel> categories = new List<CategoryModel>();

        public expensesForm()
        {
            InitializeComponent();
            LoadCategoriesList();
            OutputStat();
        }
        private void LoadCategoriesList()
        {
            categories = SQLiter.getCategories();
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

                    SideClass.OutputData.outputExpensesToDgv(dataGridView1, category.name);

                    var mlrArray = SQLiter.getMLRSum(category.name);
                    maxSumLabel.Text = mlrArray[0].ToString();
                    lostSumLabel.Text = mlrArray[1].ToString();
                    remainingSumLabel.Text = mlrArray[2].ToString();
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
            user = SQLiter.getActiveUser();
            SQLiter.addPaynment(name, categoryLabel.Text, cost, user);
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            var category = categoriesListBox.SelectedItem as CategoryModel;
            DialogResult result = MessageBox.Show("Вы точно хотите удалить категорию " + category.name +" ?", "Удаление",
                                                    MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SQLiter.deleteCategory(category.name);
                MessageBox.Show("Категория успешно удалена");
                LoadCategoriesList();
            }           
        }

        private void toMainMenu_Click(object sender, EventArgs e)
        {
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
    }
}
