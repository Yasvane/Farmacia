using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginFarmaEXPRESS
{
    public partial class Splash2 : Form
    {
        public Splash2()
        {
            InitializeComponent();
            tiempo.Enabled = true;
        }
        int contador = 0;

        private void label2_Click(object sender, EventArgs e)
        {
            contador += 1;
            mensaje.Text = "Cargando Datos del Sistema en ......... " + contador + "%";
            progressBar1.Increment(1);
            if (progressBar1.Value == 20)
            {
                //tiempo.Stop();
                //this.DialogResult = DialogResult.OK;

                
                
               
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }


        }

        private void Splash2_Load(object sender, EventArgs e)
        {

        }
    }
}
