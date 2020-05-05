using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Register
    {
        //thought to set constructor = starting amounts of coins and then use method to handle transactions
        //have a list of coins? or just leave as is

        //member variables (HAS A)
        public List<Quarter> Quarters;
        public List<Dime> Dimes;
        public List<Nickel> Nickels;
        public List<Penny> Pennies;
        public double money;
        //constructor (SPAWNER)
        public Register()
        {
            Quarters = new List<Quarter>();
            Dimes = new List<Dime>();
            Nickels = new List<Nickel>();
            Pennies = new List<Penny>();
            LoadCashToMachine();
        }

        //member methods (CAN DO)
        public void LoadCashToMachine()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                Quarters.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                Dimes.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                Nickels.Add(nickel);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                Pennies.Add(penny);
            }
        }
    }
}
