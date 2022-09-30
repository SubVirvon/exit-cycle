using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exit_cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;

            while(isExit == false)
            {
                Console.WriteLine("Для выхода из цикла напишите 'exit'.");
                isExit = "exit" == Console.ReadLine();
            }

            Console.WriteLine("Вы вышли из цикла.");
            Console.ReadKey();
        }
    }
}
