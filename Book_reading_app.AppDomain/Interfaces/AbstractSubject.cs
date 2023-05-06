using Book_reading_app.AppDomain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Interfaces
{
    public abstract class AbstractSubject
    {
        private List<Observer> subscribers = new List<Observer>();

        public void Subscribe(Observer observer)
        {
            subscribers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            subscribers.Remove(observer);
        }
        public void Notify(string changes)
        {
            foreach (Observer subscriber in subscribers)
            {
                subscriber.Update(changes);
            }
        }
        
    }
}
