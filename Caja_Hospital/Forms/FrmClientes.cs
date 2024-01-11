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
using Caja_Hospital.Clases;


namespace Caja_Hospital.Forms
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red400, TextShade.WHITE);
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string cedula = txtDocumento.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string alergias = txtAlergias.Text;
            string enfermedades = txtEnfermedades.Text;
            string sexo = rbHombre.Checked ? "M" : "F";
            string seguro = "NO";  // Debes establecer el valor adecuado para el seguro
            string tipoSangre = txtTiposangre.Text;  // Debes establecer el valor adecuado para el tipo de sangre
            DateTime fechaIngreso = DateTime.UtcNow;  // Utiliza la fecha actual en formato UTC

            // Crear el objeto Cliente con los datos del formulario
            Cliente nuevoCliente = new Cliente
            {
                nombre = nombre,
                apellido = apellido,
                cedula = cedula,
                direccion = direccion,
                telefono = telefono,
                fecha_Nacimiento = fechaNacimiento,
                seguro = seguro,
                sexo = sexo,
                sangre = tipoSangre,
                enfermedades = enfermedades,
                alergias = alergias,
                fecha_Ingreso = fechaIngreso
            };

            // Convertir el objeto Cliente a JSON
            string jsonCliente = JsonConvert.SerializeObject(nuevoCliente);
            MessageBox.Show(jsonCliente);

            // Realizar la solicitud HTTP POST
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://apicemed.somee.com/api/Cliente/AgregarCliente";  // Reemplaza con la URL correcta de tu API
                    StringContent content = new StringContent(jsonCliente, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Procesar la respuesta si es necesario
                        MessageBox.Show("Cliente agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el cliente. Código de estado: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbTipoDocumento.Text = txtDocumento.Text = txtApellidos.Text = txtNombres.Text = txtFechaNacimiento.Text = txtAlergias.Text = txtEnfermedades.Text = txtTelefono.Text = txtCorreo.Text = txtDireccion.Text = string.Empty;
            
            if (rbHombre.Checked || rbMujer.Checked)
            {
                rbHombre.Checked = rbMujer.Checked = false;
            }
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

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Si no es una letra, ignora la tecla presionada
            }
        }

        private void txtFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es un número ni un guion, ignora la tecla presionada
            }

            // Verifica que no haya más de un guion en el texto
            if (e.KeyChar == '-' && txtFechaNacimiento.Text.Contains("-"))
            {
                e.Handled = true; // Si ya hay un guion, ignora la tecla presionada
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Si no es un número, ignora la tecla presionada
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '_' && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es un carácter permitido, ignora la tecla presionada
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '|' && e.KeyChar != '\'' && e.KeyChar != ',' && e.KeyChar != '`' && e.KeyChar != ' '  && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es una letra ni uno de los signos permitidos, ignora la tecla presionada
            }
        }

        private void txtTodos_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text != string.Empty && txtNombres.Text != string.Empty && txtApellidos.Text != string.Empty && txtFechaNacimiento.Text != string.Empty && txtTelefono.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }

            else
            {
                btnAgregar.Enabled = false;
                btnAgregar.ForeColor = Color.White;
            }
        }
    }
}