using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelo;

namespace Ventas.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var Ciudad1 = new Ciudad(1, "San Pedro Sula");
            var Ciudad2 = new Ciudad(2, "La Lima");
            var Ciudad3 = new Ciudad(3, "San Manuel");

            var Cliente1 = new Cliente("Kevin", 01, 98616372, "miguel Angel Pavon", Ciudad1);
            var Cliente3 = new Cliente("Christian", 02, 99896547, "Barrio El Cento", Ciudad2);
            var Cliente2 = new Cliente("Jason", 03, 97524896, "Col. Reyes Caballero", Ciudad3);

            ListadeClientes.Add(Cliente1);
            ListadeClientes.Add(Cliente2);
            ListadeClientes.Add(Cliente3);

        }
    }
}
