using System.ComponentModel.DataAnnotations;
namespace FreelerApp.Models;

class User
{
    public int Id { get; set; }
    [Required(ErrorMessage = "{0} required")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "{0} required")]
    [EmailAddress(ErrorMessage = "Enter a valid email")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "{0} required")]
    public string? PasswordHash { get; set; }
    public readonly Location? location;
    public readonly Client? client = null;
    public readonly Freelancer? Freelancer = null;
}