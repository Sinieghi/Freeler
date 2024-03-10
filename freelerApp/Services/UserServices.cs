using HahnCargoSim.Helper;
using Microsoft.EntityFrameworkCore;

class UserServices
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
}