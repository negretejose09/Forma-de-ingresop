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
    public partial class capturendatos : Form
    {
        public capturendatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Referencia a un renglon DataGridView
                DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox2.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = textBox4.Text;
                renglon.Cells[4].Value = textBox5.Text;

                dataGridView1.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminar registro";

            if (!(dataGridView1.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminado estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes selecionar un renglon", "Eliminado estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes selecionar un renglon", "Modificando estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            }
        }
    }
}
