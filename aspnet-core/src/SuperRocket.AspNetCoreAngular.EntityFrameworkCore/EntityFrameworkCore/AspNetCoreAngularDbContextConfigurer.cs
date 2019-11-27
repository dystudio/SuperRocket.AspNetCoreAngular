using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SuperRocket.AspNetCoreAngular.EntityFrameworkCore
{
    public static class AspNetCoreAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AspNetCoreAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AspNetCoreAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
