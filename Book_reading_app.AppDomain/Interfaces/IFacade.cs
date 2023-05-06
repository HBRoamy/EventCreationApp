using Book_reading_app.AppDomain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.Interfaces
{
    public interface IFacade
    {
        public IBookRepo bookRepo { get; set; }
        public ICommentRepo commentRepo { get; set; }
        public Task SaveUsingFacadeAsync();
    }
}
