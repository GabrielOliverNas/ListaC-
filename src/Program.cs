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
            var listaFeita = new List<CompromissoFeito>();
            var marcarLista = new List<MarcarCompromisso>();
            int idAtual = 0, quantidadeCompromisso = 0;

            Console.WriteLine("Quandos compromissos voce quer adicionar?");
            quantidadeCompromisso = Console.Read();

            for (var i = 0; i < quantidadeCompromisso; i++)
            {
                Console.WriteLine("Entre com um nome para seu compromisso");
                string nomeAdd = Console.ReadLine();

                Console.WriteLine("Entre com uma idade para seu compromisso");
                int idadeAdd = Console.Read();


                marcarLista.Add(new MarcarCompromisso
                {
                    id = idAtual +1,
                    nome = nomeAdd,
                    idade = idadeAdd,
                });
            }


            Console.WriteLine("Sua lista atual");
            foreach (var elemento in marcarLista)
            {
                Console.WriteLine($"Id: {elemento.id}");
                Console.WriteLine($"Nome: {elemento.nome}");
                Console.WriteLine($"Idade: {elemento.idade}");
                Console.WriteLine("- - - - - -");
            }
            Console.WriteLine("=========================");
            Console.WriteLine("Qual compromisso você quer marcar como feito?\nEscolha usando o nome");
            nomePesquisar = Console.ReadLine();
            var resultado = marcarLista.Where(x => x.nome == nomePesquisar);
            Console.WriteLine($"Marcamos em sua lista como feito: {resultado.First().nome}");

            listaFeita.Add(new CompromissoFeito
            {
                Id = resultado.First().id,
                nome = resultado.First().nome,
                idade = resultado.First().idade,
            });
        }
    }
}
