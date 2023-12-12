using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BOL
{
   public class Categoria
    {
        DBAccess conexion = new DBAccess();

        public DataTable listar()
        {
           return  conexion.listarDatos("spu_categorias_listar");
        }
    }
}
