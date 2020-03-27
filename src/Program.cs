using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ExerciciosPraticos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomePesquisar;
            int escolha;
            var lista = new List<Compromisso>();

            lista.Add(new Compromisso
            {
                Id = 1,
                nome = "Gabriel",
                idade = 17,

            });
            lista.Add(new Compromisso
            {
                Id = 2,
                nome = "Maicon",
                idade = 19,

            });
            lista.Add(new Compromisso
            {
                Id = 3,
                nome = "Jose",
                idade = 30,

            });

            Console.WriteLine("Deseja listar antes de selecionar?\n1-Sim\n2-Não");
            escolha = Console.Read();
            while (escolha != 51)
            {
                if (escolha == 50)
                {
                    Console.WriteLine("Qual compromisso você quer marcar?");
                    nomePesquisar = Console.ReadLine();
                    var resultado = lista.Where(x => x.nome == nomePesquisar);
                    Console.WriteLine($"Sua pesquisa gerou esse resultado {resultado.First().nome}");
                }
                else
                {
                    Console.WriteLine("==============================");
                    foreach (var elemento in lista)
                    {
                        Console.WriteLine(elemento.nome);
                    }
                    Console.WriteLine("Deseja imprimir novamente?\n1-Sim\n2-Não");

                }
            }

        }
    }
}
