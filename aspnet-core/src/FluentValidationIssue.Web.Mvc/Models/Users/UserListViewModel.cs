using System.Collections.Generic;
using FluentValidationIssue.Roles.Dto;

namespace FluentValidationIssue.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
