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
        UdpClient Server = new UdpClient();
        IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 12345);

        private byte[] dataReceived;
        public Listener(DatiCondivisi dati)
        {
            Dati = dati;
        }

        public void ProcListener()
        {
            
            
            while (true)
            {
                Server.Client.Bind(riceveEP);
                dataReceived = Server.Receive(ref riceveEP);
                string risposta = Encoding.ASCII.GetString(dataReceived);
                Dati.addserver(risposta+";"+riceveEP.Address);
                Console.WriteLine(risposta);
            }
        }
    }
}
