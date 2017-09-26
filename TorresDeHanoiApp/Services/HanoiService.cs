using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TorresDeHanoi;

namespace TorresDeHanoiApp.Services
{
    public class HanoiService
    {

        private List<Hanoi> torres = new List<Hanoi>();

        public List<Hanoi> GetHistory()
        {
            return new List<Hanoi>();
        }

        public Hanoi StartHanoi()
        {
            var oHanoi = new TorreDeHanoi(3);

            oHanoi.torreId = Hanoi.Count();

            Hanoi.Add(oHanoi);

            return oHanoi;
        }

    }
}