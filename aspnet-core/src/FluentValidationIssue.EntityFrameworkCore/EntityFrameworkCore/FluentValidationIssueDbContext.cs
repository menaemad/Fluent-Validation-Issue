using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FluentValidationIssue.Authorization.Roles;
using FluentValidationIssue.Authorization.Users;
using FluentValidationIssue.MultiTenancy;
using FluentValidationIssue.Governments;

namespace FluentValidationIssue.EntityFrameworkCore
{
    public class FluentValidationIssueDbContext : AbpZeroDbContext<Tenant, Role, User, FluentValidationIssueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Government> Governments { get; set; }

        public FluentValidationIssueDbContext(DbContextOptions<FluentValidationIssueDbContext> options)
            : base(options)
        {
        }
    }
}