using Book_reading_app.AppDomain.Data.DB_Context;
using Book_reading_app.AppDomain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.AbstractFactories
{
    public interface IEventfactory
    {
        public abstract IBookRepo CreateBookRepo();
        public abstract ICommentRepo CreateCommentRepo();

    }
}
