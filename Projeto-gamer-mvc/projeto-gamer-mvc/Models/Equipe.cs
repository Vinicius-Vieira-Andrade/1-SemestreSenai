using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //biblioteca que valida o "Key" para a variavel IdEquipe // data annotation
using System.Linq;
using System.Threading.Tasks;

namespace projeto_gamer_mvc.Models
{
    public class Equipe
    {
        [Key] //primeira anotaçao/propriedade a baixo(no caso IdEquipe) que está com a anotacao(key) as outras não
        public int IdEquipe { get; set; } //data annotation - valida como primary key
        //entity framework gerar tabelas no banco de dados a partir do codigo / code first PESQUISAR
        public string? Nome { get; set; }
        public string? Imagem { get; set; }
        public ICollection<Jogador>? Jogador {get; set; } //referencia da IdEquipe da classe jogador // ICollection é tipo uma lista
    }
}