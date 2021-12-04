using System;
using System.Collections.Generic;
using System.Text;

namespace ChatP2P
{
    class WorkListener
    {
        DatiCondivisi Dati;
        public WorkListener(DatiCondivisi dati)
        {
            Dati=dati;
        }

        public void ProcThread()
        {
            int count = 0;
            string[] s;
            while (Dati.flag)
            {
                if (Dati.getLeghtserver() > count)
                {
                    s = Dati.getserver(count).Split(";");
                    switch (s[0])
                    {
                        case "c":
                            if (!Dati.AspettoRispostaConnesione)
                                if (!Dati.Connesso)
                                {
                                    Dati.VuoleConnetersi = true;
                                    Dati.IpVuoleConnetersi = s[2];
                                    Dati.addclient("C;" + s[1] + "Vuole connettersi, accetti?");
                                }
                            if(s[2]== "127.0.0.1" || s[2]=="localhost")
                            {
                                Dati.Connesso = true;
                                Dati.IpDestinatario= "localhost";
                                Dati.VuoleConnetersi = false;
                                Dati.IpVuoleConnetersi = "";
                                Dati.AspettoRispostaConnesione = false;
                                Dati.addclient("L;localhost");
                            }
                            break;
                        case "y":
                            if (Dati.AspettoRispostaConnesione)
                            {
                                Dati.Connesso = true;
                                Dati.AspettoRispostaConnesione = false;
                                Dati.VuoleConnetersi = false;
                                Dati.IpVuoleConnetersi = "";
                                Dati.AspettoRispostaConnesione = false;
                            }
                            break;
                        case "n":
                            if (!Dati.AspettoRispostaConnesione)
                            {
                                Dati.Connesso = false;
                                Dati.IpDestinatario = "";
                                Dati.VuoleConnetersi = false;
                                Dati.IpVuoleConnetersi = "";
                                Dati.AspettoRispostaConnesione = false;
                            }
                            break;
                        case "m":
                            if (Dati.Connesso)
                            {
                                Dati.addclient(s[1]);
                            }
                            break;
                        case "d":
                            if (Dati.Connesso)
                            {
                                Dati.Connesso = false;
                                Dati.IpDestinatario = "";
                                Dati.VuoleConnetersi = false;
                                Dati.IpVuoleConnetersi = "";
                                Dati.AspettoRispostaConnesione = false;
                            }
                            break;
                    }
                    count++;
                }
            }
        }

    }
}
