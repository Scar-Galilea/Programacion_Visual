using Practica5.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;

namespace Practica5.Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1IniciarSesionClick(object sender, EventArgs e)
        {
            LoginControlador controller = new LoginControlador();
            bool acceso = controller.Login(Usuariotext.Text, passwordtext.Text);

            if (acceso) {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
