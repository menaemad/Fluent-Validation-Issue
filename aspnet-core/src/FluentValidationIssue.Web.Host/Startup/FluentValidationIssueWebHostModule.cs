using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentValidationIssue.Configuration;

namespace FluentValidationIssue.Web.Host.Startup
{
    [DependsOn(
       typeof(FluentValidationIssueWebCoreModule))]
    public class FluentValidationIssueWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FluentValidationIssueWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FluentValidationIssueWebHostModule).GetAssembly());
        }
    }
}
