using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {

        capaLogicaProducto objetoCLP = new capaLogicaProducto();
        private string idProducto = null;
        private bool editar = false;
        private String nombreProducto = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor= Color.White;
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            capaLogicaProducto newObjetCLP = new capaLogicaProducto();
            dataGridView1.DataSource = newObjetCLP.MostrarProductos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            //INSERTAR
            if (editar == false)
            {
                try
                {
                    objetoCLP.InsertarProducto(txtNombre.Text, txtPrecio.Text, txtCantidad.Text);
                    MessageBox.Show("Se agrego el producto  con exito");
                    MostrarProductos();
                    limpiarText(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo completar el agregado " + ex);
                }
            }
            if (editar == true) {
                try
                {
                    objetoCLP.EditarProducto(txtNombre.Text, txtPrecio.Text, txtCantidad.Text, idProducto);
                    MessageBox.Show("Producto editado de manera exitosa");
                    MostrarProductos();
                    limpiarText(); 
                    editar = false; 
                }
                catch (Exception ex) {
                    MessageBox.Show("No se pudo completar la edicion " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true; 
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombreProducto"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            }
            else {
                MessageBox.Show("por favor seleccione la fila a editar");
            }
        }

        private void limpiarText() {
            txtPrecio.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
                objetoCLP.EliminarProducto(idProducto);
                MessageBox.Show("Registro eliminado de manera exitosa");
                MostrarProductos(); 
            }
            else {
                MessageBox.Show("Por favor seleccionar un registro"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                nombreProducto = txtBuscar.Text;
                capaLogicaProducto newObjetCLP = new capaLogicaProducto();
                dataGridView1.DataSource = newObjetCLP.BuscarProducto(nombreProducto);
            }
            else {
                MessageBox.Show("Error: No se puede buscar sin valores");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarProductos(); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && txtPrecio.Text.Length > 0 && txtCantidad.Text.Length > 0)
            {
                limpiarText();
            }
            else {
                MessageBox.Show("Los campos ya estan limpios!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
