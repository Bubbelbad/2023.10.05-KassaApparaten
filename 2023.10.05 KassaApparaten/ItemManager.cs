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
        Item currentItem = null;


        //För att lägga till standard-varor:
        public void RunItems()
        {
            items.Add(new Item("Broccoli", 15));
            items.Add(new Item("Kaffe", 65));
            items.Add(new Item("Ris", 24));
            items.Add(new Item("Snus", 36));
            items.Add(new Item("Sprit", 200));
        }

        //För att skriva ut varan:
        public void PrintList()
        {
            Console.WriteLine("Tillgängliga varor: \n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"-{items[i].getName()}, {items[i].getPrice()} SEK");
            }
       
        }

        public void DisplayShopingCart()
        {
            int sum = 0;
            Console.WriteLine("Din kundkorg: \n");
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                Console.WriteLine($"-{shoppingCart[i].getName()}, {shoppingCart[i].getPrice()} SEK");
                sum += shoppingCart[i].getPrice();
            }
            Console.WriteLine($"\nTotalt kostnad: {sum} SEK\n");
        }

        //Denna behöver en failsafe ifall varan inte finns, eller om en stavat fel.
        public void AddToShoppingCart()
        {

            PrintList();
            Console.Write("\nVilken vara vill du lägga till i kundvagnen? \n");
            string selection = Console.ReadLine();
            foreach (Item item in items)
            {
                if (selection == item.getName())
                {
                    shoppingCart.Add(item);
                    Console.Clear();
                    Console.WriteLine($"*** {selection} har lagts till i Kundvagnen ***\n");
                }
            }
        }

        //Kolla upp insertion sort - En algoritm som vi skulle kunna programmera för att sortera

        public void RegisterNewProduct()
        {
            Console.WriteLine("Skriv produktnamnet: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Skriv in varans pris: ");
            int priceInput = int.Parse(Console.ReadLine());

            Item newItem = new Item(nameInput, priceInput);

            items.Add(newItem);
        }
      
    }
}
