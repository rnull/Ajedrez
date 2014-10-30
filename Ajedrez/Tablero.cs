using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Tablero
    {
        private readonly Casilla[,] tablero = new Casilla[9,9];

        public Tablero()
        {
            CreaTablero();
        }

        private void  CreaTablero()
        {
            for (int y = 1; y < 9; y++)
            {
                tablero[y, 0] = new Casilla(Color.Blanco, new String[] {"   ",
                                                             " "+y+
                                                               " ",
                                                             "   ",
                                                             "   " });
            }
            for (int x = 1; x < 9; x++)
            {
                tablero[0, x] = new Casilla(0, new String[] { "      ",
                                                              "  "+x+
                                                                 "   ",
                                                              "      ",
                                                              "      " });
            }
            //for (int i = 'A'; i <= 'H'; i++)
            //{
            //    tablero[(i + 1), 0] = new Casilla(0, new String[] { "  " + (char)i + "  ", "", "", "" });
            //}
            tablero[0, 0] = new Casilla(0, new String[] { "   ", "   ", "   ", "   " });
            for (int j = 1; j < 9; j++)
            {
                if (j % 2 == 0)
                {
                    for (int x = 1; x < 9; x += 2)
                    {
                        tablero[j, x] = new Casilla(Color.Blanco);
                        tablero[j, (x + 1)] = new Casilla(Color.Negro);
                    }
                }
                else
                {
                    for (int x = 1; x < 9; x += 2)
                    {
                        tablero[j, x] = new Casilla(Color.Negro);
                        tablero[j, (x + 1)] = new Casilla(Color.Blanco);
                    }
                }
            }
        }

        public void PintaTablero()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int c = 0; c < 4; c++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        if (x == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(tablero[y, x].Contenido[1]);
                            continue;
                        }

                        if (y == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(tablero[y, x].Contenido[1]);
                            continue;
                        }

                        if (tablero[y, x].Color == Color.Negro)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (tablero[y, x].Color == Color.Blanco)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write(tablero[y, x].Contenido[c]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
