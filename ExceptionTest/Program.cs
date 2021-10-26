using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            
            Console.WriteLine("Insere um numero inteiro:");
            try
            {
                i = int.Parse(Console.ReadLine());
                
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Format is 'int': " + e.Message);
            }

            Console.WriteLine($"Numero inserido: {i}");
            
            
            
        }
    }
}
