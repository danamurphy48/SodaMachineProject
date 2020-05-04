using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sodaMachine = new SodaMachine();
            GrapeSoda grapeSoda = new GrapeSoda();
            LemonSoda lemonSoda = new LemonSoda();
            OrangeSoda orangeSoda = new OrangeSoda();
            sodaMachine.DisplaySodaOptions(grapeSoda, lemonSoda, orangeSoda);
            sodaMachine.MakeTransaction(lemonSoda);
        }
    }
}
