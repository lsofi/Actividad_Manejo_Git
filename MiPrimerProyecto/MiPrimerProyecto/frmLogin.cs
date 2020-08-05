using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class frmLogin : Form
    {
        string user = "admin";
        string pass = "1234";
        public frmLogin()
        {
            InitializeComponent();
        }

      
        private void btnIngresar_Click(object sender, EventArgs e)
        {   
            // if (this.txtUsurio.Texto == string.Empty)
            if (this.txtUsuario.Text=="")
            {
                MessageBox.Show("Debe ingresar usuario...");
                this.txtUsuario.Focus();
                return;
            }

            // if (string.IsNullOnEmpty(this.txtClave.Text))
            if (this.txtClave.Text== "") 
            {
                MessageBox.Show("Debe ingresar clave...");
                this.txtClave.Focus();
                return;
            }

            // Validar usuario y clave
            string msj = "";
            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
                msj = "Login OK";
            else
                msj = "Usuario y/o clave incorrectos";

            MessageBox.Show(msj,"Ingreso al Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
