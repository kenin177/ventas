using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelo;

namespace Ventas.BL
{
    public class CiudadesBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }

        public CiudadesBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var Ciudad1 = new Ciudad(1, "San Pedro Sula");
            var Ciudad2 = new Ciudad(2, "La Lima");
            var Ciudad3 = new Ciudad(3, "San Manuel");

            ListadeCiudad.Add(Ciudad1);
            ListadeCiudad.Add(Ciudad2);
            ListadeCiudad.Add(Ciudad3);
        }
    }
}
