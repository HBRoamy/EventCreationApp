using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.Core.Domain.Repository
{
    public interface IUserInfoService
    {
        public string GetCurrentUserEmail();
    }
}
