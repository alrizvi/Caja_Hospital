using FontAwesome.Sharp;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Policy;


namespace Caja_Hospital.Forms
{
    public partial class FrmClientes : Form
    {
        Conexion cn = new Conexion();
        public FrmClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red400, TextShade.WHITE);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {

        }
        private void cbTipoDocumento_MouseLeave(object sender, EventArgs e)
        {

        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }
        private void txtDocumento_MouseLeave(object sender, EventArgs e)
        {

        }
        private void cbTipoDocumento_Enter(object sender, EventArgs e)
        {
            if (cbTipoDocumento.Text == "Tipo de documento")
            {
                cbTipoDocumento.Text = "";
            }
        }
        private void cbTipoDocumento_Leave(object sender, EventArgs e)
        {
            if (cbTipoDocumento.Text == "")
            {
                cbTipoDocumento.Text = "Tipo de documento";
            }
        }
        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "Documento")
            {
                txtDocumento.Text = "";
            }
        }
        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                txtDocumento.Text = "Documento";
            }
        }
        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Text = "";
            }
        }
        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
            }
        }
        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if (txtNombres.Text == "Nombres")
            {
                txtNombres.Text = "";
            }
        }
        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                txtNombres.Text = "Nombres";
            }
        }
        private void txtSexo_Enter(object sender, EventArgs e)
        {
           
        }
        private void txtSexo_Leave(object sender, EventArgs e)
        {
           
        }
        private void dtpFechaNacimiento_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            // Datos a insertar
            int tipoDocumento = (cbTipoDocumento.SelectedItem.ToString() == "Cedula") ? 2 : 1;
            string documento = txtDocumento.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string sexo = "";
            if (rbHombre.Checked)
            {
                
                sexo = "M";
            }
            else
            {
                
                sexo = "F";
            }
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string alergias = txtAlergias.Text;
            if (txtAlergias.Text == "")
            {
                alergias = "Ninguna";
            }
            
            string enfermedades = txtEnfermedades.Text;
            if (txtEnfermedades.Text == "")
            {
                enfermedades = "Ninguna";
            }
            
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;

            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection connection = cn.LeerCadena())
                {
                    // Crear la consulta SQL para la inserción
                    string query = "INSERT INTO tblPaciente (TipoDocumento, Documento, Nombres, Apellidos, Sexo, FechaNacimiento, Alergias, Enfermedades, Telefono, Correo, Direccion) " +
                                   "VALUES (@TipoDocumento, @Documento, @Nombres, @Apellidos, @Sexo, @FechaNacimiento, @Alergias, @Enfermedades, @Telefono, @Correo, @Direccion)";

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros
                        command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                        command.Parameters.AddWithValue("@Documento", documento);
                        command.Parameters.AddWithValue("@Nombres", nombres);
                        command.Parameters.AddWithValue("@Apellidos", apellidos);
                        command.Parameters.AddWithValue("@Sexo", sexo);
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@Alergias", alergias);
                        command.Parameters.AddWithValue("@Enfermedades", enfermedades);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Direccion", direccion);

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

        private void txtFechaNacimiento_Enter(object sender, EventArgs e)
        {
            
        }
        private void txtFechaNacimiento_Leave(object sender, EventArgs e)
        {
            if (txtFechaNacimiento.Text == "")
            {
                txtFechaNacimiento.Text = "Fecha de nacimiento";
            }
        }
        private void txtAlergias_Enter(object sender, EventArgs e)
        {
            if (txtAlergias.Text == "Alergias")
            {
                txtAlergias.Text = "";
            }
        }
        private void txtAlergias_Leave(object sender, EventArgs e)
        {
            if (txtAlergias.Text == "")
            {
                txtAlergias.Text = "Alergias";
            }
        }
        private void txtEnfermedades_Enter(object sender, EventArgs e)
        {
            if (txtEnfermedades.Text == "Enfermedades")
            {
                txtEnfermedades.Text = "";
            }
        }
        private void txtEnfermedades_Leave(object sender, EventArgs e)
        {
            if (txtEnfermedades.Text == "")
            {
                txtEnfermedades.Text = "Enfermedades";
            }
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
            }
        }
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
            }
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Direccion";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbTipoDocumento.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtNombres.Text = string.Empty;
            if (rbHombre.Checked || rbMujer.Checked)
            {
                rbHombre.Checked = false;
                rbMujer.Checked = false;
            }
            txtFechaNacimiento.Text = string.Empty;
            txtAlergias.Text = string.Empty;
            txtEnfermedades.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string parteFinalURL = txtDocumento.Text; // Obtener el valor del TextBox

                    string urlBaseAPI = "https://api.adamix.net/apec/cedula/";
                    string urlCompleta = urlBaseAPI + parteFinalURL; // Construir la URL completa


                    // Realiza la solicitud GET a la API
                    HttpResponseMessage response = await client.GetAsync(urlCompleta);

                    // Verifica si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena JSON
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserializa la respuesta JSON en un objeto
                        var data = JsonConvert.DeserializeObject<ApiData>(json);

                        if (data.IdSexo == "F")
                        {
                            rbMujer.Checked = true;
                        }
                        if (data.IdSexo == "M")
                        {
                            rbHombre.Checked = true;
                        }

                        // Muestra los datos en los TextBoxes
                        txtDocumento.Text = data.Cedula;
                        txtNombres.Text = data.Nombres;
                        txtApellidos.Text = data.Apellido1 + " " + data.Apellido2;
                        txtFechaNacimiento.Text = data.FechaNacimiento;

                        // Añade más TextBoxes y propiedades según tus necesidades
                    }
                    else
                    {
                        MessageBox.Show("La solicitud a la API falló.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Clase para deserializar la respuesta JSON de la API
        public class ApiData
        {
            public string Cedula { get; set; }
            public string Nombres { get; set; }
            public string Apellido1 { get; set; }
            public string Apellido2 { get; set; }
            public string FechaNacimiento { get; set; }
            public string IdSexo { get; set; } 
            // Añade más propiedades según los datos que necesites
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDocumento.Text = string.Empty;
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(txtDocumento.Text)
            {
                case "Cédula":

                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true; // Si no es un número, ignora la tecla presionada
                    }

                    break;

                case "Pasaporte":

                    if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true; // Si no es una letra ni un número, ignora la tecla presionada
                    }

                    break;
            }
        }
    }
}
