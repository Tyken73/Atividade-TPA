using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = new string[5];
            int[] pontos = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome do {0}° time e sua pontuação: ", i+1);
                times[i] = Console.ReadLine();
                pontos[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Time {0}: {1}, {2} pontos", i + 1, times[i], pontos[i]);
            }

            Console.ReadKey();
        }
    }
}
