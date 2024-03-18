using FreelerApp.Models;
using HahnCargoSim.Helper;
using Microsoft.EntityFrameworkCore;
namespace FreelerApp.Services;
public class UserServices
{
    private readonly FreelerContext _freeler = new();
    public async Task InsertAsync(User user)
    {
        _freeler.Add(user);
        await _freeler.SaveChangesAsync();
    }
    public async Task<User> GetByUserEmail(string email, string pass)
    {
        var user = await _freeler.Users.FirstOrDefaultAsync(u => u.Email == email);

        if (!CryptoHelper.IsAuthorized(pass, user.PasswordHash)) return null;

        return user;
    }
    public async Task<User> GetUser(string token)
    {

        // CryptoHelper.IsAuthorized(token);

        return await _freeler.Users.FirstOrDefaultAsync();

    }
}