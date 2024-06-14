namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // evento de click
        private void metroButton4_Click(object sender, EventArgs e)
        {
            ///criar formulario e exiba
            new frmCardapio().ShowDialog();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new frmCardapio().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new frmPedidoCozinha().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new frmUsuarios().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // encerra o aplicativo
            Application.Exit();
        }
    }
}
