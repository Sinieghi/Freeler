using FreelerApp.Models;

namespace FreelerApp.Controllers;
class ContractController
{
    public User User;
    public List<Contract> Offers()
    {
        return null;
    }
    public void SendOffer(User Sender, User Receiver)
    {
        if (Sender.client != null) { }
        else { }
    }
    public void Accept() { }
    public void Reject() { }
}