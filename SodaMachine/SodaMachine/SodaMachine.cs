using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //member variables //has a
        Inventory inventory;
        Register register;
        List<Coin> Coin;
        //public double coins;


        //machine starts with coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
        //constructor
        public SodaMachine() //spawner
        {
            inventory = new Inventory();
            register = new Register();
            Coin = new List<Coin>();
        }

        //member methods //can do
        public void DisplaySodaOptions(GrapeSoda grapeSoda, LemonSoda lemonSoda, OrangeSoda orangeSoda)
        {
            Console.WriteLine($"Welcome to the coolest Soda Machine!");
            Console.WriteLine($"We have three sodas:");
            Console.WriteLine($"{grapeSoda.sodaType} costs {grapeSoda.priceOfCan} per can.");
            Console.WriteLine($"{lemonSoda.sodaType} costs {lemonSoda.priceOfCan} per can.");
            Console.WriteLine($"{ orangeSoda.sodaType} costs { orangeSoda.priceOfCan} per can.");
        }

        //necessary? no
        public string ChooseSodaToBuy(GrapeSoda grapeSoda, LemonSoda lemonSoda, OrangeSoda orangeSoda)
        {
            Console.WriteLine($"Please select {grapeSoda.sodaType}, {lemonSoda.sodaType}, or {orangeSoda.sodaType}:");
            string choice = Console.ReadLine();//data validation?
            return choice;
        }
        public bool CheckInventory(Soda soda)//could do Soda soda and just pass which soda you want to know inventory
        {
            if (soda.sodaType == "Grape soda")
            {
                Console.WriteLine($"Current stock of {soda.sodaType}: {inventory.GrapeSodas.Count}");
            }
            else if (soda.sodaType == "Lemon soda")
            {
                Console.WriteLine($"Current stock of {soda.sodaType}: {inventory.LemonSodas.Count}");
            }
            else if (soda.sodaType == "Orange soda")
            {
                Console.WriteLine($"Current stock of {soda.sodaType}: {inventory.OrangeSodas.Count}");
            }

            return true;
        }
        //return change method

        public void MakeTransaction(Soda soda, double coins)//run soda object & double money(later listofcoins) through
        {
            if (soda.priceOfCan > coins)
            {
                Console.WriteLine($"You don't have enough money to purchase {soda.sodaType}.");
                //here's your change (call method that returns change to user)
            }
            else if (soda.priceOfCan == coins)
            {
                //complete transaction, add coins to register, dispense soda
                register.money += coins;

                //call method that adds coin objects to their respective lists
                //foreach (Coin coin in Coin) //List<Coin> coins
                //{
                //    if (coin.value == 0.25)
                //    {
                //        register.money += coin.value;
                //        register.Quarters.Add(coin);
                //    }
                //}
                //register.money.Add(coins);

                DispenseSoda(soda);
            }
            else if (soda.priceOfCan < coins)
            {
                //accept payment
                double changeDue = coins - soda.priceOfCan;
                register.money += soda.priceOfCan;
                //coins += changeDue;//return to customer

                //return change as a list of coins from internal limited register
                //DispenseSoda();
            }
            //else if ((soda.priceOfCan < coins) > register.money)
            //{
            //    //don't complete transaction
            //    //give money back
            //}
            //else if ((soda.priceOfCan <= coins) && (inventory.GrapeSodas.Count < quantitySoda))//do I need to account multiple cans?
            //{
            //    //don't complete transaction
            //    //give money back
            //}
        }
        public void DispenseSoda(Soda soda)
        {
            if (soda.sodaType == "Grape soda")
            {
                inventory.GrapeSodas.RemoveAt(0);
            }
            else if (soda.sodaType == "Lemon soda")
            {
                inventory.LemonSodas.RemoveAt(0);
            }
            else if (soda.sodaType == "Orange soda")
            {
                inventory.OrangeSodas.RemoveAt(0);
            }
            
            //subtract for limited inventory

        }
    }
}
//public List<double> coins;
//public List<string> sodaCans; //make a list for each can of soda?
//public double costGrapeSoda;
//public double costOrangeSoda;
//public double costLemonSoda;
//public List<Quarter> Quarters;
//public List<Dime> Dimes;
//public List<Nickel> Nickels;
//public List<Penny> Pennies;
//double costGrapeSoda = .60;
//double costOrangeSoda = .35;
//double costLemonSoda = .06;
//fix this
//Console.WriteLine($"Please press 1. for {grapeSoda.sodaType} 2. for {lemonSoda.sodaType} or 3. for {orangeSoda.sodaType}");
//for (int i = 0; i<soda.sodaType.Count; i++)
//{

//}
//else if (soda.sodaType == "Orange soda")
//{
//    for (int i = 0; i<inventory.OrangeSodas.Count; i++)
//    {
//        Console.WriteLine($"There are {i} {soda.sodaType}");
//    }
//}
//from dispense method
//int input;
//input = int.Parse(soda.sodaType);
//for (int i = 0; i < input; i++)
//{
//    inventory.LemonSodas.RemoveAt(0);
//}