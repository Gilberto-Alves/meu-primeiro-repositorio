using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class EditorCategoryViewModel
    {   
        [Required(ErrorMessage = "O nome é obrigatorio")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 a 40 caractere")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O slug é obrigatorio")]
        public string Slug { get; set; }
    }
}