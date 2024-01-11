using Caja_Hospital.Clases;
using Newtonsoft.Json;
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

namespace Caja_Hospital.Forms
{
    public partial class FrmServicios : Form
    {
        // URL de la API
        private const string ApiUrl = "http://apicemed.somee.com/api/Tipo_Servicio/BuscarTodos";

        public FrmServicios()
        {
            InitializeComponent();

            // Llamar a la función para cargar tipos de servicio al iniciar el formulario
            CargarTiposDeServicioAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public async Task CargarTiposDeServicioAsync()
        {
            try
            {
                // Realizar solicitud HTTP a la API
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(ApiUrl);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer el contenido de la respuesta
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserializar el JSON
                        var result = JsonConvert.DeserializeObject<ApiTipoServicio>(json);

                        // Verificar si la operación fue exitosa
                        if (result.operacion == "exitosa")
                        {
                            // Extraer la lista de tipos de servicio
                            List<TipoServicio> tiposDeServicio = result.data;

                            // Limpiar el ComboBox
                            cbTipoServicio.Items.Clear();

                            // Llenar el ComboBox con los nombres de los tipos de servicio
                            foreach (var tipoServicio in tiposDeServicio)
                            {
                                cbTipoServicio.Items.Add(tipoServicio.nombre);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en la operación: " + result.mensaje);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener tipos de servicio. Código de estado: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
