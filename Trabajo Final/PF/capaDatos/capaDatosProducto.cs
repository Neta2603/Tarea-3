using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class capaDatosProducto
    {

        private conexionSQL conexion = new conexionSQL();

        SqlDataReader leer;
        DataTable talba = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Productos";
            comando.CommandType = CommandType.Text;
            leer=comando.ExecuteReader();
            talba.Load(leer);
            conexion.CerrarConexion();
            return talba; 
        }

        public void Insertar(string NombreProducto, int Precio, int Cantidad)
        {
            //TRANSACT SQL
            SqlCommand comando = new SqlCommand("AgregarProducto", conexion.AbrirConexion());
            comando.CommandType=CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@NombreProducto", NombreProducto);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.ExecuteNonQuery();

        }

        public void Editar(string NombreProducto, int Precio, int Cantidad, int ProductoId) {
            //TRANSACT SQL
            SqlCommand comando = new SqlCommand("ModificarProducto", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@NombreProducto", NombreProducto);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@ProductoId", ProductoId);
            comando.ExecuteNonQuery();

        }

        public void Eliminar(int ProductoId) {
            //TRANSACT SQL
            SqlCommand comando = new SqlCommand("EliminarProducto", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ProductoId", ProductoId);
            comando.ExecuteNonQuery(); 
        }

        public DataTable Buscar(string NombreProducto) {
            //TRANSACT SQL
            SqlCommand comando = new SqlCommand("BuscarProductos", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@NombreProducto", NombreProducto);

            leer = comando.ExecuteReader();
            talba.Load(leer);
            conexion.CerrarConexion();
            return talba;
        }


        public DataTable ProductosMasVendidos() {
            //TRANSACT SQL
            SqlCommand comando = new SqlCommand("ProductosMasVendidos", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            talba.Load(leer);
            conexion.CerrarConexion();
            return talba;
        }


        public DataTable ProductosMenosVendidos()
        {
            //TRANSACT SQL
            SqlCommand comando = new SqlCommand("ProductosMenosVendidos", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            talba.Load(leer);
            conexion.CerrarConexion();
            return talba;
        }


    }
}
