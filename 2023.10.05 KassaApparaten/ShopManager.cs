using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._05_KassaApparaten
{
    internal class ShopManager
    {

        //Den här klassen ska innehålla funtkioner som tar hand om interaktionen mellan Item manager och user.
        //Betala, registrera nya items...

        User user = new User(300);
        ItemManager itemManager = new ItemManager();

        public void Menu()
        {
            bool menu = true;
            while (true)
            {
                Console.WriteLine("Vad vill du göra?\n" +
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
                        Console.WriteLine("*Här kommer en betal-funktion ligga.*\n");
                        break;
                    case "4":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Vänligen välj en siffra mellan 1-3");
                        break;
                }
            }
        }

        public void AddInventory()
        {
            itemManager.RunItems();
        }

        //Funtkion för att välja vara:
        public void AddShoppingCart()
        {
            itemManager.AddToShoppingCart();
        }

        public void RunDisPlayShoppingCart()
        {
            itemManager.DisplayShopingCart();
        }


        //Om jag vill lägga till nya saker så kallar ShopManager på RegisterProduct:
        //Denna funktion är bara till för anställda, men klassen finns ännu inte i programmet.
        public void NewProduct()
        {
            itemManager.RegisterNewProduct();
        }

        //Checkout

        public void CheckOut()
        {

        }



        //Utanför funktioner kan vi bara deklarera variabler. 


        //Skapa runfunktionen här



    }
}
