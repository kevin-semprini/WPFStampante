using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kevin.semprini._4i.Stampante.Models
{
    public class Pagina
    {
        private int _ciano;
        private int _magenta;
        private int _yellow;
        private int _black;

        public int CostoC 
        {
            get
            {
                return _ciano;
            }
            set
            {
                if (value < 3) 
                {
                    throw new ArgumentException("caca pupu");
                } else
                {
                    CostoC = value;
                }
            } 
        }
        public int CostoM { get => _magenta; set => _magenta = value; }
        public int CostoY { get => _yellow; set => _yellow = value; }
        public int CostoB { get => _black; set => _black = value; }



        public Pagina(int coloreM, int coloreB, int coloreY, int coloreC)
        {
            if (!(coloreM > 3 && coloreB > 3 && coloreC > 3 && coloreY > 3))
            {
                CostoC = coloreC;
                CostoB = coloreB;
                CostoY = coloreY;
                CostoM = coloreM;
            }
            else
            {
                throw new Exception();
            }
        }

        public Pagina()
        {
            Random rnd = new Random();
            CostoB = rnd.Next(0, 5);
            CostoY = rnd.Next(0, 5);
            CostoM = rnd.Next(0, 5);
            CostoC = rnd.Next(0, 5);
        }








    }


}
