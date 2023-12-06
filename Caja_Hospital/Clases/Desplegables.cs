using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital
{
    internal class Desplegables
    {
        Conexion cn = new Conexion();
        public DataTable TipoServicio()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_SelectTipoServicio",cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Servicio()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_SelectServicio", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
