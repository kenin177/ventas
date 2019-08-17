using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Id = 1;
            heroe1.Nombre = "Quick Silver";
            heroe1.ColorTraje = "Azul";
            heroe1.Genero = "Masculino";
            heroe1.Descripcion = "Le encanta hacer bromas, hacer que la vida sea movida y divertida";
            heroe1.Poder = "Super Velozidad";
            heroe1.Debilidad = "Suelo Resvalozo";

            var heroe2 = new Heroe();
            heroe2.Id = 2;
            heroe2.Nombre = "Ciclope";
            heroe2.ColorTraje = "Amarillo";
            heroe2.Genero = "Masculino";
            heroe2.Descripcion = "Serio y obstinado a la hora de actuar";
            heroe2.Poder = "Rayo de los ojos";
            heroe2.Debilidad = "Puede herir tanto aliados como enemigos";

            var heroe3 = new Heroe();
            heroe3.Id = 3;
            heroe3.Nombre = "Storm";
            heroe3.ColorTraje = "Blanco";
            heroe3.Genero = "Femenino";
            heroe3.Descripcion = "Muy serena y con la mente fria cuando se enfrenta a problemas";
            heroe3.Poder = "Controla el Clima";
            heroe3.Debilidad = "Necesita demasiada concentracion";

            var ListadeHeroes = new List<Heroe>();
            ListadeHeroes.Add(heroe1);
            ListadeHeroes.Add(heroe2);
            ListadeHeroes.Add(heroe3);

            foreach (var p in ListadeHeroes)
            {
                MessageBox.Show(p.Id + ". " + p.Nombre + "\n" + "Color del Traje: " + p.ColorTraje + "\n" + "Genero: " + p.Genero + "\n" + "Descripcion: " +
                     p.Descripcion + "\n" + "Poder: " + p.Poder + "\n" + "Debilidad: " + p.Debilidad);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var villano1 = new Villano();
            villano1.Id = 1;
            villano1.Nombre = "Magneto";
            villano1.ColorTraje = "Rojo";
            villano1.Genero = "Masculino";
            villano1.Descripcion = "Ruin y despiadado, sin sentimientos";
            villano1.Poder = "Controla el metal";
            villano1.Debilidad = "Objetos que no contengan metal";

            var villano2 = new Villano();
            villano2.Id = 2;
            villano2.Nombre = "Mystique";
            villano2.ColorTraje = "Azul";
            villano2.Genero = "Femenino";
            villano2.Descripcion = "Ruin y despiadada, sin sentimientos";
            villano2.Poder = "Cambia de Forma";
            villano2.Debilidad = "Telepatas";

            var villano3 = new Villano();
            villano3.Id = 3;
            villano3.Nombre = "Gambito";
            villano3.ColorTraje = "Rojo";
            villano3.Genero = "Masculino";
            villano3.Descripcion = "Ambicioso y se unira al lado ganador, siempre";
            villano3.Poder = "Manipula objetos";
            villano3.Debilidad = "Peleas cuerpoa cuerpo";

            var ListadeVillanos = new List<Villano>();
            ListadeVillanos.Add(villano1);
            ListadeVillanos.Add(villano2);
            ListadeVillanos.Add(villano3);

            foreach (var p in ListadeVillanos)
            {
                MessageBox.Show(p.Id + ". " + p.Nombre + "\n" + "Color del Traje: " + p.ColorTraje + "\n" + "Genero: " + p.Genero + "\n" + "Descripcion: " +
                     p.Descripcion + "\n" + "Poder: " + p.Poder + "\n" + "Debilidad: " + p.Debilidad);
            }
        }
    }
}
