using Abp.Application.Services;
using FluentValidationIssue.MultiTenancy.Dto;

namespace FluentValidationIssue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

