using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20483_AccesoDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RecuperarDatos(string url) {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(url);

            //stream lectura de archivos
            StreamReader reader = new StreamReader(stream);
            string respuesta = reader.ReadToEnd();
            reader.Close();

            rtxttexto.Text = respuesta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RecuperarDatos(txtUrl.Text);
        }
    }
}
