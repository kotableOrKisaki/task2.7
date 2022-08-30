using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbolString = null;
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
                symbolString += symbol;
            }

            Console.WriteLine(symbolString);
            Console.WriteLine(symbol+name+symbol);
            Console.WriteLine(symbolString);
        }
    }
}
