using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatP2P
{
    public class Writer
    {
        private DatiCondivisi Dati;
        UdpClient client = new UdpClient();
        private byte[] data;
        public Writer(DatiCondivisi Dati)
        {
            this.Dati = Dati;
        }


        public void ProcThread()
        {
            int count = 0;
            while (true && Dati.w != null)
            {
                if (Dati.getLenghtDaInviare() > count)
                {
                    data = Encoding.ASCII.GetBytes(Dati.getDaInviare(count));
                    client.Send(data, data.Length, Dati.IpDestinatario, 12345);
                    count++;
                }
            }
        }
    }
}
