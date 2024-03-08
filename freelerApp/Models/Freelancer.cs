class Freelancer
{
    public int Id { get; set; }
    public string? PaidPlan { get; set; }
    public string? Areas { get; set; }
    private List<Contract> contracts { get; set; }
}