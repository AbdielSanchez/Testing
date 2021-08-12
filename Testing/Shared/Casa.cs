using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Shared
{
    public class Casa : Propiedad
    {
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Restrooms { get; set; }
        public int Parking { get; set; }
    }
}
