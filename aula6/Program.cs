using System;
using System.IO;

namespace aula6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("!!!Simulação!!!");
            Console.WriteLine("Solicite um valor:");
            double valorEmprestimo = double.Parse(Console.ReadLine());


            if (valorEmprestimo >= 10 && valorEmprestimo <= 100)
            {
                Console.WriteLine("Insira uma taxa:");
                double valorTaxa = double.Parse(Console.ReadLine());
                if (valorTaxa >= 1 && valorTaxa <= 5)
                {

                    double montanteEmprestimoMes = valorEmprestimo;
                    Console.WriteLine(" ");
                    Console.WriteLine("!!!Exportando Simulação!!!");
                    Console.WriteLine(" ");
                    string path = $@"C:\Users\amand\OneDrive\Documentos\texto\{valorEmprestimo}-{ valorTaxa}.text";
                    if (!File.Exists(path))
                    {
                        //Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("=======Início Simulação dia a dia =======");
                            for (int i = 1; i <= 30; i++)
                            {
                                montanteEmprestimoMes = montanteEmprestimoMes + (montanteEmprestimoMes * (valorTaxa / 100));
                                sw.WriteLine(String.Format("Valor de montante calculado para o dia {0} :R$ {1}", i, Math.Round(montanteEmprestimoMes, 2)));


                            }
                            sw.WriteLine("Seu emprestimo de  " + valorEmprestimo + " com taxa de " + valorTaxa + "(Diária) no final de um mês acumula o montante de " + Math.Round(montanteEmprestimoMes, 2) + "a pagar!");
                            sw.WriteLine("=====Fim simulação dia a dia ======");
                            sw.WriteLine(" ");

                            double montanteEmprestimoAno = valorEmprestimo;
                            string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
                            sw.WriteLine("======Início simulação mês a mês ======");
                            for (int i = 0; i < 12; i++)
                            {
                                montanteEmprestimoAno = montanteEmprestimoAno + (montanteEmprestimoAno * (valorTaxa / 100));
                                sw.WriteLine(String.Format("Valor de montate calculado para o mês {0} : R$ {1}", meses[i], Math.Round(montanteEmprestimoAno, 2)));
                            }
                            sw.WriteLine("Seu emprestimo de " + valorEmprestimo + " com taxa de " + valorTaxa + "(Mensal) no final de um ano acumula o montante de " + Math.Round(montanteEmprestimoAno, 2) + " a pagar!");
                            sw.WriteLine("======Fim simulação mês a mês ======");

                        }
                    }
                    Console.WriteLine("Fim Exportação");
                    Console.WriteLine("Simulação realizada com sucesso");

                }
                else
                    Console.WriteLine("Não é possivel realizar essa simulação!");
            }
            else
                    Console.WriteLine("Não é possivel realizar essa simulação");
            
        }
    }
}









