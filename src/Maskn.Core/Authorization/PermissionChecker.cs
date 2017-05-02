using Abp.Authorization;
using Maskn.Authorization.Roles;
using Maskn.Authorization.Users;
using Maskn.MultiTenancy;

namespace Maskn.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
