using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Interfaces
{

    [System.AttributeUsage(System.AttributeTargets.All, AllowMultiple = true)]  // multiuse attribute
    public abstract class AbstractAccessControlDecorator : AuthorizeAttribute, IAuthorizeData
    {
        public string Role { get { return Roles; } set { Roles = value; } }
    }
}
