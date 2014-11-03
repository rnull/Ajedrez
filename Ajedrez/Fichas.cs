using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Fichas
    {
        public static string[] caballo = new string[4]{
               "  /)",
               "/º )",
               " \\ )",
               "  ()"
            };
        public static string[] peon = new string[4]{
               "#()#",
               "#/\\#",
               "(  )",
               "/__\\"
            };

        public static string[] castillo = new string[4]{
               "|__|",            
               "\\  /",
               "(  )",
               "/__\\"
            };
        public static string[] alfil = new string[4]{
               " ww ",
               " )( ",
               "(  ) ",
               "/__\\ "
            };
        public static string[] rey = new string[4]{
               "wwww",
               "\\  /",
               " )( ",
               "/__\\"
            };
        public static string[] reina = new string[4]{
               " ++ ",
               " /\\ ",
               "(  )",
               "/__\\"
            };
    }
}
