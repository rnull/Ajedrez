using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Casilla
    {
        Color color;
        String[] contenido;

        public Color Color { 
            get {
                return color;
            }
        }

        public string[] Contenido
        {
            set
            {
                contenido = value;
            }
            get
            {
                return contenido;
            }
        }

        public Casilla(Color Color, string[] Contenido)
        {
            this.color = Color;
            this.contenido = Contenido;
        }
        public Casilla(Color Color)
        {
            this.color = Color;
            contenido = new String[] { "      ", "      ", "      ", "      " };
        }
    }
}
