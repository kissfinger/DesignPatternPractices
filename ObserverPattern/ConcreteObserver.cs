using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    //Concrete Observer class
    class ConcreteObserver:IObserver
    {
        private string name;
        
        //Constructor
        public ConcreteObserver(string n)
        {
            this.name = n;
        }

        //Implement the Update method of the Observer interface 
        public void Update(Subject subject)
        {
            Console.WriteLine("New Temperature Update from "+ this.name + 
                "---Highest:" + subject.MaxTemp.ToString() + ". Lowest:" + subject.MinTemp.ToString());
        }
    }
}
