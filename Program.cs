using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            int lenghtSymbolString;
            int borderSymbol = 2;

            Console.Write("Твое имя - \t");
            name = Console.ReadLine();
            Console.Write("Введи любой символ - \t");
            symbol = Convert.ToChar(Console.ReadLine());
            lenghtSymbolString = name.Length+borderSymbol;

            for (int i=0; i< lenghtSymbolString; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
            Console.WriteLine(symbol+name+symbol);

            for (int i = 0; i < lenghtSymbolString; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
