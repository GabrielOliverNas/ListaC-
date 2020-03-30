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
        public List<CompromissoFeito> completaVetor(string nomeValido, List<CompromissoFeito> compromissoFeito)
        {
            compromissoFeito.Add(new CompromissoFeito
            {
                nome = nomeValido,
            });
            return compromissoFeito;
        }
        public void imprimeLista(List<CompromissoFeito> compromissoFeito)
        {
            foreach (var item in compromissoFeito)
            {
                Console.WriteLine(item.nome);
            }
        }

    }
}