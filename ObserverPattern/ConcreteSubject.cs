using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    //Concrete Subject class, addtion behaviors and status to be added.
    class ConcreteSubject:Subject
    {
        public ConcreteSubject(int mx,int mn):base(mx,mn)
        {
        }
    }
}
