using Book_reading_app.AppDomain.AbstractFactories;
using Book_reading_app.AppDomain.ConcreteFactories;
using Book_reading_app.AppDomain.Data.DB_Context;
using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.AppDomain.IRepositories;
using Book_reading_app.AppDomain.Services;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.UnitsOfWork
{
    public class Repository_UoW : IRepository_UoW
    {

        private readonly BookReadingAppDomainContext _context;
        public IBookRepo bookRepo { get; set; }
        public ICommentRepo commentRepo { get; set; }
        private readonly IEventfactory eventObjectFactory;
        public Repository_UoW(BookReadingAppDomainContext context)
        {
            _context = context;
            eventObjectFactory = new EventFactory(_context);
            bookRepo = eventObjectFactory.CreateBookRepo();
            commentRepo = eventObjectFactory.CreateCommentRepo();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
