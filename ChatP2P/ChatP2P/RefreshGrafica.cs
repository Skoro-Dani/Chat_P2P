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
            while (true)
            {
                if(Dati.getLeghtclient()>count)
                {
                    Window.addTXT_Destinatario(Dati.getclient(count));
                    count++;
                }
            }
        }
    }
}
