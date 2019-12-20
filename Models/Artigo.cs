using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Artigo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Título deve ter entre 3 e 60 caracteres!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }

        public Pessoa Pessoa { get; set; }

        [ForeignKey("Pessoa")]
        public int Pessoa_ID { get; set; }
    }
}
