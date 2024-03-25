using System.Threading.Tasks;
using Abp.Application.Services;
using FluentValidationIssue.Sessions.Dto;

namespace FluentValidationIssue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
