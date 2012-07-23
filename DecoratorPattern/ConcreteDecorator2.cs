using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecorator2:Decorator
    {
        public ConcreteDecorator2 (Component comp):base (comp)
        {
          
        }

        override public void Operation()
        {
            base.Operation();
            Console.WriteLine("Beautiful");
        }
    }
}
