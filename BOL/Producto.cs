using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using ENTITIES;

namespace BOL
{
  public class Producto
    {
        DBAccess conexion = new DBAccess();
      


        public DataTable listar()
        {
            return conexion.listarDatos("spu_productos_listar");
           
        }


        public int registrar( EProducto entidadProducto)

        {
            int cantidadRegistros = 0;

            

            SqlCommand comando = new SqlCommand("spu_productos_registrar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            conexion.abrirConexion();


            try
            {

                comando.Parameters.AddWithValue("@idmarca", entidadProducto.idmarca);
                comando.Parameters.AddWithValue("@idsubcategoria", entidadProducto.idsubcategoria);
                comando.Parameters.AddWithValue("@descripcion", entidadProducto.descripcion);
                comando.Parameters.AddWithValue("@garantia", entidadProducto.garantia);
                comando.Parameters.AddWithValue("@precio", entidadProducto.precio);
                comando.Parameters.AddWithValue("@stock", entidadProducto.stock);

                cantidadRegistros = comando.ExecuteNonQuery();


            }
            catch
            {
                cantidadRegistros = -1;

            }
            finally
            {
                conexion.cerrarConexion();

            }
            return cantidadRegistros;



        }






    }
}
