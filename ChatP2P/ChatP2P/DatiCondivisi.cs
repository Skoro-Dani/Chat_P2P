using System;
using System.Collections.Generic;
using System.Text;

namespace ChatP2P
{
    public class DatiCondivisi
    {
        //lock
        private readonly object DaInviareLock = new object();
        private readonly object clientLock = new object();
        private readonly object serverLock = new object();
        private readonly object ConnessoLock = new object();
        private readonly object AspettoLock = new object();
        private readonly object RispostaLock = new object();
        private readonly object IpDestLock = new object();
        private readonly object IpVuolConnLock = new object();
        private readonly object WindowLock = new object();
        private readonly object FlagLock = new object();
        //variabili
        private List<string> DaInviare;
        private List<string> client;
        private List<string> server;
        private bool _Connesso;
        private bool _AspettoRispostaConnesione;
        //private bool _RispostaConnesione;
        private bool _VuoleConnetersi;
        private string _IpDestinatario;
        private string _IpVuoleConnetersi;
        private bool _flag;
        private MainWindow _w;

        public MainWindow w
        {
            get
            {
                lock (WindowLock)
                {
                    return _w;
                }
            }
            set
            {
                lock(WindowLock)
                {
                    _w = w;
                }
            }
        }
        public bool flag
        {
            get
            {
                lock (FlagLock)
                {
                    return _flag;
                }
            }
            set
            {
                lock (FlagLock)
                {
                    _flag = value;
                }
            }
        }
        public bool Connesso
        {
            get
            {
                lock (ConnessoLock)
                {
                    return _Connesso;
                }
            }
            set
            {
                lock (ConnessoLock)
                {
                    _Connesso = value;
                }
            }
        }
        public bool AspettoRispostaConnesione
        {
            get
            {
                lock (AspettoLock)
                {
                    return _AspettoRispostaConnesione;
                }
            }
            set
            {
                lock (AspettoLock)
                {
                    _AspettoRispostaConnesione = value;
                }
            }
        }
        /*public bool RispostaConnesione
        {
            get
            {
                lock (RispostaLock)
                {
                    return _RispostaConnesione;
                }
            }
            set
            {
                lock (RispostaLock)
                {
                    _RispostaConnesione = value;
                }
            }
        }*/
        public bool VuoleConnetersi
        {
            get
            {
                lock (AspettoLock)
                {
                    return _VuoleConnetersi;
                }
            }
            set
            {
                lock (AspettoLock)
                {
                    _VuoleConnetersi = value;
                }
            }
        }
        public string IpDestinatario
        {
            get
            {
                lock (IpDestLock)
                {
                    return _IpDestinatario;
                }
            }
            set
            {
                lock (IpDestLock)
                {
                    _IpDestinatario = value;
                }
            }
        }
        public string IpVuoleConnetersi
        {
            get
            {
                lock (IpVuolConnLock)
                {
                    return _IpVuoleConnetersi;
                }
            }
            set
            {
                lock (IpVuolConnLock)
                {
                    _IpVuoleConnetersi = value;
                }
            }
        }




        public DatiCondivisi(MainWindow window)
        {
            client = new List<string>();
            server = new List<string>();
            DaInviare = new List<string>();
            Connesso = false;
            AspettoRispostaConnesione = false;
            VuoleConnetersi = false;
            IpDestinatario = "";
            IpVuoleConnetersi = "";
            w = window;
            flag = true;
        }
        public string getDaInviare(int pos)
        {
            lock (DaInviareLock)
            {
                return DaInviare[pos];
            }
        }

        public string getclient(int pos)
        {
            lock (clientLock)
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
        public int getLenghtDaInviare()
        {
            lock (DaInviareLock)
            {
                return DaInviare.Count;
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
        public void addDaInviare(string s)
        {
            lock (DaInviareLock)
            {
                DaInviare.Add(s);
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
