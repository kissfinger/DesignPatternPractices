using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Queen:Character
    {
        public Queen()
        {
            this.weapon = new KnifeBehavior();
        }

        public override void whoAreYou()
        {
            Console.WriteLine("I am The Queen!");
        }
    }
}
