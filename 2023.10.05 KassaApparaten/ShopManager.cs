using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class ShopManager
    {

        //Den här klassen innehåller funtkioner som tar hand om interaktionen mellan klasserna ItemManager och User.
        //Funtioner som meny, lägga till i kundkorgen, betala osv..
        User user = new User(300);
        ItemManager itemManager = new ItemManager();



        //I samband med kontruktorn lägger jag till standardvarorna i inventariet och visar detta för kund när programmet startar.
        public ShopManager()
        {
            AddInventory();
            AddToShoppingCart();
            Menu();
        }



        //Meny för kunden att navigera mellan de olika valen: 
        public void Menu()
        {
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Vad vill du göra?\n\n" +
                                  "Fortsätt handla            [1]\n" +
                                  "Visa kundvagn              [2]\n" +
                                  "Gå vidare till betalning   [3]\n" +
                                  "Avsluta (utan betalning)   [4]");
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (answer)
                    {
                        case 1:
                            AddToShoppingCart();
                            break;
                        case 2:
                            DisPlayShoppingCart();
                            break;
                        case 3:
                            Payment();
                            menu = false;
                            return;
                        case 4:
                            System.Environment.Exit(0);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Vänligen skriv in en siffra mellan 1 - 3.");
                }
            }
        }





        //Hur man betalar, val mellan kontakt och kredit. 
        //Avslutar efter betalning eller efter att en har för lite pengar.
        public void Payment()
        {
            DisplayCost();

            Console.WriteLine("Hur vill du betala?\n" +
                              "\nBetala med kontanter         [1]" +
                              "\nBetala med kreditkort        [2]");

            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    if (DisplayCost() < user.Budget)
                    {
                        
                        Console.Clear();
                        double sum = DisplayCost();
                        Console.WriteLine($"Du har {Math.Round(user.Budget - sum, 2)} SEK kvar.\n");
                        Console.WriteLine("\n*** Välkommen åter!*** \n\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Du har för lite pengar. \n*** (FELMEDDELANDE) ***\n\n");
                    }
                    break;

                case "2":
                    if (DisplayCost() < user.Creditcard)
                    {
                        Console.Clear();
                        double sum = DisplayCost();
                        Console.WriteLine($"Du har {Math.Round(user.Creditcard - sum, 2)} SEK kvar.\n");
                        Console.WriteLine(" \n*** Välkommen åter!*** \n\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Du har för lite pengar. \n*** (FELMEDDELANDE) ***\n\n");
                    }
                    break;

                default:
                    Console.WriteLine("Vänligen knappa in 1 eller 2");   
                    break;
            }
        }




        
        //funktioner hämtade från ItemManager: 
        public void AddInventory()
        {
            itemManager.RunItems();
        }

        public void AddToShoppingCart()
        {
            itemManager.AddToShoppingCart();
        }

        public double DisPlayShoppingCart()
        {
            double sum = itemManager.DisplayShopingCart();
            return sum;
        }

        public double DisplayCost()
        {
            double sum = itemManager.DisplayCost();
            return sum;
        }
    }
}
