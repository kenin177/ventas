using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public abstract class Aves: animal
    {
        public bool PuedeVolar { get; set; }
        public string Dieta { get; set; }
        public string Migracion { get; set; }

    }
}
