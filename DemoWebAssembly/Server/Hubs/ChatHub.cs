using Microsoft.AspNetCore.SignalR;

namespace DemoWebAssembly.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task JoinGroup(string groupname)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupname);

        }
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
           // await Clients.Group(groupname).SendAsync("groupReceive", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("receiveMessage", "Connected");
        }
    }
}
