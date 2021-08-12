using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Shared
{
    public class Annotation
    {
        [Required(ErrorMessage = "The Address field is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        [MaxLength(10, ErrorMessage = "The Name field must not contain more than 10 chars.")]
        [MinLength(3, ErrorMessage = "The Name field must contain at least 3 chars.")]
        public string Name { get; set; }
    }
}
