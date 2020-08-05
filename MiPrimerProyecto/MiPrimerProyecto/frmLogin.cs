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
<<<<<<< HEAD
        string user = "adm"; // Usuario de administrador
        string pass = "123456";
=======
        string user = "adm"; //comentario sofia
        string pass = "123456"; //administrador de usuarios //nombre de usuario
>>>>>>> 5471b1086c7c27e36da916527a4be74ccced7934
        public frmLogin()
        {
            InitializeComponent();
        }

      
        private void btnIngresar_Click(object sender, EventArgs e)
        {   
            // if (this.txtUsurio.Texto == string.Empty)
            if (this.txtUsuario.Text=="")
            {
                MessageBox.Show("Debe ingresar usuario");
                this.txtUsuario.Focus();
                return;
            }

            // if (string.IsNullOnEmpty(this.txtClave.Text))
            if (this.txtClave.Text== "") 
            {
                MessageBox.Show("Debe ingresar clave");
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
