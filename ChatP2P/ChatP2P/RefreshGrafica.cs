using System;
using System.Collections.Generic;
using System.Text;

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
            while (true)
            {
                if(Dati.getLeghtclient()>count)
                {
                    Window.AddTXT_Destinatario(Dati.getclient(count));
                    count++;
                }
            }
        }
    }
}
