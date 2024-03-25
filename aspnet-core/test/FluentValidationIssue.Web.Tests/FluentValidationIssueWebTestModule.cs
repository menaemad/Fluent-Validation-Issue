using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentValidationIssue.EntityFrameworkCore;
using FluentValidationIssue.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FluentValidationIssue.Web.Tests
{
    [DependsOn(
        typeof(FluentValidationIssueWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FluentValidationIssueWebTestModule : AbpModule
    {
        public FluentValidationIssueWebTestModule(FluentValidationIssueEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FluentValidationIssueWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FluentValidationIssueWebMvcModule).Assembly);
        }
    }
}