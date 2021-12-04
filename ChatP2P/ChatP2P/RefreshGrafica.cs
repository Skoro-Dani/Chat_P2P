using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace ChatP2P
{
    public class RefreshGrafica
    {
        DatiCondivisi Dati;
        MainWindow Window;
        public RefreshGrafica(DatiCondivisi dati,MainWindow d)
        {
            Dati = dati;
            Window = d;
        }

        public void ProcThread()
        {
            int count = 0;
            string s = "";
            string[] ss;
            while (Dati.flag)
            {
                if(Dati.getLeghtclient()>count)
                {
                    s = Dati.getclient(count);
                    ss = s.Split(";");
                    if (ss[0] == "C")
                    {
                        Window.RichiediConnessione(ss[1]);
                    }
                    else if(ss[0] == "L")
                    {
                        Window.Richiesta_ccettazioneConn();
                    }else
                    {
                        Window.addTXT_Destinatario(ss[0]);
                    }
                    count++;
                }
            }
        }
    }
}
