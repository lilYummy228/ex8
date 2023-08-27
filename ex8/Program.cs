using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = true;
            string word;
            string exitWord = "exit";

            while (isExit)
            {
                Console.Write($"Введите слово {exitWord}: ");
                word = Console.ReadLine();

                if (word == exitWord)
                {
                    isExit = false;
                }
                else
                {
                    Console.WriteLine("Неверное слово!");
                }
            }
        }
    }
}
