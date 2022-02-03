using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.AspNetCore.SignalR;
using poc_signalr.Interfaces;

namespace poc_signalr.Hubs
{
    public class PocHub : Hub<IPocHub>
    {
        public PocHub()
        {
        }

        public void GetMessage()
        {
            Clients.Caller.NotifyConnection("Connection with Pochub succeed!");
        }

        public void GetCounter() {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1000);
                Clients.Caller.Counter(i);
            }
        }
    }
}
