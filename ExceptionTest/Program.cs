using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere um numero inteiro:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numero inserido: {i}");
        }
    }
}
