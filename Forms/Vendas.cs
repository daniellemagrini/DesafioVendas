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
    public partial class frm_vendas : Form
    {
        public frm_vendas()
        {
            InitializeComponent();
        }

        Vendas venda = new Vendas();
        CRUD_vendas venda_conn = new CRUD_vendas();
        Cliente cliente = new Cliente();
        CRUD_cliente cliente_conn = new CRUD_cliente();
        Produto produto = new Produto();
        CRUD_produto produto_conn = new CRUD_produto();

        //LIMPA OS CAMPOS
        private void Limpar()
        {
            tb_id_venda.Clear();
            tb_dt_venda.Clear();
            tb_cpf_cnpj_venda.Clear();
            tb_produto_venda.Clear();
            tb_qtde_produto_venda.Clear();
            tb_cod_barra_venda.ResetText();
            tb_vl_produto_venda.Clear();
            tb_desconto_venda.Clear();
            tb_vl_total_venda.Clear();
        }

        //DISABILIDA OS CAMPOS
        private void DesabilitarCampos()
        {
            tb_dt_venda.Enabled = false;
            tb_cpf_cnpj_venda.Enabled = false;
            tb_produto_venda.Enabled = false;
            tb_qtde_produto_venda.Enabled = false;
            tb_cod_barra_venda.Enabled = false;
            tb_vl_produto_venda.Enabled = false;
            tb_desconto_venda.Enabled = false;
            tb_vl_total_venda.Enabled = false;
        }

        //HABILITA OS CAMPOS
        private void HabilitarCampos()
        {
            tb_dt_venda.Enabled = true;
            tb_cpf_cnpj_venda.Enabled = true;
            tb_produto_venda.Enabled = true;
            tb_qtde_produto_venda.Enabled = true;
            tb_cod_barra_venda.Enabled = true;
            tb_vl_produto_venda.Enabled = true;
            tb_desconto_venda.Enabled = true;
            tb_vl_total_venda.Enabled = true;
        }

        private void tb_dt_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_dt_venda.MaxLength = 10;
        }

        private void tb_cpf_cnpj_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_cpf_cnpj_venda.MaxLength = 14;
        }

        private void tb_cpf_cnpj_venda_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string keywords;
            venda.cpf_cnpj_cliente = tb_cpf_cnpj_venda.Text;
            venda.nome_cliente = tb_cliente_venda.Text;
            keywords = tb_cpf_cnpj_venda.Text;
            dt = cliente_conn.Search(keywords);
            tb_cliente_venda.Text = dt.Rows[0]["nome"].ToString();
        }

        private void tb_cod_barra_venda_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string keywords;
            venda.cod_barra = tb_cod_barra_venda.Text;
            venda.nome_produto = tb_produto_venda.Text;
            keywords = tb_cod_barra_venda.Text;
            dt = produto_conn.Search(keywords);
            tb_produto_venda.Text = dt.Rows[0]["nome_produto"].ToString();
            tb_vl_produto_venda.Text = dt.Rows[0]["valor_venda"].ToString();
        }

        private void bt_limpar_vendas_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
