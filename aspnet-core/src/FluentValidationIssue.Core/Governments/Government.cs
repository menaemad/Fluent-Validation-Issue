using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace FluentValidationIssue.Governments
{
    public class Government : FullAuditedEntity<int>
    {
        [StringLength(100)]
        public string Name { get; set; }
    }
}