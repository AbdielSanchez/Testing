using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Shared
{
    public class Propiedad
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public TipoDePropiedad Tipo { get; set; }
        public int Precio { get; set; }
        public string Ubicacion { get; set; }
    }
}
