using System.ComponentModel.DataAnnotations;

class User
{
    public int Id { get; set; }
    [Required(ErrorMessage = "{0} required")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "{0} required")]
    [EmailAddress(ErrorMessage = "Enter a valid email")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "{0} required")]
    public string? Password { get; set; }
    private readonly Location? location;
    private readonly Client? client = null;
    private readonly Freelancer? Freelancer = null;
}