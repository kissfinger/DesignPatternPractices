using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecorator1:Decorator
    {
        public ConcreteDecorator1(Component comp):base(comp)
        {
        }

        override public void Operation()
        {
            base.Operation();
            Console.WriteLine("Peaceful");
        }
    }
}
