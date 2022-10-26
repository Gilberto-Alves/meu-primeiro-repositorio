using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage ="E-mail invalido")]
        public string Email {get; set ;}

        [Required(ErrorMessage = "Informe um senha")]
        public string Password {get ; set;}
    }
}