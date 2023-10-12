using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class ItemManager
    {

        List<Item> items = new List<Item>();
        List<Item> shoppingCart = new List<Item>();



        //För att lägga till standard-varor i början av programmet:
        public void RunItems()
        {
            items.Add(new Item("Broccoli", 15));
            items.Add(new Item("Kaffe", 65));
            items.Add(new Item("Ris", 24));
            items.Add(new Item("Snus", 36));
            items.Add(new Item("Sprit", 200));
            items.Add(new Item("Rabattkupong 20%"));
        }





        //För att skriva ut tillgängliga varor i sortimentet:
        public void PrintList()
        {
            Console.WriteLine("Tillgängliga varor: \n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"-[{items[i].Id}] {items[i].getName()}, {items[i].getPrice()} SEK");
            }
        }




        //För att visa totala kostnaden av varorna i kundkorgen.
        public double DisplayCost()
        {
            bool rabatt = false;
            double sum = 0;
            double discount = 0.8;
            Console.WriteLine("Din kundkorg: \n");
            foreach (Item item in shoppingCart)
            {
                Console.WriteLine($"-{item.getName()}, {item.getPrice()} SEK");
                sum += item.getPrice();
                if (item.getName() == "Rabattkupong 20%")
                {
                    rabatt = true;
                }
                
            }
            if (rabatt)
            {
                sum = sum * discount;
            }
            Console.WriteLine($"\nTotal kostnad: {Math.Round(sum, 2)} SEK\n");
            return Math.Round(sum, 2);
        }





        //För att visa kundkorgen: 
        public double DisplayShopingCart()
        {
            double sum = 0;
            Console.WriteLine("Din kundkorg: \n");
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                Console.WriteLine($"-{shoppingCart[i].getName()}, {shoppingCart[i].getPrice()} SEK");
                sum += shoppingCart[i].getPrice();
            }
            Console.WriteLine($"\nTotalt kostnad: {Math.Round(sum, 2)} SEK\n");
            return Math.Round(sum, 2);
        }





        //För att lägga till varor i kundkorgen.
        public void AddToShoppingCart()
        {
            bool status = false;
            while (!status)
            {
                PrintList();
                Console.Write("\nVilken vara vill du lägga till i kundvagnen? \n");

                try
                {
                    int selection = Convert.ToInt32(Console.ReadLine());
                    foreach (Item item in items)
                    {
                        if (selection == item.Id)
                        {
                            shoppingCart.Add(item);
                            Console.Clear();
                            Console.WriteLine($"*** {selection} har lagts till i Kundvagnen ***\n");
                            status = true;
                        }
                    }
                }

                catch
                {
                    Console.WriteLine("Vänligen skriv in en siffra från menyn.");
                }
            }
        }
    }
}
