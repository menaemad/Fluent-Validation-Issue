using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FluentValidationIssue.Web.Views
{
    public abstract class FluentValidationIssueRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FluentValidationIssueRazorPage()
        {
            LocalizationSourceName = FluentValidationIssueConsts.LocalizationSourceName;
        }
    }
}
