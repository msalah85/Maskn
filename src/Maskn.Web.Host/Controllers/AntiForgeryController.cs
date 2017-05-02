using Maskn.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Maskn.Web.Host.Controllers
{
    public class AntiForgeryController : MasknControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}