using Book_reading_app.AppDomain.AbstractFactories;
using Book_reading_app.AppDomain.Data.DB_Context;
using Book_reading_app.AppDomain.IRepositories;
using Book_reading_app.AppDomain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.ConcreteFactories
{
    public class EventFactory : IEventfactory
    {
        private readonly BookReadingAppDomainContext context;

        public EventFactory(BookReadingAppDomainContext context)
        {
            this.context = context;
        }

        public IBookRepo CreateBookRepo()
        {
            return new BookRepoService(context);
        }

        public ICommentRepo CreateCommentRepo()
        {
            return new CommentRepoService(context);
        }
    }
}
