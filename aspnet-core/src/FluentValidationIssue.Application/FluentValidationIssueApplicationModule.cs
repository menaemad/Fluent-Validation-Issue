using Abp.AutoMapper;
using Abp.FluentValidation;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentValidationIssue.Authorization;

namespace FluentValidationIssue
{
    [DependsOn(
        typeof(FluentValidationIssueCoreModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpFluentValidationModule)
        )]
    public class FluentValidationIssueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FluentValidationIssueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FluentValidationIssueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}