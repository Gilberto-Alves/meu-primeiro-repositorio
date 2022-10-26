using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="O nome é obrigatorio!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "O E-mail é obrigatorio!")]
        [EmailAddress(ErrorMessage = "O E-mail é inválido!")]
        public string Email { get; set; }
    }
}