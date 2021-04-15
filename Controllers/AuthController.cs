using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace Pitako.Identity.Api.Controllers
{
    [Route("api/identity")]
    public class AuthController : BaseController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

    }
}