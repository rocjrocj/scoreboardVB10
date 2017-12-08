using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace scoreboardVB10
{
    public class SimpleHub : Hub
    {
        //private static int _scoreVB = 0;
        public void SendMessage(string message)
        {
            //_scoreVB += 1;
            //Clients.All.introduce(_scoreVB);
            Clients.All.showMessage(message);
        }
    }
}