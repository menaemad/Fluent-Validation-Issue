using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationIssue.EntityFrameworkCore
{
    public static class FluentValidationIssueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FluentValidationIssueDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FluentValidationIssueDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
