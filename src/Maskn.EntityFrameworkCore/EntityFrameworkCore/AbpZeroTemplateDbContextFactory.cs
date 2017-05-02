using Maskn.Configuration;
using Maskn.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Maskn.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MasknDbContextFactory : IDbContextFactory<MasknDbContext>
    {
        public MasknDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<MasknDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MasknDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MasknConsts.ConnectionStringName));
            
            return new MasknDbContext(builder.Options);
        }
    }
}