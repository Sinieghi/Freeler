class UserServices
{
    private readonly FreelerContext _freeler = new();
    public async Task InsertAsync(User user)
    {
        _freeler.Add(user);
        await _freeler.SaveChangesAsync();
    }
}