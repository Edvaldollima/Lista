using System;
using System.Collections.Generic;

namespace CriandoLista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var refeicoes = new List<string>();
            var refeicoes1 = new List<string>();

            // caso queira adicionar os elementos de refeicoes em refeicoes1 utiliza-se "AddRange";//
           refeicoes1.AddRange(refeicoes);

            refeicoes.Add("cremedefrango");
            refeicoes.Add("moqueca");
            refeicoes.Add("lasanha");
            refeicoes.Add("panqueca");

            //refeicoes.Clear();  Limpa todos os elementos da lista

            Console.Write("Qual prato deseja pesquisar? ");

            // guarda a cor padrão em cor
            var cor = Console.ForegroundColor;

            // coloca a cor do texto como azul
            Console.ForegroundColor = ConsoleColor.Blue;

            string pratoAPesquisar = Console.ReadLine();

            // volta à cor padrão

            Console.ForegroundColor = cor;

            Console.Write("\nVocê deseja pesquisar o prato ");

            Console.WriteLine(pratoAPesquisar);

            Console.WriteLine($"Pesquisando se na lista tem {pratoAPesquisar}...");
            if (refeicoes.Contains(pratoAPesquisar))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine( $"{pratoAPesquisar} está na lista");
                Console.ForegroundColor = cor;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{pratoAPesquisar} não foi encontrado na lista");
                Console.ForegroundColor = cor;
                Console.Write($"Deseja que adicionemos {pratoAPesquisar} na lista? s/n");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 's')
                {
                    refeicoes.Add(pratoAPesquisar);
                    Console.WriteLine("\nMostrando as refeições: ");
                    foreach (string r in refeicoes)
                    {
                        if (r == pratoAPesquisar)
                        {
                            Console.Write("\tRefeições: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(pratoAPesquisar);
                            Console.ForegroundColor = cor;
                        }
                        else
                        {
                            Console.WriteLine("\tRefeições: {0}", r);
                        }
                        
                    }

                    Console.Write("\nAdicionamos ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(pratoAPesquisar);
                    Console.ForegroundColor = cor;
                    Console.WriteLine(" em nossa lista ...");

                }
                else
                {
                    return ;
                }
            }

            // Mostra as refeições
            //Console.WriteLine("\nMostrando as refeições: ");
            //foreach (string r in refeicoes)
                //Console.WriteLine("\tRefeições: {0}", r);

            Console.ReadLine();

        }
    }
}
