using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HahnCargoSim.Helper;
using Microsoft.Extensions.Options;
using FreelerApp.Models;
[Authorize]
[ApiController]
[Route("[controller]/[action]")]
class UserController(UserServices userServices, IOptions<FreelerConfig> options) : Controller
{

    private readonly UserServices _us = userServices;
    private readonly FreelerConfig config = options.Value;
    public async Task<IActionResult> Index()
    {
        return View();
    }
    public IActionResult Sign()
    {
        return View();
    }
    public async Task<IActionResult> Sign(User user)
    {
        await _us.InsertAsync(user);

        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login(string email, string password)
    {
        IActionResult result;
        var user = await _us.GetByUserEmail(email, password);
        if (user == null)
            result = BadRequest(new { message = "Email or password is wrong" });
        else
        {
            var tokenStr = CryptoHelper.GetJwtTokenString(config.TokenSecret, user.Email);
            result = Ok(new { user, Token = tokenStr });
        }
        return View(result);
    }


    public async Task<IActionResult> Logout()
    {
        return null;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ChangeEmail()
    {
        return null;

    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ChangePass()
    {
        return null;

    }
}