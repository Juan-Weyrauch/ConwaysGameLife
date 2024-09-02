// Program.cs
using System;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer el tablero desde un archivo
            string filePath = "board.txt";
            bool[,] gameBoard = Leer.LeerArchivo(filePath);

            // Obtener dimensiones del tablero
            int width = gameBoard.GetLength(0);
            int height = gameBoard.GetLength(1);

            // Bucle principal del juego
            bool iniciar = true;
            while (iniciar)
            {
                // Repite por 20 iteraciones
                for (int i = 0; i < 20; i++)
                {
                    // Imprimir el tablero actual
                    Imprimir.ImprimirTablero(gameBoard);

                    // Calcular la siguiente generación
                    gameBoard = Logica.CalcularSiguienteGeneracion(gameBoard);

                    // Esperar antes de la siguiente iteración
                    Thread.Sleep(300);
                }

                // Solicitar al usuario que ingrese un valor para continuar o no con el juego
                Console.WriteLine("Desea seguir? (S/N) ");
                string seguir = Console.ReadLine().ToUpper(); // Convertir la entrada a mayúsculas para manejar la entrada en cualquier caso
                
                // Validar la respuesta del usuario
                while (seguir != "S" && seguir != "N")
                {
                    Console.WriteLine("Por favor, ingrese una letra válida.");
                    Console.WriteLine("Desea seguir? (S/N) ");
                    seguir = Console.ReadLine().ToUpper(); // Convertir la entrada a mayúsculas para manejar la entrada en cualquier caso
                }

                // Evaluar qué decidió
                if (seguir == "N")
                {
                    iniciar = false;
                }
                
            }
        }
    }
}