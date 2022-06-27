using DesafioVendas.Classes;
using DesafioVendas.Conexao_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioVendas.Forms
{
    public partial class frm_estoque : Form
    {
        public frm_estoque()
        {
            InitializeComponent();
        }

        Estoque estoque = new Estoque();
        CRUD_estoque estoque_conn = new CRUD_estoque();
        Vendas venda = new Vendas();
        CRUD_vendas venda_conn = new CRUD_vendas();
        Compras compra = new Compras();
        CRUD_compras compra_conn = new CRUD_compras();
        Produto produto = new Produto();
        CRUD_produto produto_conn = new CRUD_produto();

        //LIMPA OS CAMPOS
        private void Limpar()
        {
            tb_id_estoque.Clear();
            tb_produto_estoque.Clear();
            tb_qtde_compras.Clear();
            tb_cod_barra_compras.Clear();
        }

        private void tb_produto_estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_produto_estoque.MaxLength = 50;
        }

        private void tb_produto_estoque_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_produto_estoque.Text = tb_produto_estoque.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_produto_estoque.Text = tb_produto_estoque.Text.Replace("  ", " ");
            }
        }

        private void tb_cod_barra_compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
            {
                e.Handled = true; // deixa digitar
            }
            tb_cod_barra_compras.MaxLength = 13;
        }

        private void bt_limpar_compra_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void pb_consultar_estoque_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string keywords;
            estoque.cod_barra = tb_cod_barra_compras.Text;
            estoque.nome_produto = tb_produto_estoque.Text;

            if (tb_cod_barra_compras == null && tb_produto_estoque == null)
            {
                MessageBox.Show("Para consultar, é necessário inserir o código de barra ou o produto");
            }
            else
            {
                keywords = tb_produto_estoque.Text;
                dt = estoque_conn.Search(keywords);
                tb_id_estoque.Text = dt.Rows[0]["id_estoque"].ToString();
                tb_produto_estoque.Text = dt.Rows[0]["nome_produto"].ToString();
                tb_cod_barra_compras.Text = dt.Rows[0]["cod_barra"].ToString();
                tb_qtde_compras.Text = dt.Rows[0]["qtde"].ToString();;
            }
        }
    }
}
