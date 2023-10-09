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
        public double Price { get; set; }
        public int Id {  get; set; }
        public string visa { get; set; }

        public static int nextId = 1;

        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Id = nextId++;
        }

        public Item(string name)
        {
            this.Name = name;
            this.Id = nextId++;

        }

        public string getName()
        {
            return this.Name;
        }

        public double getPrice()
        {
            return this.Price;
        }
    }
}
