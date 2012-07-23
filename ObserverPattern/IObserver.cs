using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{   
    //Observer interface
    interface IObserver
    {
        void Update(Subject subject);
    }
}
