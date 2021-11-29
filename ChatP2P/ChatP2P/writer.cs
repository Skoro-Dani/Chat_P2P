using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatP2P
{
    public class writer
    {
        private DatiCondivisi Dati;
        public writer(DatiCondivisi Dati)
        {
            this.Dati = Dati;
        }
        public writer()
        {
            Dati = new DatiCondivisi();
        }
        
        public void ProcThread()
        {
            while (true)
            {
                if (Dati.getVuoleConn())
                {
                    UdpClient client = new UdpClient();
                    byte[] data = Encoding.ASCII.GetBytes("C"+"127.0.0.1");
                    client.Send(data, data.Length, Dati.getIpDestinatario(), 12345);
                }
            }
        }
    }
}
