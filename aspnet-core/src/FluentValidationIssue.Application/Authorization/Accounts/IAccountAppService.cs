using System.Threading.Tasks;
using Abp.Application.Services;
using FluentValidationIssue.Authorization.Accounts.Dto;

namespace FluentValidationIssue.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
