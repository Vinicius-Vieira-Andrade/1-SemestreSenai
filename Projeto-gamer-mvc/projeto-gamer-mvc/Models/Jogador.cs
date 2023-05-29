using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //biblioteca que valida o "Key" para a variavel IdEquipe // data annotation
using System.ComponentModel.DataAnnotations.Schema; //valida a foreign key
using System.Linq;
using System.Threading.Tasks;

namespace projeto_gamer_mvc.Models
{
    public class Jogador
    {
        [Key]
        public int IdJogador { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }

        [ForeignKey("Equipe")] //onde esta a foreign key - na classe Equipe QUAL CLASSE/TABELA EU QUERO USAR
        public int IdEquipe { get; set; }

        public Equipe? Equipe { get; set; } //PROPRIEDADE QUE TEM COMO TIPO A CLASSE EQUIPE

    }
}