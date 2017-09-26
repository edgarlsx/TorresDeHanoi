using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Antlr.Runtime;
using Microsoft.AspNet.SignalR.Hubs;
using TorresDeHanoi;

namespace TorresDeHanoiApp.hubs
{
    [HubName("torresHub")]
    public class TorresHub
    {
        public void send(int torreId)
        {
            Task.Run(() => StartHanoi(torreId));
        }

        private void StartHanoi(int torreId)
        {
            var torres = new TorreDeHanoi();
            torres.torreId = torreId;

            torres.moveTorre(torres.numdiscos, 1, 3, 2), (torreId, disk, from, to) =>
            {
                Clients.All.addNewMessageToPage(torreId, from, to, disk);
            });

        }

    }
}