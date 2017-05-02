using Abp.Zero.EntityFrameworkCore;
using Maskn.Authorization.Roles;
using Maskn.Authorization.Users;
using Maskn.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Maskn.EntityFrameworkCore
{
    public class MasknDbContext : AbpZeroDbContext<Tenant, Role, User, MasknDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public MasknDbContext(DbContextOptions<MasknDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //...
        }
    }
}
