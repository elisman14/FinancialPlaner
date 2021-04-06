using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace FinancialPlanerDB
{
    public class SQLiter
    {
       
        /* получение всех категорий для отображения в списке категорий */
        public static List<CategoryModel> getCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("select * from categories", new DynamicParameters());
                return output.ToList();
            }
        }

        /* получение всех покупок из данной категории для отображени в списке */
        public static List<ExpenseModel> getCategoryExpenses(string category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExpenseModel>("select * from expenses where category = '" + category + "'");
                return output.ToList();
            }
        }

        /* получение максимальной стоимости, потраченной стоимости и оставшихся денег 
         * m -> maxSum
         * l -> lostSum
         * r -> remainingSum
         */
        public static double[] getMLRSum(string category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var mlr = new double[3];
                mlr[0] = cnn.Query<double>("select SUM(maxCost) from categories where name = '" + category + "'").ToList()[0];
                mlr[1] = cnn.Query<double>("select SUM(currentCost) from categories where name = '" + category + "'").ToList()[0];
                mlr[2] = mlr[0] - mlr[1];
                return mlr;
            }
        }

        /* Создание новой категории */
        public static void createNewCategory(string name, string maxCost)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into categories (name, maxCost) values (@p1, @p2)", new { p1 = name, p2 = maxCost });
            }
        }

        /* Удаление текущей категории */
        public static void deleteCategory(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from categories where name=" +  "'" + name + "'");
            }
        }

        /* Создание новой покупки */
        public static void addPaynment(string name, string category, string cost)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into expenses (name, category, cost) values (@p1, @p2, @p3)", new { p1 = name, p2 = category, p3 = cost });
                cnn.Execute("update categories set currentCost = currentCost + " + cost + " where name='" + category+"'");
            }
        }



        // ********** Раздел работы с пользователем **********


        /* получение списка всех пользоватлей для отображения в списке на главной форме */
        public static List<PersonModel> getUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from users", new DynamicParameters());
                return output.ToList();
            }
        }

        /* Сохранение нового пользователя в базе данных */
        public static void saveUser(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into users (name, username, password, question, questionAnswer) values (@name, @username, @password, @question, @questionAnswer)", person);
            }
        }

        /* Получение пароля пользователя для его сравнения с введенным */
        public static string getUserPassword(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select password from users where username = '"+username+"'");
                Console.WriteLine(output.ToList()[0].password);
                return output.ToList()[0].password;
            }
        }

        /* Удаление пользователя из бд */
        public static void deleteUser(PersonModel username)
        {
            PersonModel p = new PersonModel();
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from users where username=(@username)", username);
            }
        }

        /* получение сохранённого вопроса пользователя для
         * восстановления пароля
         */
        public static string getQuestion(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select question from users where username = '" + username + "'");
                Console.WriteLine(output.ToList()[0].question);
                return output.ToList()[0].question;
            }
        }

        /* Првоерка корректности введенного ответа на вопрос */
        public static bool isAnswerCorrect(string answer, string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select questionAnswer from users where username = '" + username + "'");
                return output.ToList()[0].questionAnswer == answer.ToLower();
            }
        }

        /* Подключение к бд */
        private static string LoadConnectionString(string id = "Default")
        {
            return @"Data Source=.\FP_db.db";
        }
    }
}
