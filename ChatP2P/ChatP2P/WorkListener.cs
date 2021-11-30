using System;
using System.Collections.Generic;
using System.Text;

namespace ChatP2P
{
    class WorkListener
    {
        List<string> Buffer = new List<string>();
        DatiCondivisi Dati;
        public WorkListener(DatiCondivisi dati)
        {
            Dati=dati;
        }

        public void ProcWorkListener()
        {
            int count = 0;
            string []s;
            while(true)
            {
                if(Buffer.Count > count)
                {
                    count++;
                    s = Buffer[count].Split(";");
                    if(s[0]=="c")
                    {
                        if(!Dati.getConnesso())
                        {
                            if(!Dati.getAspettoRisposta())
                            {
                                Dati.setVuoleConn(true);
                                Dati.setIpDestinatario(s[1]);
                            }
                        }

                    }
                }
            }
        }

        public void AddStringtoBuffer(string s)
        {
           Buffer.Add(s);
        }
    }
}
