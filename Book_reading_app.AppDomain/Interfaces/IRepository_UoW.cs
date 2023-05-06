using Book_reading_app.AppDomain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.Interfaces
{
    public interface IRepository_UoW
    {
        public IBookRepo bookRepo { get; set; }
        public ICommentRepo commentRepo { get; set; }
        public Task SaveAsync();
    }
}
