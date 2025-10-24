using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MessageMe.server.Hubs
{
    public class ChatHub : Hub
    {
        public object Clients { get; private set; }

        public async Task
            message(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message); //clients listens this using javascript
        }
    }
}
