using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Maskn.Controllers
{
    public abstract class MasknControllerBase: AbpController
    {
        protected MasknControllerBase()
        {
            LocalizationSourceName = MasknConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}