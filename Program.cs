using System;
using System.Collections.Generic;
using System.Linq;

namespace estruturaDeDados
{

    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<int, aula> dict1 = new Dictionary<int, aula>();


            string opcaoEscolhida = Opcoes().ToUpper();
            var indice = 1;
            var totalLista = indice;
            while (opcaoEscolhida != "X")
            {
                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.WriteLine("Escreva um nome");
                        var cadastro = Console.ReadLine();
                        dict1.Add(indice, new aula(cadastro));
                        indice++;
                        totalLista++;
                        break;
                    case "2":
                        var indiceLista = 1;

                        while (indiceLista <= totalLista)
                        {
                            var full = dict1.Where(x => x.Key == indiceLista).FirstOrDefault();

                                if (full.Value != null)
                                Console.WriteLine($"Chave: {indiceLista}\nNome: {full.Value.Nome}\nMatricula: {full.Value.Matricula}\n");
                                indiceLista++;


                            
                        }
                        break;
                    case "3":


                        Console.WriteLine("Pesquisar chave");
                        var Pesquisa = Console.ReadLine();
                        var PesquisaC = Convert.ToInt32(Pesquisa);



                        if (dict1.ContainsKey(PesquisaC))
                        {
                            aula aula;
                            var b = dict1.TryGetValue(PesquisaC, out aula);
                            Console.WriteLine(aula.Nome);
                        }

                        break;
                    case "4":
                        Console.WriteLine("Pesquisar chave");
                        var Pesquisar = Console.ReadLine();
                        var PesquisaR = Convert.ToInt32(Pesquisar);
                        if (dict1.ContainsKey(PesquisaR))
                        {
                            aula aula;
                            var b = dict1.TryGetValue(PesquisaR, out aula);
                            dict1.Remove(PesquisaR);


                        }



                        break;

                    default:
                        break;
                }
                opcaoEscolhida = Opcoes().ToUpper();
            }


        }

        private static string Opcoes()
        {
            Console.WriteLine();
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Listar");
            Console.WriteLine("3- Proucurar");
            Console.WriteLine("4- Remover");
            var opcaoEscolhida = Console.ReadLine();
            return opcaoEscolhida;
        }
    }
}
