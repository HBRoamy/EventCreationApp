using Book_reading_app.AppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.ConcreteSubject
{
    public class Subject : AbstractSubject
    {
        public string subjectState { get; set; } = "";
    }
}
