using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModuloRiesgosSG_SST.Datos.Conexion
{
    class DClConexion
    {
        SqlConnection Cn;
        public SqlConnection mtdConexion()
        {
            Cn = new SqlConnection(@"Data Source=DESKTOP-HIR6T8B\LIQUID;Initial Catalog=SGSST;Integrated Security=True");
            return Cn;
        }
    }
}
