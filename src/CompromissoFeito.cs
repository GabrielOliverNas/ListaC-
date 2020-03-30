using System;
using System.Collections.Generic;

namespace ExerciciosPraticos
{
    class CompromissoFeito 
    {
        public string nome { get; set; }
        public string nomeValido { get; set; }
        public CompromissoFeito()
        {
            this.nome = nome;
        }
        public void completaVetor(string nomeValido)
        {
            var compromisso = new List<CompromissoFeito>();
            compromisso.Add(new CompromissoFeito
            {
                nome = nomeValido,
            });
        }
        public void imprimeNomeValido()
        {
            foreach (var elemento in compromisso)
            {
                Console.WriteLine("- - - - - - - - -");
                Console.WriteLine($"Nome: {elemento.nome}");
            }
        }
    }
}