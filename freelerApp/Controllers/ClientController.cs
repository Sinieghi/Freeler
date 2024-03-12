using FreelerApp.Models;

namespace FreelerApp.Controllers;
class ClientController
{
    private readonly Client? Client;
    public Client GetClientProfile()
    {
        return null;
    }
    public void UpdateClient(Client client) { }
    public void CreateService() { }
    public void RemoveService() { }
    public Service UpdateService(Service service)
    {
        return null;
    }
    public List<Service> GetAllService()
    {
        return null;
    }

    public void AcceptApplication() { }
    public void DeniedApplication() { }
    public void SendOffer() { }
    public List<Contract> GetContracts()
    {
        return null;
    }
    public List<Contract> GetAcceptedContracts()
    {
        return null;
    }


}