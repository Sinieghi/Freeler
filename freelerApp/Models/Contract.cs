namespace FreelerApp.Models;
public class Contract
{
    public int Id { get; set; }
    public double Price { get; set; }
    public string? PaymentForm { get; set; }
    public bool Status { get; set; }
    public DateTime ServiceStartDate { get; set; }
    public DateTime ServiceEndDate { get; set; }
}