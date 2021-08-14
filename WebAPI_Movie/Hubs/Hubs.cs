using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace WebAPI_Movie.Hubs
{
    [HubName("Movie")]
    public class Hubs : Hub
    {
        
        public async Task join(string roomName, string name)
        {
            await Groups.Add(Context.ConnectionId, roomName);
            Clients.Group(roomName).message(" (" + name + ") joined.");
        }

        public async Task leave(string roomName, string name)
        {
            await Groups.Remove(Context.ConnectionId, roomName);
            Clients.Group(roomName).message(" (" + name + ") leave.");
          
        }
        public void setcurrenttime( string group,string url)
        {
            Clients.OthersInGroup(group).getcurrenttime(url);
        }
        public void seturl(string group, string url)
        {
            Clients.OthersInGroup(group).geturl(url);
        }
        public void send(string group, string name,string message)
        {
            Clients.OthersInGroup(group).message("(" + name + ")"+ message);
        }

    }
}