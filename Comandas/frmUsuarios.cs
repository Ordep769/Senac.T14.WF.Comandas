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
        private bool ehNovo;

        public frmUsuarios()
        {
            InitializeComponent();
            //metodo que lista os usuarios
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            //conectar no banco
            using (var banco = new AppDbContext())
            {
                //SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                // popular a tabela na telaDataGridView
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();

            Desabilitarcampos();
            ListarUsuarios();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            { // consulta um usuario na tabela usando o Id da tabela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();

                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuario
                var novoUsuario = new Usuario();
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;

                //salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuario cadastrado com sucesso");

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            Habilitarcampos();
        }

        private void Habilitarcampos()
        {
            txtNome.Enabled = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void Desabilitarcampos()
        {
            txtNome.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //indica que esta editando o usuario
            ehNovo = false;
            Habilitarcampos(); 
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            // Conectar no Banco
            using (var banco = new AppDbContext())
            {
                // realizar consulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                // Popular os dados do grid(dataGridView)
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se o indice da linha é maior ou igual a zero
            // saber se exixte uma linha selecionada
            if(e.RowIndex >= 0)
            {
                // menssagem "Linha selecionada 1"
                //MessageBox.Show("Linha selecionada " + (e.RowIndex + 1));

                //obter dados da linha
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();

                txtId.TextButton = id;
                txtNome.TextButton = nome;
                txtEmail.TextButton = email;
                txtSenha.TextButton = senha;

            }
        }
    }
}
