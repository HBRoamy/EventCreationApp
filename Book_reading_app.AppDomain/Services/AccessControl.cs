using Book_reading_app.AppDomain.Interfaces;

namespace Book_reading_app.AppDomain.Services
{

    public class AccessControlAttribute : AbstractAccessControlDecorator
    {
        public string RoleGroup 
        { 
            get { 
                return base.Role;
                }
            set {
                base.Role = value;
                }
        }

    }

}
