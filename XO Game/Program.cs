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

        static void Main(string[] args)
        {
            ShowX0Grid();
            Console.ReadKey();
        }
    }
}
