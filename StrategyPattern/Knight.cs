using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Knight:Character
    {
        public Knight()
        {
            this.weapon = new SpearBehavior();
        }

        public override void whoAreYou()
        {
            Console.WriteLine("I am a Knight!");
        }
    }
}
