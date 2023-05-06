using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Interfaces
{
   public abstract class AbstractDecorator : IUserCredsService
    {
        private readonly IUserCredsService user;

        public AbstractDecorator(IUserCredsService user)
        {
            this.user = user;
        }
        public virtual string GetCurrentUserEmail()
        {
            return user.GetCurrentUserEmail();
        }

    }
}
