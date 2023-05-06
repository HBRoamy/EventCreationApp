using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Interfaces
{
    public abstract class AbstractObserver
    {
        public abstract void Update(string changes);
    }
}
