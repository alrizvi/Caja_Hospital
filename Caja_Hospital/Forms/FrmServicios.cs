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

namespace Caja_Hospital.Forms
{
    public partial class FrmServicios : Form
    {
        Conexion cn = new Conexion();
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Datos a insertar
            string nombreServicio = txtServicio.Text;
            decimal costo = decimal.Parse(txtCosto.Text);
            string descripcion = txtDescripcion.Text;
            string requisitos = txtRequisitos.Text;
            if (txtRequisitos.Text == "")
            {
                txtRequisitos.Text = "Ninguno";
            }
            int idTipoServicio = (int)cbTipoServicio.SelectedValue; // Reemplaza con tu lógica para obtener el ID de tipo de servicio

            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection connection = cn.LeerCadena())
                {
                    connection.Open();

                    // Crear la consulta SQL para la inserción
                    string query = "INSERT INTO tblServicio (Nombre, Costo, Descripcion, Requisitos, ID_TipoServicio, FechaIngreso) " +
                                   "VALUES (@Nombre, @Costo, @Descripcion, @Requisitos, @ID_TipoServicio, getdate())";

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros
                        command.Parameters.AddWithValue("@Nombre", nombreServicio);
                        command.Parameters.AddWithValue("@Costo", costo);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@Requisitos", requisitos);
                        command.Parameters.AddWithValue("@ID_TipoServicio", idTipoServicio);

                        // Ejecutar la consulta SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }
        }

        Desplegables tp = new Desplegables();
        private void FrmServicios_Load(object sender, EventArgs e)
        {
            cbTipoServicio.DataSource = tp.TipoServicio();
            cbTipoServicio.DisplayMember = "Nombre";
            cbTipoServicio.ValueMember = "ID_TipoServicio";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtServicio.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtRequisitos.Text = string.Empty;
            cbTipoServicio.Text = string.Empty;
        }
    }
}
