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
    public partial class CajaRegistradora : Form
    {
        public CajaRegistradora()
        {
            InitializeComponent();
        }



        private void txtDinRecib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal ddf = 0;
                decimal drf = 0;
                decimal tp = 0;

                tp = Convert.ToDecimal(txtTotPag.Text);
                drf = Convert.ToDecimal(txtDinRecib);
                ddf = drf - tp;

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
