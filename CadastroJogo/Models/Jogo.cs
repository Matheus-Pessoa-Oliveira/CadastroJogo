using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace CadastroJogo.Models
{
    public class Jogo 
    {
        // GET: Jogo
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A versão do jogo é necessária.")]
        public int Versao { get; set; }

        [Required(ErrorMessage = "Insira o desenvolvedor do jogo!")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Informe o desenvolvedor com no minímo 3 caracteres a 200.")]
        public string Desenvolvedor { get; set; }

        [Required(ErrorMessage = "Informe o gênero do jogo!")]
        public string Genero { get; set; }

        [Range(12, 100, ErrorMessage = "Idade permitida entre 12 a 100 anos!")]
        [Required(ErrorMessage = "Introduza a faixa etária recomendada.")]
        public int FaixaEt { get; set; }

        [Range(1958, 2021, ErrorMessage = "O ano de lançamento do jogo parte de 1958 a 2021.")]
        [Required(ErrorMessage = "Insira o ano de lançamento do jogo.")]
        public int AnoLanc { get; set; }
    }
}