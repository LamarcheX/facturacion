using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
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
        private void btnreg_Click(object sender, EventArgs e)
        {
            showMenuReg(panelMenuReg);
        }

        private void btnIrRegCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente frm = new RegistrarCliente();
            frm.Show();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            showMenuRep(panel_Reportes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Factura frm = new Factura();
            frm.Show();
            this.Hide();
            hideMenuReg();
            hideMenuRep();
        }
    }
}
