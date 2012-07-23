using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Client
    {
        public static void Main()
        {
            ConcreteComponent comp = new ConcreteComponent();
            Decorator deco = new ConcreteDecorator1(new ConcreteDecorator2(comp));
            deco.Operation();
        }
    }
}


