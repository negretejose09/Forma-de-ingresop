using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_de_ingreso.Formas
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados por el usuario
            string nombre = textBoxNombre.Text;
            string apellidos = textBoxApellidos.Text;
            string email = textBoxEmail.Text;
            string contraseña = textBoxContraseña.Text;

            // Valida los datos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("El correo electrónico no es válido. Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Si llegamos aquí, los datos son válidos, puedes hacer lo que necesites con ellos
            // Por ejemplo, puedes guardarlos en una base de datos o realizar alguna otra operación.

            // Luego de manejar los datos, puedes mostrar un mensaje de éxito.
            MessageBox.Show("Datos registrados con éxito.");

            // Puedes limpiar los campos si es necesario
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxEmail.Clear();
            textBoxContraseña.Clear();

            // Ahora, crea y muestra la ventana capturendatos
            capturendatos capp = new capturendatos();
            capp.Show();
        }

        // Función para validar un correo electrónico
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
