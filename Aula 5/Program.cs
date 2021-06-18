using System;
using System.IO;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Acao;
            string caminho = "usuario. txt";
            string nome = "", email = "", Telefone = "", RG = "";

            Console.WriteLine("####################");
            Console.WriteLine("####################");
            Console.WriteLine("G - GRAVAR----------");
            Console.WriteLine("L - LER-------------");
            Console.WriteLine("S - SAIR------------");
            Console.WriteLine("####################");
            Console.WriteLine("####################");
            Console.WriteLine("Digite a operação:");

            Acao = (Console.ReadLine().ToUpper());
            {
                Console.WriteLine();

                while (Acao != "s")
                {

                    if (Acao == "G")
                    {

                        Console.WriteLine("Informe seu nome");

                        nome = Console.ReadLine();

                        Console.WriteLine("Informe seu email");

                        email = Console.ReadLine();

                        Console.WriteLine("Informe seu telefone");

                        Telefone = Console.ReadLine();

                        Console.WriteLine("Informe seu RG");

                        RG = Console.ReadLine();

                        StreamWriter sw = new StreamWriter(caminho, true);

                    }





                }
            }

        }
    }
}
