using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideClass
{
    public class Navigation
    {
        /* переход на указанную форму */
        public static void toMainForm(Form mainForm, Form thisForm)
        {
            mainForm.Show();
            thisForm.Hide();
        }
    }
}
