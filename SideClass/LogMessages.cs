using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideClass
{
    public class LogMessages
    {
        public static void successfulLogin()
        {
            MessageBox.Show("Вы успешно вошли",
                "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void wrongData()
        {
            MessageBox.Show("Вы ввели неправильный логин или пароль",
                "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void noAnswer()
        {
            MessageBox.Show("Вы не ответили на вопрос ",
                    "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Correct()
        {
            MessageBox.Show("Вы правильно ответили на вопрос ",
                    "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void inCorrect()
        {
            MessageBox.Show("Вы неправильно ответили на вопрос ",
                    "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowMyMessage(string msg)
        {
            MessageBox.Show(msg, "Заголовок окна", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public static void Success()
        {
            MessageBox.Show("Операця успешно выполнена",
                    "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Error()
        {
            MessageBox.Show("Произошла неизвестная ошибка",
                    "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
