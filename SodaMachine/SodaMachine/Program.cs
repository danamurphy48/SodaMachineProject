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
            sodaMachine.CheckInventory(lemonSoda);
            sodaMachine.MakeTransaction(lemonSoda, .05);
            //sodaMachine.ChooseSodaToBuy(grapeSoda, lemonSoda, orangeSoda);//seems unnecessary
            sodaMachine.DispenseSoda(lemonSoda);
            //sodaMachine.GiveChange(lemonSoda, .60);
            //sodaMachine.GiveChange(lemonSoda, .05);
            sodaMachine.CheckInventory(lemonSoda);
        }
    }
}
