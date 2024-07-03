using Microsoft.AspNetCore.SignalR;

namespace SignalR.Api
{
    public sealed class ChatHub : Hub<IChatClient>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.ReceivedMessage($"{Context.ConnectionId} was joined!");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.ReceivedMessage($"{Context.ConnectionId}: {message}");
        }
    }
}
