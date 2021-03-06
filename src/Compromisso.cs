using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosPraticos
{
    class Compromisso
    {
        public string nome { get; set; }

        public Compromisso()
        {
            this.nome = nome;
        }
        public List<Compromisso> compromisso = new List<Compromisso>();
        public List<CompromissoFeito> compromissoFeito = new List<CompromissoFeito>();


        public void Adicionar()
        {

            Boolean escolha = true;

            while (escolha == true)
            {
                Console.WriteLine("Você deseja adicionar outros registros?\n1 Sim\n2 Não");
                var varAux = int.Parse(Console.ReadLine());
                if (varAux == 1)
                {
                    Console.Clear();
                    Console.WriteLine("- - - - - - - - - -");
                    Console.WriteLine("Digite um nome para o compromisso");
                    var nomeEntrada = Console.ReadLine();
                    compromisso.Add(new Compromisso
                    {
                        nome = nomeEntrada,
                    });
                }
                else
                {
                    escolha = false;
                }
            }
            escolha = true;
            while (escolha == true)
            {
                CompromissoFeito addCompromisso = new CompromissoFeito();
                try
                {
                    Console.WriteLine("Qual nome você quer procurar?");
                    var procuraNome = Console.ReadLine();
                    var resultado = compromisso.Where(x => x.nome == procuraNome);

                    Console.WriteLine($"\nEncontramos o nome na lista {resultado.First().nome}");

                    compromissoFeito = addCompromisso.completaVetor(resultado.First().nome, compromissoFeito);

                    Console.WriteLine("Deseja procurar outro nome?\n1- Sim\n2- Não");
                    var varAux = int.Parse(Console.ReadLine());

                    if (varAux == 2)
                    {
                        addCompromisso.imprimeLista(compromissoFeito);
                        escolha = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Nome não encontrado! Digite outro nome");
                }
            }
        }
    }
}