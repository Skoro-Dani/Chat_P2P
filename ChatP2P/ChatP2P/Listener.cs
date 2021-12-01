using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatP2P
{
    class Listener
    {
        private DatiCondivisi Dati;
        private UdpClient Server = new UdpClient();
        private IPEndPoint riceveEP;
        private byte[] dataReceived;
        public Listener(DatiCondivisi dati)
        {
            Dati = dati;
            riceveEP = new IPEndPoint(IPAddress.Any, 0);
        }

        public void ProcListener()
        {
            while(true)
            {
                dataReceived = Server.Receive(ref riceveEP);
                string risposta = Encoding.ASCII.GetString(dataReceived);
                Dati.addserver(risposta);
                Console.WriteLine(risposta);
            }
        }
    }
}
