using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace demo.EntityFrameworkCore
{
    public static class demoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<demoDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<demoDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
