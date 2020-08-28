using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace BlazorSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMesage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user,message);
        }
    }
}
