using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_12_Felipe_Relac_1000
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frm_Clientes frm_Clientes = new frm_Clientes();
            frm_Clientes.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm_Produtos = new frm_Produtos();
            frm_Produtos.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frm_Vendas frm_Vendas = new frm_Vendas();
            frm_Vendas.Show();
        }
    }
}
