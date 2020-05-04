using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Inventory
    {
        //machine starts with coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
        //member variables
        public List<GrapeSoda> GrapeSodas;
        public List<LemonSoda> LemonSodas;
        public List<OrangeSoda> OrangeSodas;

        //constructor
        public Inventory()
        {
            GrapeSodas = new List<GrapeSoda>();
            LemonSodas = new List<LemonSoda>();
            OrangeSodas = new List<OrangeSoda>();
            LoadSodaMachine();
        }

        //member methods
        public void LoadSodaMachine()
        {
            for (int i = 0; i < 15; i++)
            {
                GrapeSoda grapeSoda = new GrapeSoda();
                GrapeSodas.Add(grapeSoda);
            }
            for (int i = 0; i < 20; i++)
            {
                LemonSoda lemonSoda = new LemonSoda();
                LemonSodas.Add(lemonSoda);
            }
            for (int i = 0; i < 25; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                OrangeSodas.Add(orangeSoda);
            }
        }
    }
}
