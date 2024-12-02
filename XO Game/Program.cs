using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO_Game
{
    internal class Program
    {
        
        static List<List<char>> XOGrid = new List<List<char>>()
        {
            new List<char> { '1','2','3'},
            new List<char> { '4','5','6'},
            new List<char> { '7','8','9'}
        };
        
        const char Player1Choice = 'X';
        const char Player2Choice = 'O';

        static void ShowX0Grid()
        {
            foreach (List<char> row in XOGrid)
            {
                Console.Write(" ");

                foreach (char c in row) Console.Write($"{c}|");

                Console.WriteLine("\n ------");
            }

        }

        static int ReadPlayerTurnPosition(string msg)
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine());
        }

        static void PutPlayerChoiceInXOGrid(int Position,char choice)
        {
            switch (Position)
            {
                case 1:
                    {
                        XOGrid[0][0] = choice;
                        break;
                    }
                case 2:
                    {
                            XOGrid[0][1] = choice;
                            break;
                    }
                case 3:
                    {
                            XOGrid[0][2] = choice;
                            break;
                    }
                case 4:
                    {
                        XOGrid[1][0] = choice;
                        break;
                    }

                case 5:
                    {
                        XOGrid[1][1] = choice;
                        break;
                    }
                case 6:
                    {
                        XOGrid[1][2] = choice;
                        break;
                    }
                case 7:
                    {
                        XOGrid[2][0] = choice;
                        break;
                    }
                case 8:
                    {
                        XOGrid[2][1] = choice;
                        break;
                    }
                case 9:
                    {
                        XOGrid[2][2] = choice;
                        break;
                    }
                default:
                    Console.WriteLine("\a");
                    break;

            }
        }
        
        static bool DiagonalWin(char XOchoice)
        {
            return (XOGrid[0][0] == XOchoice && XOGrid[1][1] == XOchoice && XOGrid[2][2] == XOchoice) || (XOGrid[0][2] == XOchoice && XOGrid[1][1] == XOchoice && XOGrid[2][0] == XOchoice);
        }

        static bool HorizontalWin(char XOchoice)
        {
            return (XOGrid[0][0] == XOchoice && XOGrid[0][1] == XOchoice && XOGrid[0][2] == XOchoice) || (XOGrid[1][0] == XOchoice && XOGrid[1][1] == XOchoice && XOGrid[1][2] == XOchoice) || (XOGrid[2][0] == XOchoice && XOGrid[2][1] == XOchoice && XOGrid[2][2] == XOchoice);
        }

        static bool VerticalWin(char XOchoice)
        {
            return (XOGrid[0][0] == XOchoice && XOGrid[1][0] == XOchoice && XOGrid[2][0] == XOchoice) || (XOGrid[0][1] == XOchoice && XOGrid[1][1] == XOchoice && XOGrid[2][1] == XOchoice) || (XOGrid[0][2] == XOchoice && XOGrid[1][2] == XOchoice && XOGrid[2][2] == XOchoice);
        }

        static bool isWinner(char choice)
        {
            return VerticalWin(choice) || HorizontalWin(choice) || DiagonalWin(choice);
        }

        static bool isDraw()
        {
            foreach(List<char> row in XOGrid)
            {
                foreach(char c in row)
                {
                    if (char.IsDigit(c)) return false;
                }
            }
            return true;
        }
        
        public static void StartXOGame()
        {
            int Counter = 0;
            while(true)
            {
                Counter++;
                ShowX0Grid();
                
                if (isDraw())
                {
                    Console.WriteLine("No Winner in this Game");
                    break;
                }

                if(Counter % 2 != 0)
                {
                    PutPlayerChoiceInXOGrid(ReadPlayerTurnPosition("Ahmed turn!"),Player1Choice);
                    
                    if(isWinner(Player1Choice))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ahmed is the Winner in this Game");
                        Console.WriteLine("Mokhtar Ya 5obzti hhhh :-)");
                        break;
                    }
                }else
                 {
                    
                    PutPlayerChoiceInXOGrid(ReadPlayerTurnPosition("Mokhtar turn!"), Player2Choice);
                    
                    if (isWinner(Player2Choice))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Green; 
                        Console.WriteLine("Mokhtar is the Winner in this Game");
                        break;
                    }
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("I wish you have fun with my XO Game");
        }
        
        
        static void Main(string[] args)
        {
            StartXOGame();


            Console.ReadKey();
        }
    }
}
