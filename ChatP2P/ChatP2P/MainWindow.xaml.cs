using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatP2P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DatiCondivisi Dati;
        private Listener L;
        private WorkListener WL;
        private Writer W;
        private RefreshGrafica RG;
        Thread LT;
        Thread WLT;
        Thread WT;
        Thread RGT;

        public MainWindow()
        {
            Dati = new DatiCondivisi();
            L = new Listener(Dati);
            WL = new WorkListener(Dati);
            W = new Writer(Dati);
            RG = new RefreshGrafica(Dati, this);
            LT = new Thread(new ThreadStart(L.ProcThread));
            WLT = new Thread(new ThreadStart(WL.ProcThread));
            WT = new Thread(new ThreadStart(W.ProcThread));
            RGT = new Thread(new ThreadStart(RG.ProcThread));
            LT.IsBackground = true;
            WLT.IsBackground = true;
            WT.IsBackground = true;
            RGT.IsBackground = false;
            LT.Start();
            WLT.Start();
            WT.Start();
            RGT.Start();
            InitializeComponent();
        }

        private void BTTN_Collegamento_Click(object sender, RoutedEventArgs e)
        {
            Dati.addDaInviare("c;" + "daniel");
            Dati.IpDestinatario = TXT_Destinatario.Text;
            Dati.AspettoRispostaConnesione = true;
            TXT_MDest.Content = "Messaggi ricevut:";
            TXT_MMitt.Content = "Messaggi inviati:";
        }

        private void BTTN_ChiusuraCollegamento_Click(object sender, RoutedEventArgs e)
        {
            Dati.addDaInviare("d;");
            Dati.Connesso = false;
            MessageBox.Show("Ti sei scollegato");

        }

        private void BTTN_Send_Click(object sender, RoutedEventArgs e)
        {
            Dati.addDaInviare("m;" + TXT_Messaggio.Text);
            TXT_MMitt.Content += "\n" + TXT_Messaggio.Text;
        }

        public void addTXT_Destinatario(string s)
        {
            Dispatcher.Invoke(() =>
            {
                TXT_MDest.Content += "\n" + s;
            });
            
        }
        public void RichiediConnessione(string s)
        {
            Dispatcher.Invoke(() =>
            {
                MessageBoxResult result = MessageBox.Show(s, "Richiesta Connessione", MessageBoxButton.YesNo);
                if (result==MessageBoxResult.Yes)
                {
                    Dati.Connesso = true;
                    Dati.IpDestinatario = Dati.IpVuoleConnetersi;
                    Dati.IpVuoleConnetersi = "";
                    Dati.VuoleConnetersi = false;
                    Dati.AspettoRispostaConnesione = false;
                    Dati.addDaInviare("y;Skoro");
                }
                else
                {
                    Dati.addDaInviare("n;");
                }
            });

        }





    }
}
