using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Net.Http;
using Caja_Hospital.Clases;

namespace Caja_Hospital
{
    public partial class Inicio : Form
    {
        //Dios te ama
        public FormMainMenu MainForm { get; set; }
        public Inicio()
        {
            InitializeComponent();


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static int SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string cedula = txtUser.Text;
            string clave = txtPass.Text;

            // Verifica que los campos no estén vacíos
            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese cédula y contraseña.");
                return;
            }

            // Realiza la solicitud a la API
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://apicemed.somee.com/api/Empleado/Loggin/{cedula}/{clave}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Procesa la respuesta
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserializa el JSON a un objeto Empleado
                        Empleado empleado = JsonConvert.DeserializeObject<Empleado>(json);

                        // Verifica si la operación fue exitosa
                        if (empleado.operacion == "exitosa")
                        {
                            MessageBox.Show($"Bienvenido, {empleado.mensaje}.");
                            // Puedes realizar otras acciones después del inicio de sesión exitoso

                            // Cierra el formulario actual (Login)
                            this.Hide();

                            // Abre el formulario FormMainMenu
                            FormMainMenu formMainMenu = new FormMainMenu();
                            formMainMenu.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Error en la autenticación");
                        }
                    }
                    else
                    {
                        // Muestra un mensaje de error si la solicitud no fue exitosa
                        MessageBox.Show("Error en la solicitud a la API. Código: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir durante la solicitud
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
