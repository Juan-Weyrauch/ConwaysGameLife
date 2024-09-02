// Logica.cs
using System;

namespace Program
{
    public static class Logica
    {
        public static bool[,] CalcularSiguienteGeneracion(bool[,] gameBoard)
        {
            
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);

            bool[,] cloneBoard = new bool[boardWidth, boardHeight];

            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;

                    // Contar vecinos vivos
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }

                    // Si la célula en sí está viva, se resta 1 al conteo de vecinos vivos
                    if (gameBoard[x, y])
                    {
                        aliveNeighbors--;
                    }

                    // Aplicar reglas del juego
                    if (gameBoard[x, y] && aliveNeighbors < 2)
                    {
                        cloneBoard[x, y] = false; // Muerte por soledad
                    }
                    else if (gameBoard[x, y] && aliveNeighbors > 3)
                    {
                        cloneBoard[x, y] = false; // Muerte por sobrepoblación
                    }
                    else if (!gameBoard[x, y] && aliveNeighbors == 3)
                    {
                        cloneBoard[x, y] = true; // Nace por reproducción
                    }
                    else
                    {
                        cloneBoard[x, y] = gameBoard[x, y]; // Mantiene el estado
                    }
                }
            }

            return cloneBoard;
        }
    }
}
