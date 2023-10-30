using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forma_de_ingreso.Formas;

namespace Forma_de_ingreso
{
    public partial class Form1 : Form
    {
        private int intentosRestantes = 3;
        private const string usuarioCorrecto = "miriam";
        private const string contraseñaCorrecta = "landeros070411";
        private bool formularioBloqueado = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (formularioBloqueado)
            {
                MessageBox.Show("Has llegado al limite de intentos,intente mas tarde");
                Application.Exit();
                return;
            }

            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingresa tus datos porfavor");
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.");
            }
            else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Contraseña incorrecta,te quedan: " + intentosRestantes);
                }
                else
                {
                    BloquearFormulario();
                }
            }
            else if (usuario != usuarioCorrecto && contraseña == contraseñaCorrecta+" intentos")
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Usuario incorrecto,te quedan: " + intentosRestantes+" intentos");
                }
                else
                {
                    BloquearFormulario();
                }
            }
            else if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                MessageBox.Show("Bienvenido");
                this.Hide(); // Oculta la ventana de login
                // Aquí debes mostrar la pantalla principal o realizar cualquier otra acción que desees.

                capturendatos captura = new capturendatos();
                captura.Show();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos.");
            }

        }
        private void BloquearFormulario()
        {
            MessageBox.Show("Ya no puedes intentar más. La aplicación se cerrará.");
            formularioBloqueado = true;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro regi = new Registro();
            regi.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
