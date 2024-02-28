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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        //private void btnIrRegCliente_Click(object sender, EventArgs e)
        //{
        //    RegistrarCliente frm = new RegistrarCliente();
        //    frm.Show();
        //    this.Hide();
        //    hideMenuReg();
        //}

        private void btnreg_Click_1(object sender, EventArgs e)
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
            txtCantidad.Clear();
            txtCosto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantMin.Clear();
            txtExistencia.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conect.Conectar();
            string INSERTAR = "INSERT INTO articulo (cod_art, desc_art, cant_art, exist_art, cost_art, precio_art, cant_min_art) VALUES (@Codigo, @descripcion, @cantidad, @existencia, @costo, @precio, @cantMinima)";
            SqlCommand cmd1 = new SqlCommand(INSERTAR, Conect.Conectar());
            cmd1.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            cmd1.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
            cmd1.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
            cmd1.Parameters.AddWithValue("@existencia", txtExistencia.Text);
            cmd1.Parameters.AddWithValue("@costo", txtCosto.Text);
            cmd1.Parameters.AddWithValue("@precio", txtPrecio.Text);
            cmd1.Parameters.AddWithValue("@cantMinima", txtCantMin.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos han sido registrados correctamente");
            txtCodigo.Focus();
            FormReset();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conect.Conectar();
            string UPDATE = "UPDATE articulo SET  desc_art = @descuento, cant_art = @cantidad, exist_art = @existencia, cost_art = @costo, precio_art = @precio, cant_min_art = @cantMinima WHERE cod_art = @Codigo";
            SqlCommand cmd2 = new SqlCommand(UPDATE, Conect.Conectar());
            cmd2.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            cmd2.Parameters.AddWithValue("@descuento", txtDescripcion.Text);
            cmd2.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
            cmd2.Parameters.AddWithValue("@existencia", txtExistencia.Text);
            cmd2.Parameters.AddWithValue("@costo", txtCosto.Text);
            cmd2.Parameters.AddWithValue("@precio", txtPrecio.Text);
            cmd2.Parameters.AddWithValue("@cantMinima", txtCantMin.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Los datos han sido registrados correctamente");
            txtCodigo.Focus();
            FormReset();
        }

        public DataTable llenar_grid()
        {
            // Actualizar el datagridview
            Conect.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM articulo order by cod_art";
            SqlCommand cmd4 = new SqlCommand(consulta, Conect.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd4);

            da.Fill(dt);
            return dt;
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
            SqlDataAdapter da = new SqlDataAdapter("Select isnull(max(Cast(cod_art as int)), 0)+1 from articulo", Conect.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtCodigo.Text = dt.Rows[0][0].ToString();
            this.txtCantidad.Focus();
            this.btnreg.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar registro
            if (MessageBox.Show("¿Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conect.Conectar();
                string eliminar = "DELETE FROM articulo WHERE cod_art = @Codigo"; // aqui solo estas indicando que vas a usar un parametro, en este caso: @cod_emp
                SqlCommand cmd3 = new SqlCommand(eliminar, Conect.Conectar());
                cmd3.Parameters.AddWithValue("@Codigo", txtCodigo.Text); // esta es la definicion del parametro
                cmd3.ExecuteNonQuery();
                dataGridView1.DataSource = llenar_grid();
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            // Programación para buscar
            if (e.KeyCode == Keys.Enter)
            {
                Conect.Conectar();
                string comm = "SELECT * FROM articulo WHERE cod_art = @codigo";
                SqlCommand cmd6 = new SqlCommand(comm, Conect.Conectar());
                cmd6.Parameters.AddWithValue("@codigo", txtCodigo.Text);

                SqlDataReader leer = cmd6.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtDescripcion.Text = leer["desc_art"].ToString();
                    txtCantidad.Text = leer["cant_art"].ToString();
                    txtExistencia.Text = leer["exist_art"].ToString();
                    txtCosto.Text = leer["cost_art"].ToString();
                    txtPrecio.Text = leer["precio_art"].ToString();
                    txtCantMin.Text = leer["cant_min_art"].ToString();
                }
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            // Busqueda Incremental
            Conect.Conectar();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM articulo WHERE desc_art like ('" + txtDescripcion.Text + "%')";
            SqlCommand cmd5 = new SqlCommand(consultar, Conect.Conectar());
            cmd5.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnIrRegCliente_Click_1(object sender, EventArgs e)
        {
            RegistrarCliente frm1 = new RegistrarCliente();
            frm1.Show();
            this.Hide();
            hideMenuReg();
            hideMenuRep();
        }

        private void btnIrRegArt_Click(object sender, EventArgs e)
        {

            Articulo frm = new Articulo();
            frm.Show();
            this.Hide();
            hideMenuReg();
            hideMenuRep();
        }
    }
}