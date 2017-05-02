using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maskn.Authorization;

namespace Maskn
{
    [DependsOn(
        typeof(MasknCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MasknApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MasknAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MasknApplicationModule).GetAssembly());
        }
    }
}