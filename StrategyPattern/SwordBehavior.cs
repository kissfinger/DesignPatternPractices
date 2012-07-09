using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class SwordBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I am using a Sharp Sword!");
        }
    }
}
