namespace FreelerApp.Models;
public class Freelancer
{
    public int Id { get; set; }
    public string? PaidPlan { get; set; }
    public string? Areas { get; set; }
    public List<Contract>? Contracts { get; set; }
}