using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maskn.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Maskn.Web.Host.Startup
{
    [DependsOn(
       typeof(MasknWebCoreModule))]
    public class MasknWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MasknWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MasknWebHostModule).GetAssembly());
        }
    }
}
