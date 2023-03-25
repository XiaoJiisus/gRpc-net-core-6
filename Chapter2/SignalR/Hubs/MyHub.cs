using Microsoft.AspNetCore.SignalR;

namespace SignalRDemo.Hubs;

public class MyHub : Hub
{
    public async Task SendMessag(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}