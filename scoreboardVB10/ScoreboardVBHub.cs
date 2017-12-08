using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;

namespace scoreboardVB10
{
    public class SimpleHub : Hub
    {
        //private static string message = "Initial message";
        public void SendMessage(string message)
        {
            //_scoreVB += 1;
            //Clients.All.introduce(_scoreVB);
            Clients.All.showMessage(message);
        }

        public void JoinRoom(string roomName)
        {
            Groups.Add(Context.ConnectionId, roomName);
            Clients.Group(roomName).addChatMessage(Context.User.Identity.Name + " joined" + roomName + ".");
        }

        public void LeaveRoom(string roomName)
        {
            Groups.Remove(Context.ConnectionId, roomName);
            Clients.Group(roomName).addChatMessage(Context.User.Identity.Name + " left" + roomName + ".");
        }
    }
}