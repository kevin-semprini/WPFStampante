using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kevin.semprini._4i.Stampante.Models
{
    internal class Stampante
    {

        public enum colore
        {
            C,
            M,
            Y,
            B
        }

        private int ciano;
        private int magenta;
        private int yellow;
        private int black;
        private int carta = 200;

        public int Ciano { get; set; }
        public int Magenta { get; set; }
        public int Yellow { get; set; }
        public int Black { get; set; }
        public int Carta { get; set; }

        

        public bool stampa(Pagina page)
        {
            if (Carta >= 1 && Ciano >= page.CostoC && Magenta >= page.CostoM && Yellow >= page.CostoY && Black >= page.CostoB)
            {
                Ciano -= page.CostoC;
                Magenta -= page.CostoM;
                Yellow -= page.CostoY;
                Black -= page.CostoB;
                Carta--;

                return true;
            }
           
            return false;
        }

        public int StatoCarta()
        {
            return Carta;
        }
        public void aggiungiCarta(int nCarta)
        {
            if  (Carta + nCarta < 200)
            {
                Carta += nCarta;
            }
        }


        public int StatoInchiostro(colore c)
        {
            return 1;
        }

        public void SostituisciColore(colore c)
        {

        }   


    }


}
