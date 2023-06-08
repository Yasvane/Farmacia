using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LoginFarmaEXPRESS
{
    class conec
    {
        public SqlConnection cadena = new SqlConnection
                            ("Data Source=." +
                            ";Initial Catalog=farmacia" +
                            "; Integrated Security = True");
        
    }
}
