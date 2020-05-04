using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {//should have money to buy a soda and be able to choose a soda to buy
        //member variables (HAS A)

        public List<Quarter> Quarters;
        public List<Dime> Dimes;
        public List<Nickel> Nickels;
        public List<Penny> Pennies;

        //constructor (SPAWNER)
        public Customer()
        {

            Quarters = new List<Quarter>();
            Dimes = new List<Dime>();
            Nickels = new List<Nickel>();
            Pennies = new List<Penny>();
        }
        //member methods (CAN DO)
        public void BuySoda()
        {
            //if (wallet >= costOfSoda) //then dispense soda and remove cost from wallet
        }
    }
}
