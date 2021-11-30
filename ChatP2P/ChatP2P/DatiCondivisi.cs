using System;
using System.Collections.Generic;
using System.Text;

namespace ChatP2P
{
    public class DatiCondivisi
    {
        //lock
        private readonly object IpDestLock = new object();
        private readonly object MessRicLock = new object();
        private readonly object MessInviatocLock = new object();
        private readonly object ConnessoLock = new object();
        private readonly object VuoleConnessioneLock = new object();
        private readonly object aspettoRispostaLock = new object();
        private readonly object MessDaInviareboolLock = new object();
        //Variabili
        private string IpDestinatario;
        private string MessaggioRicevuto;
        private string MessaggioInviato;
        private bool Connesso = false;
        private bool VuoleConnetersi = false;//qualcuno vuole connetersi
        private bool AspettoRisposta = false;//ho inviato una prova di connesione e aspetto che mi risponda
        private bool MessDaInviarebool = false;
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
        
        public string GetIpDestinatario()
        {
            lock (IpDestLock)
            {
                return IpDestinatario;
            }
        }
        public long GetIpDestinatarioLong()
        {
            lock (IpDestLock)
            {
                return long.Parse(IpDestinatario);
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
        public bool getAspettoRisposta()
        {
            lock (aspettoRispostaLock)
            {
                return AspettoRisposta;
            }
        }
        public void SetaspettoRisposta(bool aspetto)
        {
            lock (aspettoRispostaLock)
            {
                AspettoRisposta = aspetto;
            }
        }
        public bool getBoolInvioMess()
        {
            lock (MessDaInviareboolLock)
            {
                return MessDaInviarebool;
            }
        }
        public void setBoolInvioMess(bool Invio)
        {
            lock (MessDaInviareboolLock)
            {
                MessDaInviarebool = Invio;
            }
        }
    }
}
