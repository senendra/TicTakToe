using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTakToeProgram
{
    class Program
    {
        public const int HEAD = 1;
        public static void Main(string[] args)
        {
            char[] gameBoard = CreateBoard();
            char playerLetter = ChooseLetter();
            char computerLetter = ComputerLetter(playerLetter);
            Console.WriteLine("Player Letter = "+playerLetter+"\nComputer Letter = "+computerLetter);
            showBoard(gameBoard);
            string whoPlayFirst = WhoPlayFirst();
            Console.WriteLine(whoPlayFirst+" will play first");
            int getPLayerMove = UserMove(gameBoard);
            PlayerMoveFilling(gameBoard, getPLayerMove, playerLetter);
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
                return char.ToUpper(letter[0]);
            }
            else
            {
                Console.WriteLine("You entered a invalid entry. ");
                return ChooseLetter();
            }  
        }
        public static char ComputerLetter(char letter)
        {
            if(letter == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
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
            if(index >= 1 && index <= 9  && FreeSpace(board, index) )
            {
                return index;
            }
            else
            {
                Console.WriteLine("Invalid entry please try again!");
                 return UserMove(board);
            } 
        }
        public static bool FreeSpace(char[] board, int index)
        {
            if(board[index] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PlayerMoveFilling(char[] board, int index, char letter)
        {
           board[index] = letter;
        }
        public static string WhoPlayFirst()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if(toss == HEAD)
            {
                
                return "Player";
            }
            else
            {
               
                return "Computer";
            }
        }
    }
}
