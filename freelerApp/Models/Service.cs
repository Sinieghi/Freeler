using System.ComponentModel.DataAnnotations;

class Service
{
    public int Id { get; set; }
    public string? Segment { get; set; } // Electric, mechanical and so on
    public string? Phone { get; set; }
    [Required(ErrorMessage = "{0} required")]
    public string? Mobile { get; set; }
    public bool WhatsApp { get; set; }
    public DateTime StartDate { get; set; }

}