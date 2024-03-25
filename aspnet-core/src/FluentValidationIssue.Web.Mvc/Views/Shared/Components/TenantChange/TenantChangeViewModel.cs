using Abp.AutoMapper;
using FluentValidationIssue.Sessions.Dto;

namespace FluentValidationIssue.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
