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
        private Usuario _usuario = new usuarioUsual();
        private Usuario _usuario2 = new usuarioUsual("daniel", "123");
        private Usuario _usuario3 = new usuarioUsual("santiago", "321");
        private Usuario _usuario4 = new usuarioUsual("ramiro", "123");
        public Form1()
        {
            InitializeComponent();

        }
        public Form1(usuarioUsual usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public Usuario Usuario2 { get => _usuario2; set => _usuario2 = value; }
        public Usuario Usuario3 { get => _usuario3; set => _usuario3 = value; }
        public Usuario Usuario4 { get => _usuario4; set => _usuario4 = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Usuario.NombreUsuario == nombreUsuarioTxt.Text && Usuario.Contrasenia == contraseniaTxt.Text
                || Usuario2.NombreUsuario == nombreUsuarioTxt.Text && Usuario2.Contrasenia == contraseniaTxt.Text)
            {
                labelLogin.Text = "Logueado";
                Console.WriteLine("logueado");
                //Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            Hide();
            registroForm.Show();
        }
    }
}
