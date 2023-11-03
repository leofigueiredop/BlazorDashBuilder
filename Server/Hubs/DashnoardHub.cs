// Add the following namespace to use the Hub class inheritance.
using Microsoft.AspNetCore.SignalR;

namespace Rampfy.BlazorDash.Server.Hubs
{
    public class DashboardHub : Hub
    {
        // Method call for updating dashboard panel into new dragged position.
        // id - Dashboard component ID.
        // row - New row for dragged panel.
        // column - New column for dragged panel.
        public async Task Create ()
        {
            //await Clients.All.SendAsync("LayoutChange";
        }
    }
}