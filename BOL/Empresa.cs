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
    public class Empresa
    {

        DBAccess conexion = new DBAccess();




        public int Registrar(EEmpresa entidadEmpresa)

        {int cantidadRegistros = 0;

            SqlCommand comando = new SqlCommand("spu_empresas_registrar",conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            conexion.abrirConexion();


            try
            {

                comando.Parameters.AddWithValue("@razonsocial", entidadEmpresa.razonSocial);
                comando.Parameters.AddWithValue("@ruc", entidadEmpresa.ruc);
                comando.Parameters.AddWithValue("@direccion", entidadEmpresa.direccion);
                comando.Parameters.AddWithValue("@telefono", entidadEmpresa.telefono);
                comando.Parameters.AddWithValue("@email", entidadEmpresa.email);
                comando.Parameters.AddWithValue("@website", entidadEmpresa.webSite);

                cantidadRegistros = comando.ExecuteNonQuery();


            }
            catch
            {
                cantidadRegistros = -1;

            }
            
            finally{
                conexion.cerrarConexion();


            }
            return cantidadRegistros;

        }



        public DataTable Listar()
        {

            DataTable dt = new DataTable();

            SqlCommand comando = new SqlCommand("spu_empresas_listar",conexion.getConexion());

            comando.CommandType = CommandType.StoredProcedure ;
            conexion.abrirConexion();
            dt.Load(comando.ExecuteReader());
            conexion.cerrarConexion();
            return dt;




        }


    }


        



     
}


