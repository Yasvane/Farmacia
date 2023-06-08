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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (this.Opacity > 0) 
            {
                this.Opacity -= 0.0001;
            }
            this.Hide();
            //form1 f1 = new form1();
            //f1.show;
            //timer1.stop();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //timer1.interval =1500;
            //timer1.start();
        }
    }
}
