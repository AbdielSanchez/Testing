using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Shared
{
    public class SubarrayForm
    {
        [Required(ErrorMessage = "Campo requerido")]
        [MinLength(2, ErrorMessage = "The Name field must contain at least 3 chars.")]
        public string arr { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string k { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string s;
    }
}
