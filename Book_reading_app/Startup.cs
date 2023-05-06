using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Book_reading_app.AppDomain.Data.DB_Context;
using Book_reading_app.Core.Domain.Entities;
using Book_reading_app.Core.Domain.Repository;
using Book_reading_app.AppDomain.Repository;
using Microsoft.AspNetCore.Http;
using Book_reading_app.AppDomain.Services;
using Book_reading_app.AppDomain.IRepositories;
using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.AppDomain.UnitsOfWork;
using Book_reading_app.AppDomain.AbstractFactories;
using Book_reading_app.AppDomain.ConcreteFactories;
using Book_reading_app.Core.Logger;

namespace Book_reading_app.Core.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookReadingAppDomainContext>(option => option.UseSqlServer(Configuration.GetConnectionString("EasyConnection")));

            services.AddAutoMapper(typeof(Startup));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<BookReadingAppDomainContext>();

            services.Configure<IdentityOptions>(Options =>
            {
                Options.User.RequireUniqueEmail = true;
                Options.Password.RequiredLength = 5;
                Options.Password.RequireDigit = false;
                Options.Password.RequireLowercase = false;
                Options.Password.RequireUppercase = false;
                Options.Password.RequireNonAlphanumeric = true;
                Options.SignIn.RequireConfirmedAccount = false;

            });
            //services.AddScoped<BookReadingAppDomainContext, BookReadingAppDomainContext>();
            //services.AddScoped<BookEventsRepo, BookEventsRepo>();
            //services.AddScoped<CommentsRepo, CommentsRepo>();
            services.AddScoped<IBookRepo, BookRepoService>();
            services.AddScoped<ICommentRepo, CommentRepoService>();
            services.AddScoped<IFacadeFactory, FacadeFactory>();
            services.AddScoped<IRepository_UoW, Repository_UoW>();
            services.AddScoped<IUserCredsService, UserInfoService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();

#if DEBUG

            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStatusCodePagesWithRedirects("/BookEvent/UnAuthorized"); // for unauthorized users trying to access methods with AuthorizeAttribute or AccessControlAttribute (made by me)
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=BookEvent}/{action=Index}/{IsSuccess?}");
            });
        }
    }
}
