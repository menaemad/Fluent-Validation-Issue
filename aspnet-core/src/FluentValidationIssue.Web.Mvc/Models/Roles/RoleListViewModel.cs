using System.Collections.Generic;
using FluentValidationIssue.Roles.Dto;

namespace FluentValidationIssue.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
