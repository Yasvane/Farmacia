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
    public partial class Frminicio : Form
    {
        public Frminicio()
        {
            InitializeComponent();
        }

        private void Frminicio_Load(object sender, EventArgs e)
        {
             
            Timer timer = new Timer();
            timer.Interval = 2000; // 2000 milisegundos = 2 segundos
            timer.Tick += (s, args) =>
            {

                label1.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        private void detallesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario secundario
            panel1.Visible = true;
            Admin formulario = new Admin();

            // Establecer el TopLevel en false
            formulario.TopLevel = false;

            // Establecer el Parent al Panel
            panel1.Controls.Add(formulario);

            // Ajustar las propiedades del formulario secundario
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
             panel1.Visible = true;
             Proveedor formulario = new Proveedor();

            // Establecer el TopLevel en false
            //formulario.TopLevel = false;

            //// Establecer el Parent al Panel
            //panel1.Controls.Add(formulario);

            //// Ajustar las propiedades del formulario secundario
            //formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        
    }
}
