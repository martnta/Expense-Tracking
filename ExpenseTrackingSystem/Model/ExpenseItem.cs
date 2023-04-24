using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingSystem.Model
{
   public class ExpenseItem
    {
       public int Id { get; set; }
       public float cost { get; set; }
       public string description { get; set; }
        public string ItemName { get; set; }
        public string category { get; set; }
       public string paymentType { get; set; }
       public string month { get; set; }

    }
}
