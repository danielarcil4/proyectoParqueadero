using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParqueadero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioUsual usuario1 = new usuarioUsual("daniel", "123");
            if (usuario1.NombreUsuario == nombreUsuarioTxt.Text && usuario1.Contrasenia == contraseniaTxt.Text)
            {
                Console.WriteLine("logueao");
                Close();
            }

        }
    }
}
