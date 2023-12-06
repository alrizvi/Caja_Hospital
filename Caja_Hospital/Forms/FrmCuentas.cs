using System;
using System.Collections;
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
    public partial class FrmCuentas : Form
    {
        Conexion cn = new Conexion();
        public FrmCuentas()
        {
            InitializeComponent();

        }

        Desplegables tp = new Desplegables();
        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            cbTipoServicio.DataSource = tp.TipoServicio();
            cbTipoServicio.DisplayMember = "Nombre";
            cbTipoServicio.ValueMember = "ID_TipoServicio";
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = cn.LeerCadena();
                // Obtén el ID del servicio seleccionado en el ComboBox cbServicio
                string idServicio = cbServicio.SelectedValue.ToString();

                // Construye la consulta SQL para obtener el costo del servicio
                string query = "SELECT Costo FROM tblServicio WHERE ID_Servicio = @IdServicio";

                // Crea un nuevo comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asigna el parámetro @IdServicio con el valor seleccionado
                    command.Parameters.AddWithValue("@IdServicio", idServicio);

                    // Ejecuta la consulta SQL y obtiene el valor
                    object costo = command.ExecuteScalar();

                    // Verifica si se obtuvo un valor válido
                    if (costo != null && costo != DBNull.Value)
                    {
                        // Muestra el costo en el TextBox txtCosto
                        txtCosto.Text = costo.ToString();
                    }
                }
            }
            catch
            {
            }
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
            try
            {
                // Construye la consulta SQL para llenar cbServicio usando el valor seleccionado de cb1.
                SqlConnection connection = cn.LeerCadena();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblServicio WHERE ID_TipoServicio = @SelectedValue", connection);
                da.SelectCommand.CommandType = CommandType.Text;

                // Aquí asignamos el parámetro en el objeto SqlCommand, no en SqlDataAdapter.
                da.SelectCommand.Parameters.AddWithValue("@SelectedValue", selectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbServicio.DataSource = dt;
                cbServicio.DisplayMember = "Nombre"; // Ajusta a la columna deseada
                cbServicio.ValueMember = "ID_Servicio"; // Ajusta a la columna deseada
            }
            catch
            {

            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txtPagado.Text = "";
        }

        private void rbTerjetaCredito_CheckedChanged(object sender, EventArgs e)
        {
            txtPagado.Text = lblTotalAPagar.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = cn.LeerCadena();
            // Obtén la cédula ingresada en el txtDocumento
            string documento = txtDocumento.Text;

            string query = "SELECT Nombres + ' ' + Apellidos AS NombreCompleto FROM tblPaciente WHERE Documento = @Documento";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Documento", documento);

                // Ejecuta la consulta
                object result = command.ExecuteScalar();

                // Verifica si se encontró un paciente con la cédula
                if (result != null)
                {
                    // Si se encontró, muestra el nombre completo en el txtNombres
                    txtNombres.Text = result.ToString();
                }
                else
                {
                    // Si no se encontró, muestra un mensaje indicando que no existe el paciente
                    MessageBox.Show("No se encontró ningún paciente con la cédula ingresada.");
                    txtNombres.Text = string.Empty; // Limpia el TextBox si no se encuentra un paciente
                }
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
            catch (Exception ex)
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
            // Crear una conexión a la base de datos
            SqlConnection connection = cn.LeerCadena();

            // Variables para almacenar los valores
            int idPaciente;
            int idServicio;

                // Consulta SQL para obtener el ID_Paciente en función del Documento
                string queryPaciente = "SELECT ID_Paciente FROM tblPaciente WHERE Documento = @Documento";

                using (SqlCommand commandPaciente = new SqlCommand(queryPaciente, connection))
                {
                    // Establecer el parámetro @Documento
                    string selectedDoc = txtDocumento.Text;
                    commandPaciente.Parameters.AddWithValue("@Documento", selectedDoc);

                    // Ejecutar la consulta SQL y obtener el resultado
                    object resultPaciente = commandPaciente.ExecuteScalar();

                    // Si se encuentra un resultado, asignar el ID_Paciente a la variable
                    idPaciente = Convert.ToInt32(resultPaciente);
                }

                // Consulta SQL para obtener el ID_Servicio en función del nombre de servicio
                string selectedServicio = cbServicio.Text;
                string queryServicio = "SELECT ID_Servicio FROM tblServicio WHERE Nombre = @Nombre";

                using (SqlCommand commandServicio = new SqlCommand(queryServicio, connection))
                {
                    // Establecer el parámetro @NombreServicio
                    commandServicio.Parameters.AddWithValue("@Nombre", selectedServicio);

                    // Ejecutar la consulta SQL y obtener el resultado
                    object resultServicio = commandServicio.ExecuteScalar();

                    // Si se encuentra un resultado, asignar el ID_Servicio a la variable
                    idServicio = Convert.ToInt32(resultServicio);
                }

            // Datos a insertar
            string metodoPago;

            if (rbTerjetaCredito.Checked)
            {

                metodoPago = "Tarjeta de credito";
            }
            else
            {

                metodoPago = "Efectivo";
            }

            decimal monto = decimal.Parse(lblTotalAPagar.Text);
            string autorizacion = txtAutorizacion.Text;

            try
            {
                // Establecer la conexión a la base de datos
                using (connection)
                {
                    // Crear la consulta SQL para la inserción
                    string query = "INSERT INTO tblTransaccion (Metodo_Pago, Monto, Autorizacion, ID_Paciente, ID_Servicio) " +
                                   "VALUES (@MetodoPago, @Monto, @Autorizacion, @IDPaciente, @IDServicio)";

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros
                        command.Parameters.AddWithValue("@MetodoPago", metodoPago);
                        command.Parameters.AddWithValue("@Monto", monto);
                        command.Parameters.AddWithValue("@Autorizacion", autorizacion);
                        command.Parameters.AddWithValue("@IDPaciente", idPaciente);
                        command.Parameters.AddWithValue("@IDServicio", idServicio);

                        // Ejecutar la consulta SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Los datos de la transacción se han insertado correctamente en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos de la transacción: " + ex.Message);
            }


            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("CEMED Hospital"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Cliente: " + txtNombres.Text);
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

            txtDocumento.Text = txtNombres.Text = txtPagado.Text = lblDevolucion.Text = lblTotalAPagar.Text = "";
        }
    }
}
