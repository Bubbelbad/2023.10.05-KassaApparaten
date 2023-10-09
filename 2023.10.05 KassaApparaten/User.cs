using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class User 
    {
        public double Budget {  get; set; }
        public double Creditcard { get; set; }

        public User(double budget, double creditcard = 5000)
        {
            this.Budget = budget;
            this.Creditcard = creditcard;
        }
       
    }
}
