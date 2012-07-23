using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    abstract class Character
    {
        protected WeaponBehavior weapon;

        public void setWeapon(WeaponBehavior wp)
        {
            this.weapon = wp;
        }

        public void fight()
        {
            weapon.useWeapon();
        }

        abstract public void whoAreYou();
    }
}
