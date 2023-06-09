using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LoginFarmaEXPRESS
{
   public class ConexBD
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=." +
                            ";Initial Catalog=farmacia" +
                            "; Integrated Security = True");

            cn.Close();
            return cn;
        }
        public string Nombre;
        public string direccion;
        public string correo;
        public int telefono;

        public void agregar ()
        {
            SqlConnection cn = new SqlConnection("Data Source=." +
                            ";Initial Catalog=farmacia" +
                            "; Integrated Security = True");
            SqlCommand mycomand = new SqlCommand("guardar", cn);
            mycomand.CommandType = System.Data.CommandType.StoredProcedure;
            mycomand.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = Nombre;
            mycomand.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar).Value = direccion;
            mycomand.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar).Value = correo;
            mycomand.Parameters.Add("@telefono", System.Data.SqlDbType.NVarChar).Value = telefono;
            cn.Open();
            mycomand.ExecuteNonQuery();
           
            mycomand.Connection.Close();
            cn.Close();



        }

                
      
        
    }
}
