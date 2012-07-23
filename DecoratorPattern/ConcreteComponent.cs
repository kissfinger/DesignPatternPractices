using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteComponent:Component
    {
        override public void Operation()
        {
            Console.WriteLine("Let's make our world ");
        }
    }
}
