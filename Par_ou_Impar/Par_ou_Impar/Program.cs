using System;

namespace Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDigite um número para validar se é par ou ímpar: \n");
            int a = int.Parse(Console.ReadLine());

            if(0 == a % 2)
            {
                Console.WriteLine( a + " É um número Par");
            }
            
           else
            {
                Console.WriteLine(a + " É um número IMPAR");
            }
        }
    }
}
