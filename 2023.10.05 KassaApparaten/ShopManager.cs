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
        //Funtioner som meny(), betala() osv..

        User user = new User(300);
        ItemManager itemManager = new ItemManager();



        public void Menu()
        {
            AddInventory();
            AddShoppingCart();
            bool menu = true;
            while (true)
            {
                Console.WriteLine("Vad vill du göra?\n\n" +
                              "Fortsätt handla            [1]\n" +
                              "Visa kundvagn              [2]\n" +
                              "Gå vidare till betalning   [3]\n" +
                              "Avsluta (utan betalning)   [4]");
                string answer = Console.ReadLine();
                Console.Clear();
                switch (answer)
                {
                    case "1":
                        AddShoppingCart();
                        break;
                    case "2":
                        RunDisPlayShoppingCart();
                        break;
                    case "3":
                        Payment();
                        menu = false;
                        break;
                    case "4":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Vänligen välj en siffra mellan 1-4\n");
                        break;
                }
            }
        }



        //Hur man betalar och vad som händer. 
        public void Payment()
        {
            RunDisplayCost();

            Console.WriteLine("Hur vill du betala?\n" +
                              "\nBetala med kontanter         [1]" +
                              "\nBetala med kreditkort        [2]");

            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    if (RunDisplayCost() < user.Budget)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har råd att betala!\n");
                        RunDisPlayShoppingCart();
                        CheckOutDiscount();

                        Console.WriteLine("\n*** Välkommen åter!*** \n\n");
                    }
                    else
                    {
                        Console.WriteLine("Du har inte råd att handla. \n(FELMEDDELANDE)\n\n");
                    }
                    break;

                case "2":
                    if (RunDisplayCost() < user.Creditcard)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har råd att betala! " +
                                          " \n*** Välkommen åter!*** \n\n");
                    }
                    else
                    {
                        Console.WriteLine("Du har inte råd att handla. \n(FELMEDDELANDE)\n\n");
                    }
                    break;

                default:
                    Console.WriteLine("Vänligen knappa in 1 eller 2");
                    break;
            }
        }



        //Checkout
        public void CheckOutDiscount()
        {

            Console.WriteLine("Rabattavdrag 20%\n");
            int sum = RunDisplayCost();
            double discount = 0.2;
        }



        //funktioner från ItemManager: 
        public void AddInventory()
        {
            itemManager.RunItems();
        }

        public void AddShoppingCart()
        {
            itemManager.AddToShoppingCart();
        }

        public void RunDisPlayShoppingCart()
        {
            itemManager.DisplayShopingCart();
        }

        public int RunDisplayCost()
        {
            int sum = itemManager.DisplayCost();
            return sum;
        }


        //Om jag vill lägga till nya saker så kallar ShopManager på RegisterProduct:
        //Denna funktion är bara till för anställda, men klassen finns ännu inte i programmet.
        public void NewProduct()
        {
            itemManager.RegisterNewProduct();
        }





        //Utanför funktioner kan vi bara deklarera variabler. 


        //Skapa runfunktionen här



    }
}
