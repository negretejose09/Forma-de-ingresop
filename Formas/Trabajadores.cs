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
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar los datos aquí, por ejemplo, asegurarse de que los campos no estén vacíos.

            // Capturar datos del formulario
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string Edad = textBox3.Text;
            string Cargo = textBox4.Text;
            string Salario = textBox5.Text;

            // Agregar los datos a la DataGridView
            dataGridView1.Rows.Add(nombre, apellido, Edad, Cargo, Salario);

            // Limpiar los campos del formulario
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
