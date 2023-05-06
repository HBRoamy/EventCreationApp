using Book_reading_app.Core.Domain.Entities;
using BookReadingApp.Plugins;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Data.DB_Context
{
    public class BookReadingAppDomainContext : IdentityDbContext<ApplicationUser>
    {
        public BookReadingAppDomainContext(DbContextOptions<BookReadingAppDomainContext> options) : base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(new CustomDbInterceptor());
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<BookEventEntity> BookEvents { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }

    }
}
