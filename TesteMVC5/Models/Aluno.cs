using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteMVC5.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        
        [DisplayName("Nome Completo")]
        [Required(ErrorMessage ="O Campo {0} é requerido")]
        [EmailAddress (ErrorMessage ="E-mail em formato invalido")]
        public string Name { get; set; }
        
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requerido")]
        public string CPF { get; set; }
        
        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }
        [Required (ErrorMessage ="O campo {0} é Requerido")]
        public String Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas informadas não conferem")]
        public string SenhaConfirmacao{ get; set; }

    }
}