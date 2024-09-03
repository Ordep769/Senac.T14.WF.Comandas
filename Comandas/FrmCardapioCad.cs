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
    public partial class frmCardapioCad : Form
    {   //variavel que indica que esta criando um novo cardapio
        // bool =  true, false
        bool ehNovo = false;
        public frmCardapioCad(bool acao)
        {
            ehNovo = acao;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se o form esta em modo de inclusão
            if (ehNovo)
            {
                // Executa o método que realiza o INSERT na tabela
                adicionarCardapio();
            }
            else
            {   // Executa o método que realiza o UPDATE na tabela
                AtualizarCardapio();
            } // Fecha a tela atual
            Close();
        }

        private void AtualizarCardapio()
        {
            // Conecta no banco de dados
            using ( var banco = new AppDbContext())
            {
                var cardapio = banco.Cardapio.FirstOrDefault(c => c.Id == int.Parse(TxtId.TextButton));


                cardapio.Titulo = TxtTitulo.TextButton;
                cardapio.Descrição = TxtDescrição.TextButton;
                cardapio.Preço = decimal.Parse(TxtPreço.TextButton);
                cardapio.PossuiPreparo = chkPossuiPreparo.Checked;
                banco.SaveChanges();

            }
        }

        private void adicionarCardapio()
        {
            // Usar o banco de dados
            // Cria uma variavel banco que instancia uma conexao com o banco de dados
            using(var banco = new AppDbContext())
            {
                var novoCardapio = new Cardapio()
                {
                    Titulo = TxtTitulo.TextButton,
                    Descrição = TxtDescrição.TextButton,
                    Preço = Decimal.Parse(TxtPreço.TextButton),
                    PossuiPreparo = chkPossuiPreparo.Checked,
                };
                banco.Cardapio.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
