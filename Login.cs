using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conect.Conectar();
            string consulta = "SELECT * FROM usuario WHERE nom_usu = @nombre and cla_usu = @clave;";
            SqlCommand comando = new SqlCommand(consulta, Conect.Conectar());
            comando.Parameters.AddWithValue("@nombre", txtUsuario.Text);
            comando.Parameters.AddWithValue("@clave", txtClave.Text);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido al sistema");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                this.txtUsuario.Text = "";
                this.txtClave.Text = "";
                this.txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                this.txtUsuario.Text = "";
                this.txtClave.Text = "";
                this.txtUsuario.Focus();
            }
        }
    }
}
