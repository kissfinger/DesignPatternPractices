using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character aKing = new King();
            aKing.whoAreYou();
            aKing.fight();

            Character aQueen = new Queen();
            aQueen.whoAreYou();
            aQueen.fight();

            Character anArcher = new Archer();
            anArcher.whoAreYou();
            anArcher.fight();

            Character aKnight = new Knight();
            aKnight.whoAreYou();
            aKnight.fight();

            aKnight.setWeapon(new KnifeBehavior());
            aKnight.fight();
        }
    }
}
