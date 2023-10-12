using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class User 
    {
        protected double Budget {  get; private set; }
        protected double Creditcard { get; private set; }

        public User(double budget, double creditcard = 5000)
        {
            this.Budget = budget;
            this.Creditcard = creditcard;
        }

        public double getBudget() 
        { return this.Budget; }

        public double getCreditcard()
        { return this.Creditcard;  }

       
    }
}
