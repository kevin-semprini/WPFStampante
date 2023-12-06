using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace kevin.semprini._4i.Stampante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
                                //        Classe "Stampante" 
                                //- 4 serbatoi di colore: CMYB e un cassetto di fogli(tutte property int)
                                //- un metodo bool Stampa(Pagina p) (che torna false, se l'inchiostro non è sufficiente per stampare)
                                //- un metodo int StatoInchiostro(Colore c) che torna la quantità di inchiostro presente nei 4 serbatoi.
                                //- un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
                                //- un metodo void SostituisciColore(Colore c) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
                                //- un metodo void AggiungiCarta(int qta) che aggiunge fogli fino ad un max di 200

                                //Classe "Pagina" 
                                //- 4 attributi CMYB che, se usata per stampare, consuma i serbatoi della stampante.
                                //- un costruttore che accetta colori specifici al massimo di valore 3
                                //- un costruttore che crea una Pagina con colori random

                                //Enum Colore

                                //Realizzare un programma WPF che utilizzi le classi appena modellate

                                //Consegnare sul proprio github in un repository chiamato "WPFStampante"
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
