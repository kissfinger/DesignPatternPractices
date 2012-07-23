using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    //Client Program
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new Subject and Observers
            ConcreteSubject source = new ConcreteSubject(35,30);
            ConcreteObserver stationAlpha = new ConcreteObserver("Alpha");
            ConcreteObserver stationBeta = new ConcreteObserver("Beta");

            //Registering Observers to Subject
            source.Register(stationAlpha);
            source.Register(stationBeta);

            //Updating the status of the Subject
            source.UpdateData(38,33);

            //Removing an Observer
            source.Remove(stationAlpha);

            // Again, updating the status of the Subject
            source.UpdateData(36,31);
        }
    }
}
