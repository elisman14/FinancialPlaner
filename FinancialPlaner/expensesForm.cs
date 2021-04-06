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
            string name, cost;
            name = Interaction.InputBox("Введите названия новой покупки:");
            cost = Interaction.InputBox("Введите сумму новой покупки:");
            SQLiter.addPaynment(name, categoryLabel.Text, cost);
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
    }
}
