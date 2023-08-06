using Microsoft.AspNetCore.SignalR;


namespace signalr_demo.Hubs
{
    public class TaskListHub : Hub
    {
        public async Task AddTask(string task)
        {
            await Clients.All.SendAsync("TaskAdded", task);
        }

        public async Task RemoveTask(string task)
        {
            await Clients.All.SendAsync("TaskRemoved", task);
        }
    }
}
