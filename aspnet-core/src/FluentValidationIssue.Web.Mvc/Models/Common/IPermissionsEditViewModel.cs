using System.Collections.Generic;
using FluentValidationIssue.Roles.Dto;

namespace FluentValidationIssue.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}