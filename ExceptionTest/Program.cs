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
            catch(FormatException e)
            {
                Console.WriteLine("Format is 'int': " + e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Number is greater or less than max and min value: " + e.Message);
            }

            Console.WriteLine($"Numero inserido: {i}");
            
            
            
        }
    }
}
