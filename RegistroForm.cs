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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void registrobtn_Click(object sender, EventArgs e)
        {
            if(nombreUsuarioTxt.Text=="" || contraseniaTxt.Text == "")         
                labelError.Text = "el nombre de usuario o la contraseña no pueden ser vacios";           
            else if(tipoUsuarioTxt.Text=="Usuario usual")
            {
                usuarioUsual usuario1 = new usuarioUsual(nombreUsuarioTxt.Text, contraseniaTxt.Text);
                Form1 loginForm = new Form1(usuario1);
                Hide();
                loginForm.Show();
            }
            else if(tipoUsuarioTxt.Text == "Usuario ocasional")
            {
                //se crea clase usuario ocasional
            }
        }
    }
}
