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
            Clients.Group(roomName).message(name, " joined. Wellcome!");
            Clients.OthersInGroup(roomName).get(roomName);
        }

        public async Task leave(string roomName, string name)
        {
            await Groups.Remove(Context.ConnectionId, roomName);
            Clients.Group(roomName).message(name," leaved. Goodbye!");
           
        }
        public void leaveroom(string roomName) {
            Clients.Group(roomName).getleave(roomName);
        }
        public void setcurrenttime( string group,string url)
        {
            Clients.OthersInGroup(group).getcurrenttime(url);
        }
        public void seturl(string group, string url)
        {
            Clients.OthersInGroup(group).geturl(url);
        }
        public void send(string group,string url ,string time)
        {
            Clients.OthersInGroup(group).getlive(url, time);
        }

        public void go_live(string user, string url, string time)
        {
            Clients.User(user).get_live(url, time);
        }

        public void send_message(string group , string name ,string msg)
        {
            Clients.Group(group).message(name,msg);
        }

    }
}