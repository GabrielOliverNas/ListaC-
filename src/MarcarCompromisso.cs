using System;

namespace ExerciciosPraticos
{
    public class MarcarCompromisso
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }

        public MarcarCompromisso(){
            this.id = 0;
            this.nome = " ";
            this.idade = 0;
        }
    }
}