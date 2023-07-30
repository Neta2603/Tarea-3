using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            MostrarProductos();

            MostrarProductosMV();

            MostrarProductosMenosV();
        }

        private void MostrarProductos()
        {
            capaLogicaProducto newObjetCLP = new capaLogicaProducto();
            dataGridView1.DataSource = newObjetCLP.MostrarProductos();
        }

        private void MostrarProductosMV()
        {
            capaLogicaProducto newObjetCLP = new capaLogicaProducto();
            dataGridView2.DataSource = newObjetCLP.ProductosMasVendidos();
        }

        private void MostrarProductosMenosV()
        {
            capaLogicaProducto newObjetCLP = new capaLogicaProducto();
            dataGridView3.DataSource = newObjetCLP.ProductosMenosVendidos();
        }


        


    }
}
