using System;
namespace TicTakToeProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] gameBoard = CreateBoard();
        }
        public static char[] CreateBoard()
        {
            char[] gameBoard = new char[10];
            for(int index = 0; index < 10; index++)
            {
                gameBoard[index] = ' ';
            }
            return gameBoard;
        }
    }
}
