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
    }
}