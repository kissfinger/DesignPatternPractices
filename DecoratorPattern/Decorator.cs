using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
     abstract class Decorator:Component
     {
        protected Component component;

        
        public Decorator(Component comp)
        {
            this.component = comp;
        }

        override public void Operation()
        {
            component.Operation();
        }
    }
}
