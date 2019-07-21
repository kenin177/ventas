using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Direccion { get; set; }

        /*public Cliente(int id, string nombre, int telefono, Ciudad ciudad, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
            Direccion = direccion;

         }*/
    }  
}
