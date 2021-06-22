using System;
using System.Globalization;

namespace DgsDevApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35865;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine(" \n DGSDEV .NEt 2021\n");

            Console.WriteLine(" Hello New World!\n");

            Console.WriteLine(" Aprendendo: C#, .NET 5, Api Rest com Asp.NET Core 5, Entity FrameWork Core 5 e Blazor\n");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(" " + i + "  ----> DGSDEV ITAÚ UNIBANCO 2021 \r");

                Console.ReadLine();

            }

            Console.WriteLine(" Bye Bye! ;)");
            Console.ReadLine();
        }
    }
}
