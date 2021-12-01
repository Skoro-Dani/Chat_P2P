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
        Thread LT;
        Thread WLT;
        Thread WT;


        public MainWindow()
        {
            InitializeComponent();
            Dati = new DatiCondivisi();
            L = new Listener(Dati);
            WL = new WorkListener(Dati);
            W = new Writer(Dati);
            LT = new Thread(new ThreadStart(L.ProcListener));
            WLT = new Thread(new ThreadStart(WL.ProcWorkListener));
            WT = new Thread(new ThreadStart(W.ProcThread));
            LT.IsBackground = true;
            WLT.IsBackground = true;
            WT.IsBackground = true;
            LT.Start();
            WLT.Start();
            WT.Start();
            
        }

        private void BTTN_Collegamento_Click(object sender, RoutedEventArgs e)
        {
            Dati.addDaInviare("c;" + "daniel");
            Dati.IpDestinatario = TXT_Destinatario.Text;
            Dati.AspettoRispostaConnesione = true;
        }

        private void BTTN_ChiusuraCollegamento_Click(object sender, RoutedEventArgs e)
        {
            Dati.addDaInviare("d;");
            Dati.Connesso = false;
        }

        private void BTTN_Send_Click(object sender, RoutedEventArgs e)
        {
            Dati.addDaInviare("m;" + TXT_Messaggio.Text);
        }
    }
}
