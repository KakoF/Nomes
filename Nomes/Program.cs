using System;

namespace Nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string primeiroNome = Console.ReadLine();
                string segundoNome = Console.ReadLine();


                Console.WriteLine($"Primeiro nome: {primeiroNome.ToUpper()}");
                Console.WriteLine($"Segundo nome: {segundoNome.ToUpper()}");

                Console.WriteLine($"Quantidade de caracteres do primeiro nome: {primeiroNome.Length}");
                Console.WriteLine($"Quantidade de caracteres do segundo nome: {segundoNome.Length}");

                Console.WriteLine($"Três primeiros caracteres do primeiro nome: {primeiroNome.Substring(0, 3)}");
                Console.WriteLine($"Três primeiros caracteres do segundo nome: {segundoNome.Substring(0, 3)}");
            }
            finally
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
           
        }
    }
}
