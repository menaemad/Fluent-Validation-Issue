using Abp.AspNetCore.Mvc.ViewComponents;

namespace FluentValidationIssue.Web.Views
{
    public abstract class FluentValidationIssueViewComponent : AbpViewComponent
    {
        protected FluentValidationIssueViewComponent()
        {
            LocalizationSourceName = FluentValidationIssueConsts.LocalizationSourceName;
        }
    }
}
