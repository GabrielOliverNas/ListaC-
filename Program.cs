using System;
using System.Collections.Generic;

namespace ExerciciosPraticos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            int escolhaUsuario = 0;
            string nome = " ";
            
            Console.WriteLine("Digite a função desejada\n1- adicionar um evento\n2-imprimir todos os eventos");
            escolhaUsuario = Console.Read();
            //Printando o numero para ver o que entra no console
            Console.WriteLine($"Numero digitado {escolhaUsuario}");

            while (escolhaUsuario != 51)
            {
                Console.WriteLine("======================================");
                nome = adicionaLista();
                lista.Add(nome);
                Console.WriteLine($"Nome adicionado no metodo {nome}");
                nome = " ";

            }

        }
        public static string adicionaLista()
        {
            string nome;
            Console.WriteLine("Iremos adicionar um nome");
            Console.WriteLine("Preciso que digite dados para inserir o primeiro registro:");
            nome = Console.ReadLine();
            return nome;

        }
    }

}
