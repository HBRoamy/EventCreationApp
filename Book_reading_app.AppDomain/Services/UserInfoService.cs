using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.Core.Domain.Repository;
using Microsoft.AspNetCore.Http;

namespace Book_reading_app.AppDomain.Services
{
    public class UserInfoService : IUserCredsService
    {
        private readonly IHttpContextAccessor _httpContext;

        public UserInfoService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string GetCurrentUserEmail()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.Name);
        }

    }
}
