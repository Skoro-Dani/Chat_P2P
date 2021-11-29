using System;
using System.Collections.Generic;
using System.Text;

namespace ChatP2P
{
    public class DatiCondivisi
    {
        private readonly object IpDestLock = new object();
        private readonly object MessRicLock = new object();
        private readonly object MessInviatocLock = new object();
        private readonly object ConnessoLock = new object();
        private readonly object VuoleConnessioneLock = new object();
        private string IpDestinatario;
        private string MessaggioRicevuto;
        private string MessaggioInviato;
        private bool Connesso = false;
        private bool VuoleConnetersi = false;

        public DatiCondivisi()
        {
            IpDestinatario = "";
            MessaggioInviato = "";
            MessaggioRicevuto = "";
        }

        public DatiCondivisi(string ipDestinatario, string messaggioRicevuto, string messaggioInviato)
        {
            IpDestinatario = ipDestinatario;
            MessaggioRicevuto = messaggioRicevuto;
            MessaggioInviato = messaggioInviato;
        }
        
        public string getIpDestinatario()
        {
            lock (IpDestLock)
            {
                return IpDestinatario;
            }
        }
        public void setIpDestinatario(string ip)
        {
            lock(IpDestLock)
            {
                IpDestinatario = ip;
            }
        }

        public string getMessaggioRicevuto()
        {
            lock (MessRicLock)
            {
                return MessaggioRicevuto;
            }
        }
        public void setMessaggioRicevuto(string MessRicevuto)
        {
            lock (MessRicLock)
            {
                MessaggioRicevuto = MessRicevuto;
            }
        }

        public string getMessaggioInviato()
        {
            lock (MessInviatocLock)
            {
                return MessaggioInviato;
            }
        }
        public void setMessaggioInviato(string MessDaInviare)
        {
            lock (MessInviatocLock)
            {
                MessaggioInviato = MessDaInviare;
            }
        }
        public bool getConnesso()
        {
            lock (ConnessoLock)
            {
                return Connesso;
            }
        }
        public void setConnesso(bool Connesso)
        {
            lock (ConnessoLock)
            {
                this.Connesso = Connesso;
            }
        }
        public bool getVuoleConn()
        {
            lock (VuoleConnessioneLock)
            {
                return VuoleConnetersi;
            }
        }
        public void setVuoleConn(bool VuoleConnesso)
        {
            lock (VuoleConnessioneLock)
            {
                VuoleConnetersi = VuoleConnesso;
            }
        }

    }
}
