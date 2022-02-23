using System;

namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int digite = Convert.ToInt32(Console.ReadLine());
            if(digite % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }   

           

             
    }
}
