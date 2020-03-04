using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Formularios
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            CargarFechas();
        }
        public void GuardarEnBD()
        {
            ClienteEntidades cliente = new ClienteEntidades();
            cliente.TipoDocumento = txtTipoDocumento.Text;
            

        }
        private void CargarFechas()
        {
            for (int dia = 1; dia <= 31; dia++)
            {
                txtdia.Items.Add(dia);
            }
            int aux = DateTime.Now.Year;
            for (int anyo = 1900; anyo <= 2020; anyo++)
            {
                txtAño.Items.Add(anyo);
            }
        }
        if(txtTipoDocumento.SelectedIndex.Equals(-1))
           {
              
           }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label11_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  
         
    }
}
