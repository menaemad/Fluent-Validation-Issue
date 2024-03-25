using Abp.AutoMapper;
using FluentValidationIssue.Roles.Dto;
using FluentValidationIssue.Web.Models.Common;

namespace FluentValidationIssue.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
