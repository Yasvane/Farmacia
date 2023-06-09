
namespace LoginFarmaEXPRESS
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmensajeAmin = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensajeAmin
            // 
            this.lblmensajeAmin.AutoSize = true;
            this.lblmensajeAmin.Location = new System.Drawing.Point(255, 79);
            this.lblmensajeAmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmensajeAmin.Name = "lblmensajeAmin";
            this.lblmensajeAmin.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeAmin.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(184, 134);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(70, 13);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administrador";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 292);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblmensajeAmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajeAmin;
        private System.Windows.Forms.Label lblAdmin;
    }
}