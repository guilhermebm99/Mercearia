using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace UWinFormsApp
{
    public partial class FormBuscarUsuariocs : Form
    {
        public FormBuscarUsuariocs()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorNomeUsuario(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            int id = ((Usuario)bindingSourceUsuario.Current).Id;
            
            using (FormCadastrarUsuario frm = new FormCadastrarUsuario(id))
            {

                frm.ShowDialog();   
            }






        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            

            if (MessageBox.Show("Deseja excluir esse registro","Atenção",MessageBoxButtons.YesNo)==DialogResult.No)
            
                return;
            


            int id = ((Usuario)bindingSourceUsuario.Current).Id;
            new UsuarioBLL().Excluir(id);
            bindingSourceUsuario.RemoveCurrent();
            MessageBox.Show("Registro deletado");
        }
    }
}
