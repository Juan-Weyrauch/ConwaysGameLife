// Imprimir.cs
using System;
using System.Text;

namespace Program
{
    public static class Imprimir
    {
        public static void ImprimirTablero(bool[,] board)
        {
            int width = board.GetLength(0);
            int height = board.GetLength(1);

            Console.Clear();
            StringBuilder s = new StringBuilder();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (board[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }

            Console.WriteLine(s.ToString());
            
            /*  Aqui modificamos el codigo porque creemos que la invocacion y
                el timepo de espera debe ser responsabilidad del archivo principal 
                'Program.cs'                                                        */
                                              
        }
    }
}