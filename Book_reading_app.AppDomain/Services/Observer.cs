using Book_reading_app.AppDomain.ConcreteSubject;
using Book_reading_app.AppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Services
{
    public class Observer : AbstractObserver
    {
        private string name; // name of subscriber
        private readonly Subject subject; // to access subject state
        private string observerState;

        public Observer(string nameOfObserver)
        {
            subject = new Subject();
            name = nameOfObserver;
            observerState = "";
        }

        //this function will be called when notify() will be called inside the AbstractSubject class by the ConcreteSubject object
        public override void Update(string changes)
        {
            Console.WriteLine("Subject state: " + subject.subjectState);
            Console.WriteLine("Previous Observer state: " + observerState);
            observerState = subject.subjectState;
            Console.WriteLine("Called from (Subscriber Name) : " + name);
            Console.WriteLine("Updated Observer state: " + observerState);

        }
    }

    public class Prog
    {
        public static void FakeMain()
        {
            Subject subject = new Subject();
            subject.Subscribe(new Observer("Subscriber 1"));
            subject.Subscribe(new Observer("Subscriber 2"));
            subject.Subscribe(new Observer("Subscriber 3"));

            subject.subjectState = "New State";
            subject.Notify(" Change happened");
        }
    }
}
