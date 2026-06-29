using Practica5.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practica5.Vista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(!SesionUsuario.Activa){
                MessageBox.Show("No hay sesion activa. Por favor, inicia sesión.");
                this.Close();
                return;
            }
            lblNombre.Text = "Bienvenid@ " + SesionUsuario.UsuarioActual.Nombre;
        }

        private void button1CerrarSesionClick(object sender, EventArgs e)
        {
            SesionUsuario.CerrarSesion();
            Form1 Login = new Form1();
            Login.Show();
            this.Close();
        }
    }
}
