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

        //machine starts with coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
        //constructor
        public SodaMachine() //spawner
        {
            inventory = new Inventory();
            register = new Register();

        }

        //member methods //can do
        public void MakeTransaction()
        {

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