using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWinFormsApp
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        bindingSourceCliente.DataSource = new ClienteBLLcs().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceCliente.DataSource = new ClienteBLLcs().BuscarPorNomeCliente(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceCliente.DataSource = new ClienteBLLcs().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }




        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvarCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonInserirCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

