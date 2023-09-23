using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form_Application
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textid.Text, textnombres.Text, textcarrera.Text,textcorreo.Text,textcelular.Text);
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            textid.Text = "";
            textnombres.Text = "";
            textcarrera.Text = "";
            textcorreo.Text = "";
            textcelular.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

