using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Archer:Character
    {
        public Archer()
        {
            this.weapon = new BowAndArrowBehavior();
        }

        public override void whoAreYou()
        {
            Console.WriteLine("I am a Archer!");
        }
    }
}
