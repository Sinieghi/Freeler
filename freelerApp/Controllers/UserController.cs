using Microsoft.AspNetCore.Mvc;

class UserController(UserServices userServices) : Controller
{
    private readonly UserServices _us = userServices;
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
    public void Login() { }
    public void Logout() { }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public void ChangeEmail() { }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public void ChangePass() { }
}