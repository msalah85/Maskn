using Microsoft.EntityFrameworkCore;

namespace Maskn.EntityFrameworkCore
{
    public static class MasknDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MasknDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}