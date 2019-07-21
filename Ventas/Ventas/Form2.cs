using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CIUDAD
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro Sula";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Progreso";

            //CLIENTES
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Cecilia Garcia";
            cliente1.Telefono = 98616989;
            cliente1.Ciudad = ciudad1;
            cliente1.Direccion = "Bol. El Centro";

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Kevin Rivera";
            cliente2.Telefono = 98975469;
            cliente2.Ciudad = ciudad2;
            cliente2.Direccion = "Bol. Fuerzas Armadas";

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Christian Amaya";
            cliente3.Telefono = 95684859;
            cliente3.Ciudad = ciudad1;
            cliente3.Direccion = "Bol. Donde sopla el Viento";

            var listaclientes = new List<Cliente>();
            listaclientes.Add(cliente1);
            listaclientes.Add(cliente2);
            listaclientes.Add(cliente3);

            foreach (var c in listaclientes)
            {
                MessageBox.Show("Nombre: " + c.Nombre + "\n\n" + "Ciudad: " + c.Ciudad.Descripcion);
            }


        }
    }
}
