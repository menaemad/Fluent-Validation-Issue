using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FluentValidationIssue.Controllers
{
    public abstract class FluentValidationIssueControllerBase: AbpController
    {
        protected FluentValidationIssueControllerBase()
        {
            LocalizationSourceName = FluentValidationIssueConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
