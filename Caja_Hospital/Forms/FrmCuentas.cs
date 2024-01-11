using Caja_Hospital.Clases;
using Newtonsoft.Json;
using System;
using System.Collections;
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
    public partial class FrmCuentas : Form
    {
        // URL de la API
        private const string TiposervicioUrl = "http://apicemed.somee.com/api/Tipo_Servicio/BuscarTodos";

        public FrmCuentas()
        {
            InitializeComponent();

            // Llamar a la función para cargar tipos de servicio al iniciar el formulario
            CargarTiposDeServicioAsync();
        }

        public async Task CargarTiposDeServicioAsync()
        {
            try
            {
                // Realizar solicitud HTTP a la API
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(TiposervicioUrl);

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

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            cbTipoServicio.DisplayMember = "Nombre";
            cbTipoServicio.ValueMember = "ID_TipoServicio";
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el valor seleccionado en cb1.
            string selectedValue = cbTipoServicio.SelectedValue.ToString();

            // Usa el valor seleccionado para llenar el segundo ComboBox (cb2).
            LoadComboBox2Data(selectedValue);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dataGridView1);
            file.Cells[0].Value = cbTipoServicio.Text;
            file.Cells[1].Value = cbServicio.Text;
            file.Cells[2].Value = txtCosto.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = float.Parse(txtCosto.Text) * float.Parse(txtCantidad.Text);

            dataGridView1.Rows.Add(file);
            
            cbTipoServicio.Text = cbServicio.Text = txtCosto.Text = "";
            txtCantidad.Text = "1";

            ObtenerTotal();

            if (rbTerjetaCredito.Checked == true)
            {
                txtPagado.Text = lblTotalAPagar.Text;
            }
        }

        private void LoadComboBox2Data(string selectedValue)
        {
            
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txtPagado.Text = "";
        }

        private void rbTerjetaCredito_CheckedChanged(object sender, EventArgs e)
        {
            txtPagado.Text = lblTotalAPagar.Text;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string celuda = txtDocumento.Text;

            try
            {
                // Construir la URL de la API con la cédula proporcionada
                string apiUrl = $"http://apicemed.somee.com/api/Cliente/BuscarCliente/{celuda}";

                // Realizar la solicitud HTTP GET
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Procesar la respuesta
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserializar el JSON a un objeto ClienteResponse
                        ClienteResponse clienteResponse = JsonConvert.DeserializeObject<ClienteResponse>(json);

                        // Verificar si la operación fue exitosa
                        if (clienteResponse.operacion == "exitosa")
                        {
                            // Asignar los valores a los controles del formulario
                            lblNombres.Text = $"{clienteResponse.data.nombre} {clienteResponse.data.apellido}";

                            // Almacenar el ID del cliente en una variable
                            int idCliente = clienteResponse.data.id_Cliente;

                            // Puedes usar idCliente según sea necesario
                        }
                        else
                        {
                            MessageBox.Show("Error: " + clienteResponse.mensaje);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error en la solicitud a la API. Código de estado: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ObtenerTotal()
        {
            float total = 0;
            int contador = 0;

            contador = dataGridView1.RowCount;

            for(int i = 0; i < contador; i++)
            {
                total += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            lblTotalAPagar.Text = total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar el servicio?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    ObtenerTotal();
                }
            }
            catch
            {
                // Manejo de excepciones, puedes agregar un MessageBox o registros de error aquí si es necesario
            }

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtPagado.Text) - float.Parse(lblTotalAPagar.Text)).ToString();
            }
            catch { }
        }

        private void lblTotalAPagar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("CEMED Hospital"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Cliente: " + lblNombres.Text);
            Ticket1.TextoIzquierda("Cedula: " + txtDocumento.Text);
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 00001");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Autorizado por: " + txtAutorizacion.Text);
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                                        // PROD                     PrECIO                                    CANT                                      TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }
            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblTotalAPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            if (rbTerjetaCredito.Checked == true)
            {
                Ticket1.AgregaTotales("Pagado con tarjeta", double.Parse(lblTotalAPagar.Text)); // imprime linea con Subtotal
            }
            else
            {
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtPagado.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));

            }
            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            txtDocumento.Text = lblNombres.Text = txtPagado.Text = lblDevolucion.Text = lblTotalAPagar.Text = "";
        }
    }
}
