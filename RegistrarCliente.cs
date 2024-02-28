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

namespace facturacion
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            //Esconder panel
            panelMenuReg.Visible = false;
            panel_Reportes.Visible = false;
            // Otros paneles
        }

        private void hideMenuReg()
        {
            if (panelMenuReg.Visible == true)
                panelMenuReg.Visible = false;
            // Otros paneles
        }

        private void hideMenuRep()
        {
            if (panel_Reportes.Visible == true)
                panel_Reportes.Visible = false;

        }

        private void showMenuReg(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideMenuReg();
                submenu.Visible = true;
            }
            else
                submenu.Visible = true;
        }

        private void showMenuRep(Panel submenurep)
        {
            if (submenurep.Visible == false)
            {
                hideMenuRep();
                submenurep.Visible = true;
            }
            else
                submenurep.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void btnIrRegArt_Click(object sender, EventArgs e)
        {
            Articulo frm = new Articulo();
            frm.Show();
            this.Hide();
            hideMenuReg();
        }

        private void btnIrRegCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente frm = new RegistrarCliente();
            frm.Show();
            this.Hide();
            hideMenuReg();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            showMenuReg(panelMenuReg);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showMenuRep(panel_Reportes);
        }

        private void FormReset()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDirecion.Clear();
            txtSector.Clear();
            txtProvincia.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conect.Conectar();

            string INSERTAR = "INSERT INTO cliente (cod_cli, nom_cli, apell_cli, dir_cli, sect_cli, prov_cli, cel_cli, correo_cli) VALUES (@Codigo, @Nombre, @Apellido, @Direccion, @Sector, @Provincia, @Celular, @Correo)";
            SqlCommand cmd1 = new SqlCommand(INSERTAR, Conect.Conectar());
            cmd1.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            cmd1.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            cmd1.Parameters.AddWithValue("@Direccion", txtDirecion.Text);
            cmd1.Parameters.AddWithValue("@Sector", txtSector.Text);
            cmd1.Parameters.AddWithValue("@Provincia", txtProvincia.Text);
            cmd1.Parameters.AddWithValue("@Celular", txtCelular.Text);
            cmd1.Parameters.AddWithValue("@Correo", txtCorreo.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos han sido registrados correctamente");
            txtCodigo.Focus();
            FormReset();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conect.Conectar();
            string UPDATE = "UPDATE cliente SET nom_cli = @Nombre, apell_cli = @Apellido, dir_cli = @Direccion, sect_cli = @Sector, prov_cli = @Provincia, cel_cli = @Celular, correo_cli = @Correo WHERE cod_cli = @Codigo";
            SqlCommand cmd2 = new SqlCommand(UPDATE, Conect.Conectar());
            cmd2.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            cmd2.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd2.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            cmd2.Parameters.AddWithValue("@Direccion", txtDirecion.Text);
            cmd2.Parameters.AddWithValue("@Sector", txtSector.Text);
            cmd2.Parameters.AddWithValue("@Provincia", txtProvincia.Text);
            cmd2.Parameters.AddWithValue("@Celular", txtCelular.Text);
            cmd2.Parameters.AddWithValue("@Correo", txtCorreo.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Los datos han sido registrados correctamente");
            txtCodigo.Focus();
            FormReset();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar registro
            if (MessageBox.Show("¿Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conect.Conectar();
                string eliminar = "DELETE FROM cliente WHERE cod_cli = @Codigo"; // aqui solo estas indicando que vas a usar un parametro, en este caso: @cod_emp
                SqlCommand cmd3 = new SqlCommand(eliminar, Conect.Conectar());
                cmd3.Parameters.AddWithValue("@Codigo", txtCodigo.Text); // esta es la definicion del parametro
                cmd3.ExecuteNonQuery();
                dataGridView1.DataSource = llenar_grid();
            }
        }

        public DataTable llenar_grid()
        {
            // Actualizar el datagridview
            Conect.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM cliente order by cod_cli";
            SqlCommand cmd4 = new SqlCommand(consulta, Conect.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd4);

            da.Fill(dt);
            return dt;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Busqueda Incremental
            Conect.Conectar();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM cliente WHERE nom_cli like ('" + txtNombre.Text + "%')";
            SqlCommand cmd5 = new SqlCommand(consultar, Conect.Conectar());
            cmd5.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            // Programación para buscar
            if (e.KeyCode == Keys.Enter)
            {
                Conect.Conectar();
                string comm = "SELECT * FROM cliente WHERE cod_cli = @codigo";
                SqlCommand cmd6 = new SqlCommand(comm, Conect.Conectar());
                cmd6.Parameters.AddWithValue("@codigo", txtCodigo.Text);

                SqlDataReader leer = cmd6.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtNombre.Text = leer["nom_cli"].ToString();
                    txtApellido.Text = leer["apell_cli"].ToString();
                    txtDirecion.Text = leer["dir_cli"].ToString();
                    txtSector.Text = leer["sect_cli"].ToString();
                    txtProvincia.Text = leer["prov_cli"].ToString();
                    txtCelular.Text = leer["cel_cli"].ToString();
                    txtCorreo.Text = leer["correo_cli"].ToString();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // 1. Incrementar
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                this.txtCodigo.Focus();
            }
            Conect.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Select isnull(max(Cast(cod_cli as int)), 0)+1 from cliente", Conect.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtCodigo.Text = dt.Rows[0][0].ToString();
            this.txtNombre.Focus();
            this.btnreg.Enabled = true;
        }
    }
}
