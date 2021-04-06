using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanerDB
{
    /* Модель для описания покупок */
    public class ExpenseModel
    {
        public int id { get; set; }
        public string user { get; set; }
        public double cost { get; set; }
        // public DateTime date { get; set; }
        public string category { get; set; }
        public string name { get; set; }
    }
}
