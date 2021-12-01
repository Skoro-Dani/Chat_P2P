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

        public void ProcWorkListener()
        {
            int count = 0;
            string[] s;
            while (true)
            {
                if (Dati.getLeghtserver() > 0)
                {
                    s = Dati.getserver(count).Split(";");
                    switch (s[0])
                    {
                        case "c":
                            if (!Dati.AspettoRispostaConnesione)
                                if (!Dati.Connesso)
                                {
                                    Dati.VuoleConnetersi = true;
                                    Dati.IpVuoleConnetersi = s[1];
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
                            }
                            break;
                    }
                    count++;
                }
            }
        }

    }
}
