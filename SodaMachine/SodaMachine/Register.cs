using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Register
    {//should this be a parent class? soda machine's internal money count
     //machine starts with coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
     //member variables (HAS A)
     //have a list of coins? or just leave as is
        public List<Quarter> Quarters;
        public List<Dime> Dimes;
        public List<Nickel> Nickels;
        public List<Penny> Pennies;
        //constructor (SPAWNER)
        public Register()
        {
            Quarters = new List<Quarter>();
            Dimes = new List<Dime>();
            Nickels = new List<Nickel>();
            Pennies = new List<Penny>();
        }

        //member methods (CAN DO)

    }
}
