using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasAjedrez
{
    public class Reglas
    {
        private enum Tipo
        {
            Rey,
            Reina,
            Alfil,
            Caballo,
            Torre,
            Peon
        }

        private enum Color
        {
            Blanco,
            Negro
        }

        public static bool ValidaMovimiento(int xOrigen, int yOrigen, int xDestino, int yDestino, int color, int ficha)
        {
            switch (ficha)
            {
                case 5:
                    return ValidaPeon(xOrigen, yOrigen, xDestino, yDestino, color);
                    break;
            }
            return false;
        }

        private static bool ValidaPeon(int xOrigen, int yOrigen, int xDestino, int yDestino, int color)
        {
            if (color == 0) //blanco
            {
                if (yOrigen == 7)
                {
                    if (yDestino == 6 || yDestino == 5)
                    {
                        return true;
                    }
                }

                if ((yOrigen - 1) == yDestino)
                {
                    return true;
                }
            }

            if (color == 1) //negro
            {
                if (yOrigen == 2)
                {
                    if (yDestino == 3 || yDestino == 4)
                    {
                        return true;
                    }
                }

                if ((yOrigen + 1) == yDestino)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidaRey(int xOrigen, int yOrigen, int xDestino, int yDestino, int color)
        {
            if (color == 0 || color == 1)
            {
                if (((yOrigen + 1) == yDestino) || ((yOrigen - 1) == yDestino)) {return true; }
                if (((xOrigen + 1) == xDestino) || ((xOrigen - 1) == xDestino)) {return true;}
                if (xOrigen + 1 == xDestino && yOrigen + 1 == yDestino) { return true; }
                if (xOrigen - 1 == xDestino && yOrigen - 1 == yDestino) { return true; }
                if (xOrigen + 1 == xDestino && yOrigen - 1 == yDestino) { return true; }
                if (xOrigen - 1 == xDestino && yOrigen + 1 == yDestino) { return true; }
            }
            return false;
        }

        private static bool ValidaTorre(int xOrigen, int yOrigen, int xDestino, int yDestino, int color) 
        {
            if(xOrigen)
            
            return false;
        }
    }
}
