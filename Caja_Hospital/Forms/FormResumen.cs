using LiveCharts.Wpf;
using LiveCharts;
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

namespace Caja_Hospital
{
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormatoDinero()
        {
            if (lblMontoCaja.Text != "No hay registros.")
            {
                decimal cantidadEntrada = decimal.Parse(lblIngresoTotal.Text);
                decimal montoCaja = decimal.Parse(lblMontoCaja.Text);
                decimal aperturaDia = decimal.Parse(lblAperturaDia.Text);

                lblIngresoTotal.Text = cantidadEntrada.ToString("C");
                lblMontoCaja.Text = montoCaja.ToString("C");
                lblAperturaDia.Text = aperturaDia.ToString("C");
            }
            else
            {
                decimal cantidadEntrada = decimal.Parse(lblIngresoTotal.Text);
                decimal aperturaDia = decimal.Parse(lblAperturaDia.Text);
                lblIngresoTotal.Text = cantidadEntrada.ToString("C");
                lblAperturaDia.Text = aperturaDia.ToString("C");
            }
        }
    }
}