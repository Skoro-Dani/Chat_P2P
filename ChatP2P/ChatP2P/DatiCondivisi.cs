using System;
using System.Collections.Generic;
using System.Text;

namespace ChatP2P
{
    public class DatiCondivisi
    {
        //variabili
        private List<string> client;
        private List<string> server;
        public bool Connesso { get
            {
                lock (ConnessoLock)
                {
                    return Connesso;
                }
            } set {
                lock (ConnessoLock)
                {
                    Connesso = value;
                }
            } }
        public bool AspettoRispostaConnesione
        {
            get
            {
                lock (AspettoLock)
                {
                    return AspettoRispostaConnesione;
                }
            }
            set
            {
                lock (AspettoLock)
                {
                    AspettoRispostaConnesione = value;
                }
            }
        }
        public bool VuoleConnetersi
        {
            get
            {
                lock (AspettoLock)
                {
                    return VuoleConnetersi;
                }
            }
            set
            {
                lock (AspettoLock)
                {
                    VuoleConnetersi = value;
                }
            }
        }
        public string IpDestinatario
        {
            get
            {
                lock (IpDestLock)
                {
                    return IpDestinatario;
                }
            }
            set
            {
                lock (IpDestLock)
                {
                    IpDestinatario = value;
                }
            }
        }
        public string IpVuoleConnetersi
        {
            get
            {
                lock (IpVuolConnLock)
                {
                    return IpVuoleConnetersi;
                }
            }
            set
            {
                lock (IpVuolConnLock)
                {
                    IpVuoleConnetersi = value;
                }
            }
        }

        //lock
        private readonly object clientLock = new object();
        private readonly object serverLock = new object();
        private readonly object ConnessoLock = new object();
        private readonly object AspettoLock = new object();
        private readonly object IpDestLock = new object();
        private readonly object IpVuolConnLock = new object();


        public DatiCondivisi()
        {
            client = new List<string>();
            server = new List<string>();
            Connesso = false;
            AspettoRispostaConnesione = false;
            VuoleConnetersi = false;
            IpDestinatario = "";
            IpVuoleConnetersi = "";
        }

        public string getclient(int pos)
        {
            lock(clientLock)
            {
                return client[pos];
            }
        }
        public string getserver(int pos)
        {
            lock (serverLock)
            {
                return server[pos];
            }
        }

        public int getLeghtclient()
        {
            lock (clientLock)
            {
                return client.Count;
            }
        }
        public int getLeghtserver()
        {
            lock (serverLock)
            {
                return server.Count;
            }
        }

        public void addclient(string s)
        {
            lock (clientLock)
            {
                client.Add(s);
            }
        }
        public void addserver(string s)
        {
            lock (serverLock)
            {
                server.Add(s);
            }
        }
    }
}
