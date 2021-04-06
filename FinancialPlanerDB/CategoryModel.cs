using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanerDB
{
    /* Модель для описания категорий */
    public class CategoryModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int maxCost { get; set; }
        public int currentCost { get; set; }
        public double minPercent { get; set; }
        // public DateTime date { get; set; }
    }
}
