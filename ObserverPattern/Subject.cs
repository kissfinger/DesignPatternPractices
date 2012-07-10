using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObserverPattern
{
    //Subject abstrct parent class
    abstract class Subject
    {
        //Composition of the Observers
        private List<IObserver> observers = new List<IObserver>();

        //Subject status
        private int maxTemp;
        private int minTemp;
        
        //Constructor
        public Subject(int mx, int mn)
        {
            this.maxTemp = mx;
            this.minTemp = mn;
        }

        //Register an Observer 
        public void Register(IObserver o)
        {
            observers.Add(o);
        }

        //Remove an Observer
        public void Remove(IObserver o)
        {
            observers.Remove(o);
        }

        //Update the Observers
        public void Inform()
        {
            foreach(IObserver o in observers)
                o.Update(this);
        }
   
        //Modifying the status of the Subject
        public void UpdateData(int mx, int mn)
        {
            this.maxTemp = mx;
            this.minTemp = mn;
            this.Inform();
        }

        //Getter for maxtemp
        public int MaxTemp
        {
            get { return maxTemp;}
        }

        //Getter for mintemp
        public int MinTemp
        {
            get { return minTemp;}
        }
    }
}
 