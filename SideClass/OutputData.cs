using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using FinancialPlanerDB;

namespace SideClass
{
    public class OutputData
    {
        /* Вывод данных о пукупках в  DataGridView*/
        public static void outputExpensesToDgv(DataGridView grid, string category)
        {
            grid.Rows.Clear();
            List <ExpenseModel> list = SQLiter.getCategoryExpenses(category);
            int length = list.Count();
            // grid.ColumnCount = 3;
            // Задание количества столбцов и колонок
            // Задание начальной длины и высоты таблицы
            try
            {   
                grid.RowCount = length;

                for (int i = 0; i < length; ++i)
                {
                    grid.Rows[i].Cells[0].Value = list[i].user;
                    grid.Rows[i].Cells[1].Value = list[i].name;
                    grid.Rows[i].Cells[2].Value = list[i].cost;
                }   
            } catch (ArgumentOutOfRangeException)
            {
                grid.RowCount = 1;
            }
            /*
            int width = 5;
            int height = 46;
            for (int i = 0; i < grid.RowCount; ++i)
            height += grid.Rows[0].Height * (grid.RowCount) + 1;

            if (height > 1500) grid.Height = 1500;
            else grid.Height = height;

            grid.Height = height;

            width += grid.Columns[0].Width * 2;
            grid.Width = width;
            */
        }
    }
}
