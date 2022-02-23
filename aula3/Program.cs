using System;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insíra seu primeiro nome :");
            string primeiroNome = Console.ReadLine();
            Console.WriteLine("insíra seu ultimo nome :");
            string ultimoNome = Console.ReadLine();
            Console.WriteLine("informe sua idade ;");
            string idade = Console.ReadLine();
            Console.WriteLine("informe sua cidade :");
            string cidade = Console.ReadLine();
            Console.WriteLine("nome completo : " + primeiroNome + " " + ultimoNome);
            Console.WriteLine("cidade: " + cidade+ " " + "idade: " + idade);
            Console.ReadKey();
        }
    }
}
