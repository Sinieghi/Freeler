namespace FreelerApp.Models;
class Client
{
    public int Id { get; set; }
    public string? SearchingFor { get; set; }
    public string? TypeOfJob { get; set; }
    public List<Contract>? Contracts { get; set; }
    public List<Service>? Services { get; set; }

}