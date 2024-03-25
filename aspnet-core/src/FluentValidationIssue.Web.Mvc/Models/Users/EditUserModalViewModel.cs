using System.Collections.Generic;
using System.Linq;
using FluentValidationIssue.Roles.Dto;
using FluentValidationIssue.Users.Dto;

namespace FluentValidationIssue.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
