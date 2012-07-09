using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class King:Character
    {
        public King()
        {
            this.weapon = new SwordBehavior();
        }

        override public void whoAreYou()
        {
            Console.WriteLine("I am The King!");
        }
    }
}
