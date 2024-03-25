using Abp.MultiTenancy;
using FluentValidationIssue.Authorization.Users;

namespace FluentValidationIssue.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
