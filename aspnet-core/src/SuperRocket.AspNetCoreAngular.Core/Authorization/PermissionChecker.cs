using Abp.Authorization;
using SuperRocket.AspNetCoreAngular.Authorization.Roles;
using SuperRocket.AspNetCoreAngular.Authorization.Users;

namespace SuperRocket.AspNetCoreAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
