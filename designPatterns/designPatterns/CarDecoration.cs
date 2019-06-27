using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{

    //observer
    interface INotify
    {
        void Notification();
    }

    class EventNotification:INotify
    {
        string message;
        public EventNotification(string msg)
        {
            message = msg;
        }

        public void Notification()
        {
            Console.WriteLine(message);
        }
    }

    class SpecialOffer:INotify
    {

        string message;
        public SpecialOffer(string msg)
        {
            message = msg;
        }

        public void Notification()
        {
            Console.WriteLine(message);
        }
    }
    class subject
    {
        ArrayList allnotifications = new ArrayList();

        public void Register(INotify notification)
        {
            allnotifications.Add(notification);
        }

        public void annouce()
        {
            foreach(INotify n in allnotifications)
            {
                n.Notification();
            }
        }
    }








    //Decorator
    class CarDecoration
    {
        public virtual void EngineType()
        {
            Console.WriteLine("No Engine");
        }
    }

    class PetrolEngine : CarDecoration
    {
        public override void EngineType()
        {
            Console.WriteLine("Petrol Engine");
        }
    }
    class DieselENgine : CarDecoration
    {
        public override void EngineType()
        {
            Console.WriteLine("Diesel Engine");
        }
    }
}
