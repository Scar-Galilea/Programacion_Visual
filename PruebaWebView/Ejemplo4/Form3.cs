using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, EventArgs e)
        {

        }

        private void button1carpeClickEvent(object sender, EventArgs e)
        {
            OpenFileDialog buscarCarpeta = new OpenFileDialog();
            try
            {
                buscarCarpeta.ValidateNames = false;
                buscarCarpeta.CheckFileExists = false;
                buscarCarpeta.CheckPathExists = true;
                buscarCarpeta.FileName = "Selecciona esta carpeta";

                if (buscarCarpeta.ShowDialog() == DialogResult.OK)
                {
                    string rutaCarpeta = Path.GetDirectoryName(buscarCarpeta.FileName);

                    List<string> listaArchivos = new List<string>();
                    listaArchivos.AddRange(Directory.GetFiles(rutaCarpeta, "*.mp3"));
                    listaArchivos.AddRange(Directory.GetFiles(rutaCarpeta, "*.mp4"));

                    if (listaArchivos.Count > 0)
                    {
                        WMPLib.IWMPPlaylist lista = axWindowsMediaPlayer1.newPlaylist("MiLista", "");

                        listBox1.Items.Clear();

                        for (int i = 0; i < listaArchivos.Count; i++)
                        {
                            string archivo = listaArchivos[i];

                            lista.appendItem(axWindowsMediaPlayer1.newMedia(archivo));
                            listBox1.Items.Add(Path.GetFileName(archivo));
                        }

                        axWindowsMediaPlayer1.currentPlaylist = lista;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        MessageBox.Show("No hay archivos MP3 y MP4 aquí.");
                    }
                }
            }
            finally
            {
                if (buscarCarpeta != null)
                {
                    buscarCarpeta.Dispose();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && axWindowsMediaPlayer1.currentPlaylist != null)
            {
                try
                {
                    WMPLib.IWMPMedia cancionSeleccionada = axWindowsMediaPlayer1.currentPlaylist.Item[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.currentItem = cancionSeleccionada;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al reproducir la canción: " + ex.Message);
                }
            }
        }
    }
}
