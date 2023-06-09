using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFarmaEXPRESS
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet.Tbl_Proveedor' Puede moverla o quitarla según sea necesario.
            this.tbl_ProveedorTableAdapter.Fill(this.farmaciaDataSet.Tbl_Proveedor);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            ConexBD guardar1 = new ConexBD();
            guardar1.Nombre = txtNomProve.Text;
            guardar1.direccion = txtDireccion.Text;
            guardar1.correo = TxtCorreo.Text;
            guardar1.telefono = int.Parse( txtTelefono.Text);

            guardar1.agregar();
            mostrarDatos();
            MessageBox.Show("registro", "usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void mostrarDatos()
        {
            
            SqlConnection connection = ConexBD.Conectar();
            string consulta = " Nombre_Proveedor,Direccion,Telefono, Email from Tbl_Proveedor";
     
  
            SqlCommand command = new SqlCommand(consulta, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
           
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
