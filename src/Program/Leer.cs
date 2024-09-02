using System;
using System.IO;

namespace Program
{
    public static class Leer
    {
        public static bool[,] LeerArchivo(string filePath) //Program.cs envia la ruta al .txt
        {
            string content = File.ReadAllText(filePath);
            
            // Dividir el contenido en líneas
            string[] contentLines = content.Split('\n');

            // Inicializar el array board con dimensiones correctas
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            
            //Devuelve el tablero de 'booleanos'
            return board;
        }
    }
}