using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public List<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Productos>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var Cliente1 = new Clientes(1, "Kevin");
            var Cliente2 = new Clientes(2, "Christian");

            var Producto1 = new Productos(1, "Computadora Dell", 13850, Cliente1);
            var Producto2 = new Productos(2, "Pantalla 4k", 4500, Cliente1);
            var Producto3 = new Productos(3, "Teclado Logitech", 600, Cliente2);

            ListadeProductos.Add(Producto1);
            ListadeProductos.Add(Producto2);
            ListadeProductos.Add(Producto3);
        }
    }
}
