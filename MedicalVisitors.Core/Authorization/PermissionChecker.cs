using Abp.Authorization;
using MedicalVisitors.Authorization.Roles;
using MedicalVisitors.MultiTenancy;
using MedicalVisitors.Users;

namespace MedicalVisitors.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
