public class FreelerConfig
{
    public string TokenSecret { get; set; }
    public string GridToLoad { get; set; }
    public bool UseRandomOrders { get; set; }
    public string OrdersToLoad { get; set; }
    public TimeSpan FreelerTick { get; set; }
}