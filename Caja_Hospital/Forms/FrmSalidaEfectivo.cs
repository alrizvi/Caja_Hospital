using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Hospital
{
    public partial class FrmSalidaEfectivo : Form
    {
        public FrmSalidaEfectivo()
        {
            InitializeComponent();
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es una letra, ignora la tecla presionada
            }
        }
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es un número, ignora la tecla presionada
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAutorizacion.Text = txtConcepto.Text = txtCosto.Text = txtRecibido.Text = string.Empty;

        }
    }
}
