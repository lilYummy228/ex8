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
            bool exitWord = true;
            string word;

            while (exitWord)
            {
                Console.Write("Введите слово exit: ");
                word = Console.ReadLine();

                if (word == "exit")
                {
                    exitWord = false;
                }
                else
                {
                    Console.WriteLine("Неверное слово!");
                }
            }
        }
    }
}
