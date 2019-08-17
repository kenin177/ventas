using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public abstract class Mamifero: animal
    {
        public string TipoAlimentacion { get; set; }
        public int Patas { get; set; }
    }
}
