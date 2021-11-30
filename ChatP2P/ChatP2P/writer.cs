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
        public Writer()
        {
            Dati = new DatiCondivisi();
        }
        
        public void ProcThread()
        {
            while (true)
            {
                if (Dati.getVuoleConn())
                {
                    data = Encoding.ASCII.GetBytes("c;"+"127.0.0.1");
                    client.Send(data, data.Length, Dati.GetIpDestinatario(), 12345);
                    Dati.setVuoleConn(false);
                    Dati.SetaspettoRisposta(true);
                }

                if(Dati.getConnesso())
                {
                    if(Dati.getBoolInvioMess())
                    {
                        data = Encoding.ASCII.GetBytes("m;"+Dati.getMessaggioInviato());
                        client.Send(data, data.Length, Dati.GetIpDestinatario(), 12345);
                    }
                }
            }
        }
    }
}
