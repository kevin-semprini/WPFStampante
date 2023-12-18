using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kevin.semprini._4i.Stampante.Models
{
    public class Stampante
    {
        

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

        //public Stampante()
        //{
        //    Ciano = Magenta = Yellow = Black = 100;
        //    Carta = 0;
        //}

        public Stampante() 
        {
            StreamReader salvacolori = new StreamReader("SalvaDati.csv");

            while (!salvacolori.EndOfStream)
            {
                string temp = salvacolori.ReadLine();
                string[] riga = temp.Split(';');
                if (riga[0] == "c")
                {
                    Ciano = int.Parse(riga[1]);
                }
                else if (riga[0] == "b")
                {
                    Black = int.Parse(riga[1]);
                }
                else if (riga[0] == "y")
                {
                    Yellow = int.Parse(riga[1]);
                }
                else if (riga[0] == "m")
                {
                    Magenta = int.Parse(riga[1]);
                }
                else if (riga[0] == "C")
                {
                    Carta = int.Parse(riga[1]);
                }
            }
        }

        public bool stampa(Pagina page)
        {
            StreamReader salvacolori = new StreamReader("SalvaDati.csv");
            StreamWriter streamWriter = new StreamWriter("SalvaDati.csv");
            string temp = salvacolori.ReadLine();
            string[] riga = temp.Split(';');

            if (Carta >= 1 && Ciano >= page.CostoC && Magenta >= page.CostoM && Yellow >= page.CostoY && Black >= page.CostoB)
            {

                Ciano -= page.CostoC;
                streamWriter.Write(riga);
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


        public int StatoInchiostro(Colore c)
        {
            switch (c)
            {
                case Colore.ciano:
                    return Ciano;
                case Colore.black:
                    return Black;
                case Colore.yellow:
                    return Yellow;
                case Colore.magenta:
                    return Magenta;
            }
            return 0;
        }

        public void SostituisciColore(Colore c)
        {
            switch (c)
            {
                case Colore.ciano:
                    Ciano = 100;
                    return;
                case Colore.black:
                    Black = 100;
                    return;
                case Colore.yellow:
                    Yellow = 100;
                    return;
                case Colore.magenta:
                    Magenta = 100;
                    return;
            }
        }   


    }


}
