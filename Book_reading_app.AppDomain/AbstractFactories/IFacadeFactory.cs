using Book_reading_app.AppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.AbstractFactories
{
    public interface IFacadeFactory
    {
        public IFacade getFacade();
    }
}
