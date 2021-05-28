using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using FinancialPlanerDB;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

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

        /* Вывод статистики в DataGridView */
        public static void outputStat(DataGridView grid, String date, String param, Boolean flag)
        {
            grid.Rows.Clear();
            List<ExpenseModel> list;
            if (flag)
                list = SQLiter.getStat(date, param);
            else
                list = SQLiter.getAllTimeStat();

            int length = list.Count();

            try
            {
                grid.RowCount = length;

                for (int i = 0; i < length; ++i)
                {
                    grid.Rows[i].Cells[0].Value = list[i].user;
                    grid.Rows[i].Cells[1].Value = list[i].category;
                    grid.Rows[i].Cells[2].Value = list[i].name;
                    grid.Rows[i].Cells[3].Value = list[i].date;
                    grid.Rows[i].Cells[4].Value = list[i].cost;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                grid.RowCount = 1;
            }
        }

        public static void outputDataToExcel(DataGridView dgv) //Метод для записи массивов в таблицу excel
        {
            Excel.Application excelApp = new Excel.Application(); //Созданеие экземпляра таблицы
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Name = "Статистика"; //Присвоение имени таблице
            workSheet.Cells[1, 1] = "Пользователь"; // Запись в клетку
            workSheet.Cells[1, 2] = "Категория"; //Запись в клетку
            workSheet.Cells[1, 3] = "Наименование";
            workSheet.Cells[1, 4] = "Дата";
            workSheet.Cells[1, 5] = "Стоимость";

            for(int i = 0; i < dgv.ColumnCount;i++)
            {
                for(int j = 0; j < dgv.RowCount;j++)
                {
                    workSheet.Cells[j + 2, i + 1] = dgv[i, j].Value;
                }
            }

            table_formating(workSheet, dgv.RowCount, dgv.ColumnCount);

            excelApp.Visible = true; //Запуск Excel
            excelApp.UserControl = true;
        }

        public static void table_formating(Excel.Worksheet workSheet, int rowsCount, int columnCount)//Метод для форматирования таблицы
        {
            Excel.Range range1 = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[rowsCount + 1, columnCount]]; //Выбор диапазона
            range1.Cells.Font.Name = "Times New Roman"; //Присвоение шрифта
            range1.Cells.Font.Size = 18;

            //workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[1, array_length]].Merge(); //Объединение клеток 
            //workSheet.Range[workSheet.Cells[3, 1], workSheet.Cells[3, array_length]].Merge();//Объединение клеток 

            workSheet.Columns.AutoFit(); // Автоподбор ширины и высоты клеток

            range1 = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[rowsCount + 1, columnCount]]; //Выбор диапазона


            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;

            workSheet.Range[("A8")].Select(); //Выбор клетки
        }


        public static void outputDataToWord(DataGridView dgv)
        {
            //Создаем объект Word
            Word.Application wordapp = new Word.Application();
            //Делаем его видимым
            wordapp.Visible = true;
            //Создаем документ
            Word.Document worddocument = wordapp.Documents.Add(Type.Missing, false, Word.WdNewDocumentType.wdNewBlankDocument, true);
            
            //Таблицу вставляем в начало документа
            Word.Range wordrange = worddocument.Range(0, 0);
            wordrange.Font.Name = "Times New Roman";
            //Добавляем таблицу и получаем объект wordtable 
            Word.Table wordtable = worddocument.Tables.Add(wordrange, dgv.RowCount + 1, dgv.ColumnCount, Word.WdDefaultTableBehavior.wdWord9TableBehavior, Word.WdAutoFitBehavior.wdAutoFitWindow);

            wordtable.ApplyStyleHeadingRows = true;

            Word.Range wordcellrange = worddocument.Tables[1].Cell(1, 1).Range;
            wordcellrange.Text = "Пользователь";
            wordcellrange = worddocument.Tables[1].Cell(1, 2).Range;
            wordcellrange.Text = "Категория";
            wordcellrange = worddocument.Tables[1].Cell(1, 3).Range;
            wordcellrange.Text = "Наименование";
            wordcellrange = worddocument.Tables[1].Cell(1, 4).Range;
            wordcellrange.Text = "Дата";
            wordcellrange = worddocument.Tables[1].Cell(1, 5).Range;
            wordcellrange.Text = "Стоимость";

            wordcellrange = worddocument.Range(wordtable.Cell(1, 1).Range.Start, wordtable.Cell(1, 5).Range.End);
            wordcellrange.Select();
            wordcellrange.Bold = 1;
            wordcellrange.Font.Size = 16;
            wordcellrange.Shading.ForegroundPatternColor = Word.WdColor.wdColorYellow;
            wordcellrange.Shading.BackgroundPatternColorIndex = Word.WdColorIndex.wdBlue;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    wordcellrange = worddocument.Tables[1].Cell(i + 2, j + 1).Range;

                    if (dgv[j, i].Value != null)
                        wordcellrange.Text = dgv[j, i].Value.ToString();
                    else
                        wordcellrange.Text = "";

                    wordcellrange.Select();
                    wordcellrange.Font.Size = 13;
                    wordcellrange.Font.Name = "Times New Roman";
                }
            }

        }
    }
}
