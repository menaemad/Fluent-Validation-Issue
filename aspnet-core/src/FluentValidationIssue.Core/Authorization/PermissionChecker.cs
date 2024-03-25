using Abp.Authorization;
using FluentValidationIssue.Authorization.Roles;
using FluentValidationIssue.Authorization.Users;

namespace FluentValidationIssue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
