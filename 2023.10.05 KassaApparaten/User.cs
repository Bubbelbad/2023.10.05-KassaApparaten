using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class User 
    {
        public int Budget {  get; set; }
        public int Creditcard { get; set; }

        public User(int budget, int creditcard = 5000)
        {
            this.Budget = budget;
        }
       
    }
}
