using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTakToeProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] gameBoard = CreateBoard();
            char playerLetter = ChooseLetter();
            Console.WriteLine("Player Choice = "+playerLetter);
            showBoard(gameBoard);
            int getPlayerMove = UserMove(gameBoard); 
        }
        public static char[] CreateBoard()
        {
            char[] gameBoard = new char[10];
            for(int index = 1; index < gameBoard.Length ; index++)
            {
                gameBoard[index] = ' ';
            }
            return gameBoard;
        }
        public static char ChooseLetter()
        {
            Console.WriteLine("Enter your choice (X or O) :");
            string letter = Console.ReadLine();
            if (char.ToUpper(letter[0]) == 'X'  || char.ToUpper(letter[0]) == 'O')
            {
            }
            else
            {
                Console.WriteLine("You entered a invalid entry. ");
                ChooseLetter();
            }
            return char.ToUpper(letter[0]);
        }
        public static void showBoard(char[] board)
        {
            Console.WriteLine( board[1] + " | " + board[2] + " | " + board[3] + "\n-----------\n"
                              + board[4] + " | " + board[5] + " | " + board[6] + "\n----------\n" 
                              + board[7] + " | " + board[8] + " | " + board[9]);
        }
        public static int UserMove(char[] board)
        {
            Console.WriteLine("Enter your position choice from (1-9) : ");
            int index = int.Parse(Console.ReadLine());
            if((index >= 1 && index <= 9 ) && (board[index] == ' ' ))
            {
               
            }
            else
            {
                Console.WriteLine("Invalid entry please try again!");
                UserMove(board);
            }
            return index;
        }
    }
}
