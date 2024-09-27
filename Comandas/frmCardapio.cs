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
    public partial class FrmCardapio : Form
    {
        public int ID { get; private set; }
        public string? TITULO { get; private set; }
        public string? DESCRICAO { get; private set; }
        public decimal PRECO { get; private set; }
        public bool POSSUIPREPARO { get; private set; }

        public FrmCardapio()
        {

            InitializeComponent();
            ListarCardapio();
        }

        private void ListarCardapio()
        {
            using (var banco = new AppDbContext())
            {
                var cardapio = banco.Cardapio.ToList();
                dgvCardapio.DataSource = cardapio;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var ehNovo = true;
            new frmCardapioCad(ehNovo).ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new frmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUIPREPARO).ShowDialog();
        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtem o numero da linha clicada
            var numeroLinha = e.RowIndex;
            // Verifica se alguma linha foi selecionada
            if (numeroLinha >= 0 )
            {
                var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

                //Converter para os tipos corretos
                ID = int .Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUIPREPARO = bool.Parse(possuiPreparo);


                //habilitar o botão Editar e botão Excluir
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
