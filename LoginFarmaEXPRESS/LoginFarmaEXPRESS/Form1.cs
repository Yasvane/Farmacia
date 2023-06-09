using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginFarmaEXPRESS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public SqlConnection cadena = new SqlConnection
        //    ("Data Source = ." +
        //    "; Initial Catalog=farmacia" +
        //    ";Integrated Security=true");


        public void Logear(string usuario, string contraseña) {
            try
            {

            }catch(Exception e){
                MessageBox.Show(e.Message);
            }
            finally 
            {
            
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            txtusu.Clear();
            txtcontraseña.Clear();
        }

        private void btnis_Click(object sender, EventArgs e)
        {
            SqlConnection connection = ConexBD.Conectar();
            //connection.Open();
            try
            {
                //if (txtusu.Text == null || txtusu.Text == "")
                //{
                //    MessageBox.Show("Êl usuario es requerido");
                //    return;

                //}
                if (txtusu.Text == "" && txtcontraseña.Text == "")
                {

                    MessageBox.Show("Rellene todos los campos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    //return;

                }

                SqlCommand cmd = new SqlCommand("SELECT Nombre, TipoUsuario FROM Tbl_Usuario WHERE Usuario = @usuario AND Password = @Pass", connection);
                cmd.Parameters.AddWithValue("usuario", this.txtusu.Text);
                cmd.Parameters.AddWithValue("Pass", this.txtcontraseña.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        Frminicio menu = new Frminicio();
                        menu.ShowDialog();
                        //new Administrador(dt.Rows[0][0].ToString()).Show();
                        //MessageBox.Show("Administrador");

                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        //new Cajera(dt.Rows[0][0].ToString()).Show();
                        MessageBox.Show("Usuario");
                    }

                }
                else
                {
                   
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string a = cmd.Parameters.AddWithValue("usuario", this.txtusu.Text).ToString();
                    string b = cmd.Parameters.AddWithValue("Pass", this.txtcontraseña.Text).ToString();
                    if (a != txtusu.Text || b != txtcontraseña.Text)
                    {
                        txtusu.Focus();
                        txtcontraseña.Focus();
                        //if ( b != txtcontraseña.Text)
                        //{
                        //    txtcontraseña.Focus();
                        //}

                    }
                    //if (txtusu.TextLength < 0 || txtcontraseña.MaxLength < 0)
                    //{
                        
                       
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        
            



            /*if (txtusu.Text == "oscar" && txtcontraseña.Text == "1234")
            {
                Splash2 frm = new Splash2();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Frminicio());
                }
                //Frminicio frminicio = new Frminicio();
                //this.Hide();
                //frminicio.Show();

            }
            else
            {
                MessageBox.Show("Los Datos ingresados son incorrectos");
                txtusu.Clear();
                txtcontraseña.Clear();
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
