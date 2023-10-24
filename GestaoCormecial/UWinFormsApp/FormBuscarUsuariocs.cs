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

                bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarTodos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
                throw;
            }




        }
    }
}
