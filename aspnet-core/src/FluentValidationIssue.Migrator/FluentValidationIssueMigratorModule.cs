using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentValidationIssue.Configuration;
using FluentValidationIssue.EntityFrameworkCore;
using FluentValidationIssue.Migrator.DependencyInjection;

namespace FluentValidationIssue.Migrator
{
    [DependsOn(typeof(FluentValidationIssueEntityFrameworkModule))]
    public class FluentValidationIssueMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FluentValidationIssueMigratorModule(FluentValidationIssueEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FluentValidationIssueMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FluentValidationIssueConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FluentValidationIssueMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
