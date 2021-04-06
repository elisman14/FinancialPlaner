using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanerDB
{
    public class PersonModel
    {
        /* Модель для описания пользователей */
        public int Id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string group { get; set; }
        public string question { get; set; }
        public string questionAnswer { get; set; }
        // public int privilegeLevel { get; set; }
    }
}
