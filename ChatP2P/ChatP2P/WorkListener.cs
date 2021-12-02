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
            while (true)
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
                            }
                            break;
                        case "y":
                            if (Dati.AspettoRispostaConnesione)
                                Dati.Connesso = true;
                            break;
                        case "n":
                            if (!Dati.AspettoRispostaConnesione)
                            {
                                Dati.AspettoRispostaConnesione = false;
                                Dati.RispostaConnesione = false;
                                Dati.Connesso = false;
                                Dati.IpDestinatario = "";
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
                            }
                            break;
                    }
                    count++;
                }
            }
        }

    }
}
