using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.AppDomain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.Services
{
    public class Facade : IFacade 
    {
        private readonly IRepository_UoW uoW;
        public IBookRepo bookRepo { get; set; }
        public ICommentRepo commentRepo { get; set; }

        public Facade(IRepository_UoW UoW)
        {
            uoW = UoW;
            bookRepo = uoW.bookRepo;
            commentRepo = uoW.commentRepo;
        }

        public async Task SaveUsingFacadeAsync()
        {
            await uoW.SaveAsync();
        }



    }
}
