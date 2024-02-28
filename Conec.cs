using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion
{
    class Conect
    {
        public static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("SERVER=ELIANA\\MSSQLSERVER01; DATABASE=facturacion; INTEGRATED SECURITY=True");

            con.Open();

            return con;
        }
    }
}
