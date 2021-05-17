using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<Pessoa> pessoas = new LinkedList<Pessoa>();

            string opcaoEscolhida = opcoes();

            while (opcaoEscolhida != "X")
            {
                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Digite o nome");
                        var nome = Console.ReadLine().ToUpper();

                        Console.WriteLine();
                        Console.WriteLine("Digite a idade");
                        var idade = Console.ReadLine();

                        pessoas.AddLast(new Pessoa(nome, idade));


                        break;
                    case "2":
                        foreach (var pessoa in pessoas)
                        {
                            Console.WriteLine(pessoa.Nome, pessoa.Idade);
                        }
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome");
                        var pesquisa = Console.ReadLine().ToUpper();

                        foreach (var pessoa in pessoas)
                        {
                            if (pessoa.Nome == pesquisa)
                            {
                                Console.WriteLine($"{pessoa.Nome} {pessoa.Idade} anos ");
                            }
                        }
                        break;
                    case "4": // adcionar anterior
                        
                        
                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome que sera subsequente");
                        var pesquisaSubsequente = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite o Nome que sera subsequente");
                        var pesquisaidadeSubsequente = Console.ReadLine().ToUpper();
                        var pesquisapessoaSubsequente = new Pessoa(pesquisaSubsequente, pesquisaidadeSubsequente);
                        
                        var pessoaSubsequente = new LinkedListNode<Pessoa>(pesquisapessoaSubsequente);


                    


                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome que sera anterior");
                        var adcionarNomeAnterior = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite a idade ");
                        var adcionarIdadeAnterior = Console.ReadLine().ToUpper();
                        var pessoaAnterior = new Pessoa (adcionarNomeAnterior, adcionarIdadeAnterior);
                        pessoas.AddBefore(pessoaSubsequente.Next, pessoaAnterior);
                        



                        break;
                    default:
                        break;
                }
                opcaoEscolhida = opcoes();
            }



        }

        private static string opcoes()
        {
            Console.WriteLine();
            Console.WriteLine("1- Inserir pessoa");
            Console.WriteLine("2- Listar Pessoas");
            Console.WriteLine("X- Sair");
            var opcaoEscolhida = Console.ReadLine().ToUpper();
            return opcaoEscolhida;
        }
    }
}
