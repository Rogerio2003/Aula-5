using System;
using System.IO;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            Char Acao;
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

            Acao = Convert.ToChar(Console.ReadLine().ToUpper());


            Console.WriteLine();

            while (Acao != 'S')
            {

                switch (Acao)
                {
                    case 'G':
                        P.Gravar(nome, email, Telefone, RG, caminho);
                        break;
                    case 'L':
                        P.Ler(caminho);
                        break;

                }
                Console.WriteLine();

                Console.WriteLine("pressione alguma tecla para continuar");

                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("####################");
                Console.WriteLine("####################");
                Console.WriteLine("G - GRAVAR----------");
                Console.WriteLine("L - LER-------------");
                Console.WriteLine("S - SAIR------------");
                Console.WriteLine("####################");
                Console.WriteLine("####################");
                Console.WriteLine("Digite a operação:");

                Acao = Convert.ToChar(Console.ReadLine().ToUpper());

                Console.WriteLine();
            }
         
        }

        private void Gravar(string nome, string email, string Telefone, string RG, string caminho)
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

            sw.WriteLine("nome:" + nome);

            sw.WriteLine("email:" + email);

            sw.WriteLine("telefone:" + Telefone);

            sw.WriteLine("RG:" + RG);

            sw.Close();

            
        }
        private void Ler( string caminho)
        {
            StreamReader SR = new StreamReader("caminho");


            while (SR.EndOfStream != true)
            {
                Console.WriteLine(SR.ReadLine());
            }
            SR.Close();
        }
    }
}
