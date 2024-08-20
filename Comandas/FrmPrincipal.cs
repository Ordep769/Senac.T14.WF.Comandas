using Microsoft.EntityFrameworkCore;
using System;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        //método (visibilidade=private, retorno=
        private void CriarBancoDeDados()
        {

            //criar uma variavel do tipoAppDbContext
            //usar a variavel e acessar o contexto
            //excecutar a migração == F5
            using (var banco = new AppDbContext())
            {
                //executa a migração(CREATE TABLE Usuarios
                banco.Database.Migrate();
            }


        }


        // evento de click

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

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new FrmCardapio().ShowDialog();
        }
    }
}
