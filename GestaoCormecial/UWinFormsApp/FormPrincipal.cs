namespace UWinFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usu�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuariocs frm = new FormBuscarUsuariocs())
            {
                frm.ShowDialog();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente frm = new FormBuscarCliente())
            {
                frm.ShowDialog();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }
        }
    }
}