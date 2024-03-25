using Abp.Application.Services.Dto;

namespace FluentValidationIssue.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

