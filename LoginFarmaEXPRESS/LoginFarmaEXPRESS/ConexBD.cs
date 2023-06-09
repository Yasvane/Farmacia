using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LoginFarmaEXPRESS
{
    class ConexBD
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=." +
                            ";Initial Catalog=farmacia" +
                            "; Integrated Security = True");

            cn.Close();
            return cn;
        }
    }
}
