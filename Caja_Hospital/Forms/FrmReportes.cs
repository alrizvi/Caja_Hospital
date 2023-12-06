using FontAwesome.Sharp;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Caja_Hospital.Forms
{
    public partial class FrmReportes : Form
    {
        Conexion cn = new Conexion();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = cn.LeerCadena())
            {
                string query = "SELECT * from tblPaciente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Paso 4: Asignar el archivo RDLC y los datos al ReportViewer
                        reportViewer1.LocalReport.ReportPath = "C:\\Users\\Ali Rizvi\\OneDrive\\Documentos\\TRI 7\\Proyectos de pueba\\Caja_Hospital\\Caja_Hospital\\Reporte.rdlc"; // Ruta al archivo RDLC
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));
                        reportViewer1.RefreshReport();
                    }
                }
            }
            //Asegúrate de reemplazar "Ruta/Al/Archivo.rdlc" con la ruta correcta al archivo RDLC en tu proyecto y "NombreDelDataSet" con el nombre correcto del conjunto de datos definido en tu archivo RDLC.Con estas correcciones, deberías poder cargar y mostrar el informe correctamente en tu control ReportViewer.
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
