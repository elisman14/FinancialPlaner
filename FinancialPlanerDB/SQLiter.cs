using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
                cnn.Execute("delete from expenses where category='" + name + "'");
            }
        }

        /* Создание новой покупки */
        public static void addPaynment(string name, string category, string cost, string user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into expenses (name, category, cost, user) values (@p1, @p2, @p3, @p4)", new { p1 = name, p2 = category, p3 = cost, p4 = user });
                cnn.Execute("update categories set currentCost = currentCost + " + cost + " where name='" + category+"'");
            }
        }

        /* Получение статистики за месяц/год */
        public static List <ExpenseModel> getStat(String date, String param)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExpenseModel>("select * from expenses where strftime('%" + param + "', date) = '" + date + "'");
                return output.ToList();
            }
        }
        
        /* Получение статистики за все время */
        public static List<ExpenseModel> getAllTimeStat()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExpenseModel>("select * from expenses");
                return output.ToList();
            }
        }

        /* Получение года из текущей даты */
        public static String takeYearFromCurrentDate()
        {
            String thisDay = DateTime.Today.ToString();
            thisDay = thisDay.Replace(" 0:00:00", "");
            thisDay = thisDay.Split('.')[2];
            //thisDay = thisDay.Replace("05", "04");

            return thisDay;
        }

        /* Получение месяца из текущей даты */
        public static String takeMonthFromCurrentDate()
        {
            String thisDay = DateTime.Today.ToString();
            thisDay = thisDay.Replace(" 0:00:00", "");
            thisDay = thisDay.Split('.')[1];
            //thisDay = thisDay.Replace("05", "04");

            return thisDay;
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
                person.password = ComputeHash(person.password, new SHA256CryptoServiceProvider());
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
        /* Алгоритм шифрования*/
        public static string ComputeHash(string password, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(password);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
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

        /* Изменение пароля пользователя */
        public static void changePassword(string username, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update users set password = '" + password + "' where username ='" + username + "'");
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

        /* Обнулить сессию всех пользователей */
        public static void clearAllSessions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update users set isActive = 0");
            }
        }

        /* Активиривоть сессию текущего пользователя */
        public static void activateCurrentUser(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update users set isActive = 1 where username ='" + username + "'");
            }
        }

        /* Получить пользователя с активной сесией */
        public static string getActiveUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select username from users where isActive = '1'");
                return output.ToList()[0].username;
            }
        }
    }
}
