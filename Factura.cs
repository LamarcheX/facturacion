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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            //Esconder panel
            panelMenuReg.Visible = false;
            panel_Reportes.Visible = false;
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

        private void btnreg_Click(object sender, EventArgs e)
        {
            showMenuReg(panelMenuReg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showMenuRep(panel_Reportes);
        }

        private void FormReset()
        {
            txtArticulo.Clear();
            txtCantidad.Clear();
            txtCliente.Clear();
            txtDescIte.Clear();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtMonDesc.Clear();
            txtNombre.Clear();
            txtnum_fac.Clear();
            txtPorDesc.Clear();
            txtPorDescIte.Clear();
            txtPrecio.Clear();
            txtSubTot.Clear();
            txtTotPag.Clear();
        }

        public DataTable llenar_gridTDF()
        {
            Conect.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM temdetallefactura ORDER BY cod_art_dftem";
            SqlCommand cmd = new SqlCommand(consulta, Conect.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal subtotal, pre, can;

                pre = Convert.ToDecimal(txtPrecio.Text);
                can = Convert.ToDecimal(txtCantidad.Text);

                subtotal = (pre * can);
                txtsubtotal.Text = subtotal.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conect.Conectar();
            string insertar = "INSERT INTO temdetallefactura(num_fac_dftem, cod_art_dftem, desc_art_dftem, descrip_art_dftem, cant_art_dftem, pre_dftem, stotal) VALUES(@NUM_FAC_DFTEM, @COD_ART_DFTEM, @DESC_ART_DFTEM, @DESCRIP_ART_DFTEM, @CANT_ART_DFTEM, @PRE_DFTEM, @STOTAL)";
            SqlCommand cmd = new SqlCommand(insertar, Conect.Conectar());
            cmd.Parameters.AddWithValue("@NUM_FAC_DFTEM", txtnum_fac.Text);
            cmd.Parameters.AddWithValue("@COD_ART_DFTEM", txtArticulo.Text);
            cmd.Parameters.AddWithValue("@DESC_ART_DFTEM", txtMonDesc.Text);
            cmd.Parameters.AddWithValue("@DESCRIP_ART_DFTEM", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@CANT_ART_DFTEM", txtCantidad.Text);
            cmd.Parameters.AddWithValue("@PRE_DFTEM", txtPrecio.Text);
            cmd.Parameters.AddWithValue("@STOTAL", txtsubtotal.Text);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = llenar_gridTDF();
            calcularSubtotal();
        }

        private void calcularSubtotal()
        {
            double subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                subtotal += Convert.ToDouble(row.Cells["stotal"].Value);
            txtSubTot.Text = Convert.ToString(subtotal);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Conect.Conectar();
            string cadena = "UPDATE Articulo set exist_art = exist_art - " + txtCantidad.Text + " WHERE cod_art = '" + txtArticulo.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, Conect.Conectar());
            comando.ExecuteNonQuery();
            calcularSubtotal();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtHora.Text = DateTime.Now.ToLongTimeString();
            
            txtFecha.Text = DateTime.Now.ToLongDateString();

            // TODO: This line of code loads data into the 'facturacionDataSet.temdetallefactura' table. You can move, or remove it, as needed.
            //this.temdetallefacturaTableAdapter.Fill(this.facturacionDataSet.temdetallefactura);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                this.txtnum_fac.Focus();
            }
            Conect.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(num_fac_dftem AS INT)), 0)+1 FROM temdetallefactura", Conect.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtnum_fac.Text = dt.Rows[0][0].ToString();
            this.txtCliente.Focus();
            this.btnreg.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conect.Conectar();
                string eliminar = "DELETE FROM temdetallefactura WHERE num_fac_dftem = @txtnum_fac";
                SqlCommand cmd = new SqlCommand(eliminar, Conect.Conectar());
                cmd.Parameters.AddWithValue("@txtnum_fac", txtnum_fac.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = llenar_gridTDF();
            }
        }

        private void txtnum_fac_TextChanged(object sender, EventArgs e)
        {
            Conect.Conectar();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM temdetallefactura WHERE num_fac_dftem LIKE ('" + txtnum_fac.Text + "%')";
            SqlCommand cmd = new SqlCommand(consultar, Conect.Conectar());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnIrRegCliente_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Factura frm = new Factura();
            frm.Show();
            this.Hide();
            hideMenuReg();
            hideMenuRep();
        }


        private void txtsubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal subtotal, pre, can;

                pre = Convert.ToDecimal(txtPrecio.Text);
                can = Convert.ToDecimal(txtCantidad.Text);

                subtotal = (pre * can);
                txtsubtotal.Text = subtotal.ToString();
                txtSubTot.Text = subtotal.ToString();
            }

        }

        private void calcularTotalPagar()
        {
            // Total a pagar es la suma del Subtotal + el ITBIS - el Descuento
            // basta con halar los datos de esos textbox y hacer las operaciones
            //float subt = float.Parse(txtSubTot.Text);
            //float desc = float.Parse(txtPorDesc.Text) / 100;
            //float itbis = float.Parse(txtPorDescIte.Text) / 100;

            //test
            float subt, desc, itbis;
            if (!float.TryParse(txtSubTot.Text, out subt))
            {
                MessageBox.Show("Subtotal invalido");
                return;
            }

            if (!float.TryParse(txtPorDesc.Text, out desc))
            {
                MessageBox.Show("Porciento descuento invalido");
                return;
            }

            if (!float.TryParse(txtPorDescIte.Text, out itbis))
            {
                // Handle parsing error
                MessageBox.Show("ITBIS percentage is not a valid number.");
                return;
            }

            // Ensure the denominator for percentage calculation is not zero
            if (desc == 0 || itbis == 0)
            {
                MessageBox.Show("Discount percentage or ITBIS percentage cannot be zero.");
                return;
            }
            //Operaciones
            float montoDesc = subt * (desc / 100);
            float montoItbis = subt * (itbis / 100);
            float totalfac = (subt - montoDesc) + montoItbis;
            //LLenar los TextBox con los resultados
            txtMonDesc.Text = montoDesc.ToString();
            txtDescIte.Text = montoItbis.ToString();
            txtSubTot.Text = subt.ToString();
            txtTotPag.Text = totalfac.ToString();
        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {
            calcularSubtotal();
        }

        private void txtTotPag_TextChanged(object sender, EventArgs e)
        {
            calcularTotalPagar();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CajaRegistradora cj = new CajaRegistradora();
            cj.txtFactura.Text = this.txtnum_fac.Text;
            cj.txtTotPag.Text = this.txtTotPag.Text;
            cj.Show();
        }

        private void txtCantidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPorDescIte_TextChanged(object sender, EventArgs e)
        {
            calcularTotalPagar();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal subtotal, pre, can;

                pre = Convert.ToDecimal(txtPrecio.Text);
                can = Convert.ToDecimal(txtCantidad.Text);

                subtotal = (pre * can);
                txtsubtotal.Text = subtotal.ToString();
            }
        }

        //private void txtPorDesc_TextChanged(object sender, EventArgs e)
        //{
        //    calcularTotalPagar();
        //}
    }
}
