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
        //List<double> Coin;

        //machine starts with coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
        //constructor
        public SodaMachine() //spawner
        {
            inventory = new Inventory();
            register = new Register();
            //Coin = new List<double>();
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
        public string ChooseSodaToBuy(GrapeSoda grapeSoda, LemonSoda lemonSoda, OrangeSoda orangeSoda)
        {
            Console.WriteLine($"Please select {grapeSoda.sodaType}, {lemonSoda.sodaType}, or {orangeSoda.sodaType}:");
            string choice = Console.ReadLine();//data validation?
            return choice;
        }

        public void MakeTransaction(Soda soda, double coins)//run soda object & double money(later listofcoins) through
        {
            if (soda.priceOfCan > coins)
            {
                Console.WriteLine($"You don't have enough money to purchase {soda.sodaType).";
            }
            else if (soda.priceOfCan == coins)
            {
                //complete transaction, add coins to register, dispense soda
                soda.priceOfCan = coins;
                coins += register;
                register.Add(coins);
                soda.sodaType.grapeSoda -= inventory.GrapeSodas;
                DispenseSoda();
            }
            else if (soda.priceOfCan < coins)
            {
                //accept payment
                double moneyReturned = coins - soda.priceOfCan;
                coins - soda.priceOfCan = double moneyReturned;
                //return change as a list of coins from internal limited register
                //DispenseSoda();
            }
        }
        public void DispenseSoda()
        {
            
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