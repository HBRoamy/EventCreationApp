using Book_reading_app.AppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.AppDomain.Services
{
    public class UserInfoService_Decorated : AbstractDecorator
    {
        //inheritance doesnt make sense here so I used Decorator pattern
        public UserInfoService_Decorated(IUserCredsService user) : base(user)
        {
        }

        public override string GetCurrentUserEmail()
        {
            string currentUser=null;
            try
            {
                currentUser = base.GetCurrentUserEmail();
                if(currentUser!=null)
                if(currentUser.Equals("justforexception@gmail.com"))
                    throw new Exception("I was thrown from the decorator");
            }
            catch(Exception e)
            {
                Console.WriteLine("**********************");
                Console.WriteLine("Error message from decorator : " + e.Message);
                Console.WriteLine("**********************");
            }
            return currentUser; // returns null if this statement is reached.
        }
    }
}
