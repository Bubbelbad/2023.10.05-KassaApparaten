using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class Item
    {
        protected string Name { get; set; }
        public int Price { get; set; }



        public Item(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getPrice()
        {
            return this.Price;
        }
    }
}
