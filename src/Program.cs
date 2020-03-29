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
            Console.Clear();
            string enganaBuffer, nomePesquisar;
            var listaFeita = new List<CompromissoFeito>();
            var marcarLista = new List<MarcarCompromisso>();
            int escolha = 0;

            Console.WriteLine("Escolha uma opção\n1- adicionar um compromisso\n2- Compromissos ativos\n3- Marcar um compromisso\n4- sair");
            escolha = Console.Read();

            while (escolha != 52)
            {
                while (escolha == 49)
                {
                    Console.Clear();
                    enganaBuffer = Console.ReadLine();
                    Console.WriteLine("- - - - - - - - - - - - - -\nVocê escolheu adicionar um compromisso\n");
                    MarcarCompromisso compromisso = new MarcarCompromisso();
                    Console.WriteLine("Entre com um nome para seu compromisso");
                    compromisso.nome = Console.ReadLine();

                    Console.WriteLine("Entre com uma idade para seu compromisso");
                    compromisso.idade = Console.Read();
                    marcarLista.Add(compromisso);

                    enganaBuffer = Console.ReadLine();
                    Console.WriteLine("Deseja adicionar outro compromisso?\n1- Sim\n2- Não");
                    var escolhaIf = Console.Read();
                    if (escolhaIf != 49)
                    {
                        Console.Clear();
                        enganaBuffer = Console.ReadLine();
                        Console.WriteLine("Escolha uma opção\n1- adicionar um compromisso\n2- Compromissos ativos\n3- Marcar um compromisso\n4- sair");
                        escolha = Console.Read();
                    }
                    else
                    {
                        Console.Clear();
                        escolha = 49;
                    }
                }
                while (escolha == 50)
                {
                    Console.Clear();
                    Console.WriteLine("- - - - - - - -\nSua lista atual");
                    foreach (var elemento in marcarLista)
                    {
                        Console.WriteLine("- - - - - - - - -");
                        Console.WriteLine($"Nome: {elemento.nome}");
                        Console.WriteLine($"Idade: {elemento.idade}");
                    }
                    enganaBuffer = Console.ReadLine();
                    Console.WriteLine("- - - - - - - - -\nDeseja imprimir novamente seus compromissos?\n1- Sim\n2- Não");
                    escolha = Console.Read();
                    if (escolha == 50)
                    {
                        Console.Clear();
                        enganaBuffer = Console.ReadLine();
                        Console.WriteLine("Escolha uma opção\n1- adicionar um compromisso\n2- Compromissos ativos\n3- Marcar um compromisso\n4- sair");
                        escolha = Console.Read();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("- - - - - - - - - - - ");
                        Console.WriteLine("Lista impressa novamente");
                        escolha = 50;

                    }
                }
                while (escolha == 51)
                {
                    Console.Clear();
                    Console.WriteLine("- - - - - - - - - - - - - - - -");
                    //Se esta linha não existir o primeiro dado a inserir na lista irá pegar o buffer anterior e isso trará uma exception
                    enganaBuffer = Console.ReadLine();

                    Console.WriteLine("Qual compromisso você quer marcar como feito?\nEscolha usando o nome");
                    nomePesquisar = Console.ReadLine();
                    var resultado = marcarLista.Where(x => x.nome == nomePesquisar);
                    Console.WriteLine($"\nMarcamos em sua lista como feito: {resultado.First().nome}");

                    listaFeita.Add(new CompromissoFeito
                    {
                        Id = resultado.First().id,
                        nome = resultado.First().nome,
                        idade = resultado.First().idade,
                    });
                    Console.WriteLine("- - - - - - - - - - - - - - - -\nDeseja marcar mais um compromisso?\n1- Sim\n2- Não");
                    escolha = Console.Read();
                    if (escolha == 50)
                    {
                        Console.Clear();
                        enganaBuffer = Console.ReadLine();
                        Console.WriteLine("Escolha uma opção\n1- adicionar um compromisso\n2- Compromissos ativos\n3- Marcar um compromisso\n4- sair");
                        escolha = Console.Read();
                    }
                    else
                    {
                        escolha = 51;

                    }
                }

            }
        }
    }
}
