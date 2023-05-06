using Book_reading_app.AppDomain.AbstractFactories;
using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.AppDomain.Services;

namespace Book_reading_app.AppDomain.ConcreteFactories
{
    public class FacadeFactory: IFacadeFactory
    {
        private readonly IRepository_UoW uoW;

        
        public FacadeFactory(IRepository_UoW _UoW)
        {
            uoW = _UoW;
        }
        public IFacade getFacade()
        {
            return new Facade(uoW); 
        }

    }
}
