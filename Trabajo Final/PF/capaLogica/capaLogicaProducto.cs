using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaDatos; 

namespace capaLogica
{
    public class capaLogicaProducto
    {

        private capaDatosProducto objetoCPD = new capaDatosProducto();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCPD.Mostrar();
            return tabla;
        }

        public void InsertarProducto(string NombreProducto, string Precio, string Cantidad)
        {
            objetoCPD.Insertar(NombreProducto, Convert.ToInt32(Precio), Convert.ToInt32(Cantidad));
        }

        public void EditarProducto(string NombreProducto, string Precio, string Cantidad, string ProductoId) {
            objetoCPD.Editar(NombreProducto, Convert.ToInt32(Precio), Convert.ToInt32(Cantidad), Convert.ToInt32(ProductoId));
        }

        public void EliminarProducto(string ProductoId) {
            objetoCPD.Eliminar(Convert.ToInt32(ProductoId));
        }

        public DataTable BuscarProducto(string NombreProducto)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCPD.Buscar(NombreProducto);
            return tabla;
        }

        public DataTable ProductosMasVendidos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCPD.ProductosMasVendidos();
            return tabla;
            
        }

        public DataTable ProductosMenosVendidos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCPD.ProductosMenosVendidos();
            return tabla;
            
        }




    }

}
