using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Por favor, preencha o nome!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="Nome deve ter entre 3 e 60 caracteres!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Por favor, preencha o e-mail!")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Email deve ter entre 5 e 60 caracteres!")]
        [Display(Name = "E-mail")]             
        [EmailAddress (ErrorMessage = "Por favor, insira um endereço de e-mail válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Por favor, preencha a senha!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="Senha deve ter entre 3 e 60 caracteres!")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }


        public List<Artigo> Artigos { get; } = new List<Artigo>();


      
    }
}
