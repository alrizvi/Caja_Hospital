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
        Conexion cn = new Conexion();
        public FormResumen()
        {
            InitializeComponent();

            SqlConnection connection = cn.LeerCadena();
            
            //                             Modulo del Grafico
            //----------------------------------------------------------------------------------

            // Obtén la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcula la fecha de inicio hace 7 días
            DateTime fechaInicio = fechaActual.AddDays(-7);

            // Crea una consulta SQL para obtener los ingresos por día en el período de 7 días
            string query = "SELECT CONVERT(DATE, FechaIngreso) AS Fecha, SUM(Monto) AS Total " +
                            "FROM tblTransaccion " +
                            "WHERE FechaIngreso BETWEEN @FechaInicio AND @FechaFin " +
                            "GROUP BY CONVERT(DATE, FechaIngreso) " +
                            "ORDER BY CONVERT(DATE, FechaIngreso)";
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaActual);

                    // Crea un objeto ChartValues para almacenar los datos del gráfico
                    ChartValues<double> ingresosPorDia = new ChartValues<double>();

                    // Crea un objeto ChartValues para almacenar las etiquetas de los ejes X
                    ChartValues<string> etiquetasX = new ChartValues<string>();

                    // Ejecuta la consulta y obtén los resultados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega los ingresos por día al objeto ChartValues
                            double ingreso = Convert.ToDouble(reader["Total"]);
                            ingresosPorDia.Add(ingreso);

                            // Agrega las etiquetas de los ejes X (día) al objeto ChartValues
                            string dia = ((DateTime)reader["Fecha"]).ToString("dd/MM/yyyy");
                            etiquetasX.Add($"Día {dia}");
                        }
                    }

                    // Agrega los datos al gráfico y las etiquetas al eje X
                    cartesianChart1.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "Ingresos por Día",
                            Values = ingresosPorDia
                        }
                    };

                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Title = "Día",
                        Labels = etiquetasX
                    });
                }
            }
            //                        Modulo del total ingresado
            //----------------------------------------------------------------------------------

            // Crea una consulta SQL para obtener la suma de los montos
            string ingresoTotal = "SELECT SUM(Monto) FROM tblTransaccion";

            // Crea un comando SQL y ejecuta la consulta
            using (SqlCommand command = new SqlCommand(ingresoTotal, connection))
            {
                // Ejecuta la consulta y obtén el resultado
                decimal sumaMontos = Convert.ToDecimal(command.ExecuteScalar());

                // Asigna la suma de los montos al Label
                lblIngresoTotal.Text = sumaMontos.ToString(); // Formatea el resultado como moneda si es necesario
            }

            // Convierte la fecha actual a un formato que coincida con el de la base de datos (sin la hora)
            string fechaActualString = fechaActual.ToString("yyyy-MM-dd");

            // Crea una consulta SQL para obtener la suma de los montos del día actual
            string sumaDiaActual = "SELECT SUM(Monto) AS Total " +
                           "FROM tblTransaccion " +
                           "WHERE CONVERT(DATE, FechaIngreso) = @FechaActual";

            // Crea un comando SQL y asigna el parámetro de fecha
            using (SqlCommand command = new SqlCommand(sumaDiaActual, connection))
            {
                command.Parameters.AddWithValue("@FechaActual", fechaActualString);

                // Ejecuta la consulta y obtén el resultado
                object resultado = command.ExecuteScalar();

                if (resultado != DBNull.Value && resultado != null)
                {
                    // Convierte el resultado a un valor decimal y muestra en el Label
                    decimal sumaMontos = Convert.ToDecimal(resultado);
                    lblMontoCaja.Text = sumaMontos.ToString();
                }
                else
                {
                    // No hubo registros para la fecha actual, muestra un mensaje apropiado
                    lblMontoCaja.Text = "No hay registros.";
                }
            }
            //                    Modulo del monto en caja del día anterior
            //----------------------------------------------------------------------------------

            if (lblMontoCaja.Text != "No hay registros.")
            {
                // Obtener los valores de las etiquetas y convertirlos a números
                decimal cantidadEntrada = decimal.Parse(lblIngresoTotal.Text);
                decimal montoCaja = decimal.Parse(lblMontoCaja.Text);

                // Realizar la resta
                decimal resta = cantidadEntrada - montoCaja;

                // Mostrar ael resultado en la etiqueta lblResultado
                lblAperturaDia.Text = resta.ToString();
            }
            else
            {
                lblAperturaDia.Text = lblIngresoTotal.Text;
            }
                FormatoDinero();
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