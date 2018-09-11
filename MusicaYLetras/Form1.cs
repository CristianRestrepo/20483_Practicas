using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cFacade;
using cDTO;

namespace MusicaYLetras
{
    public partial class Form1 : Form
    {
        private fProducto facadeProducto;
        private fEditorialSelloMarca facadeEditorialMarcaSello;

        public Form1()
        {
            InitializeComponent();
            facadeEditorialMarcaSello = new fEditorialSelloMarca();
            facadeProducto = new fProducto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.CustomFormat = "yyyy-MM-dd";
            CargarTipos();
            CargarEdSelloMarca();
            lstTipos.DisplayMember = "Nombre";
            lstEdiMarcaSello.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cProducto producto = new cProducto();
            producto.Nombre = txtNombre.Text;
            producto.Autor = txtAutor.Text;
            producto.IdTipo = ((cTipo)lstTipos.SelectedItem).Id;
            producto.IdEditorialSelloMarca = ((cEdiMarcaSello)lstEdiMarcaSello.SelectedItem).Id;
            producto.FechaPublicacion = dtFecha.Value;
            producto.Precio = Decimal.Parse(txtPrecio.Text);

            cInventario inventario = new cInventario();
            inventario.Cantidad = int.Parse(txtCantidad.Text);

            if (facadeProducto.GuardarProductos(producto, inventario)) {
                MessageBox.Show("Producto Registrado Exitosamente");
            }
        }

        private void CargarTipos()
        {
            cFacade.fTipo facadeTipo = new fTipo();
            foreach (cTipo t in facadeTipo.ConsultarTipos())
            {
                lstTipos.Items.Add(t);
            }
        }

        private void CargarEdSelloMarca()
        {
            foreach (cEdiMarcaSello ed in facadeEditorialMarcaSello.ConsultarEditorialMarcaSellos())
            {
                lstEdiMarcaSello.Items.Add(ed);
            }
        }
    }
}
