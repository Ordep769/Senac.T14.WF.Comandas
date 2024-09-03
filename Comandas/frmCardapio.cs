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
        public FrmCardapio()
        {
            
            InitializeComponent();
            ListarCardapio();
        }

        private void ListarCardapio()
        {
            using(var banco = new AppDbContext())
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
            new frmCardapioCad(ehNovo).ShowDialog();
        }
    }
}
