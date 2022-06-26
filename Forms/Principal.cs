using DesafioVendas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioVendas
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void bt_cliente_principal_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Cliente)
            frm_clientes frm = new frm_clientes();
            frm.Show();
        }

        private void pb_cliente_principal_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Cliente)
            frm_clientes frm = new frm_clientes();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Cliente)
            frm_clientes frm = new frm_clientes();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Compras)
            frm_compras frm = new frm_compras();
            frm.Show();
        }

        private void pb_produto_principal_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Compras)
            frm_compras frm = new frm_compras();
            frm.Show();
        }

        private void bt_produto_principal_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Compras)
            frm_compras frm = new frm_compras();
            frm.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Compras)
            frm_compras frm = new frm_compras();
            frm.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Cliente)
            frm_clientes frm = new frm_clientes();
            frm.Show();
        }

        private void bt_caixa_principal_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Vendas)
            frm_vendas frm = new frm_vendas();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Vendas)
            frm_vendas frm = new frm_vendas();
            frm.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Vendas)
            frm_vendas frm = new frm_vendas();
            frm.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Estoque)
            frm_estoque frm = new frm_estoque();
            frm.Show();
        }

        private void pb_estoque_principal_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Estoque)
            frm_estoque frm = new frm_estoque();
            frm.Show();
        }

        private void bt_estoque_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Estoque)
            frm_estoque frm = new frm_estoque();
            frm.Show();
        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            Application.Exit();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abre um novo form (Caixa)
            frm_caixa frm = new frm_caixa();
            frm.Show();
        }
    }
}
