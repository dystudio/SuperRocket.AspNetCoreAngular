using Microsoft.AspNetCore.Antiforgery;
using SuperRocket.AspNetCoreAngular.Controllers;

namespace SuperRocket.AspNetCoreAngular.Web.Host.Controllers
{
    public class AntiForgeryController : AspNetCoreAngularControllerBase
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
