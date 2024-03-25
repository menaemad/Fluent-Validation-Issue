using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FluentValidationIssue.Configuration.Dto;

namespace FluentValidationIssue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FluentValidationIssueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
