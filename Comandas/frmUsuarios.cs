using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //medoto que ira inserir o usuario no banco
            CriarUsuario();
            //atualizarUsuario();
        }

        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuario
                var novoUsuario = new Usuario();
                novoUsuario.Nome = "Pedro";
                novoUsuario.Email = "pedro@gmail.com";
                novoUsuario.Senha = "hop";

                //salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuario cadastrado com sucesso");

            }
        }
    }
}
