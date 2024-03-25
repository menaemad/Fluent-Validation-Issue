using System.Threading.Tasks;
using FluentValidationIssue.Configuration.Dto;

namespace FluentValidationIssue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
