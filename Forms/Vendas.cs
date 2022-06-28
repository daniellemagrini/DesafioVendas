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
        Estoque estoque = new Estoque();
        CRUD_estoque estoque_conn = new CRUD_estoque();

        //LIMPA OS CAMPOS
        private void Limpar()
        {
            tb_id_venda.Clear();
            tb_dt_venda.Clear();
            tb_cpf_cnpj_venda.Clear();
            tb_cliente_venda.Clear();
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
            tb_cliente_venda.Enabled = false;
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
            tb_cliente_venda.Enabled = true;
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
            if(tb_cpf_cnpj_venda.Text != "")
            {
                DataTable dt = new DataTable();
                string keywords;
                venda.cpf_cnpj_cliente = tb_cpf_cnpj_venda.Text;
                venda.nome_cliente = tb_cliente_venda.Text;
                keywords = tb_cpf_cnpj_venda.Text;
                dt = cliente_conn.Search(keywords);

                if (dt.Rows.Count > 0)
                {
                    pb_cadastrar_venda.Enabled = true;
                    tb_cliente_venda.Text = dt.Rows[0]["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                    pb_cadastrar_venda.Enabled = false;
                }
            }
            else
            {
                return;
            }
        }

        private void tb_cod_barra_venda_Leave(object sender, EventArgs e)
        {
            if (tb_cod_barra_venda.Text != "")
            {
                DataTable dt = new DataTable();
                string keywords;
                venda.cod_barra = tb_cod_barra_venda.Text;
                venda.nome_produto = tb_produto_venda.Text;
                keywords = tb_cod_barra_venda.Text;
                dt = produto_conn.Search(keywords);

                if (dt.Rows.Count > 0)
                {
                    pb_cadastrar_venda.Enabled = true;
                    tb_produto_venda.Text = dt.Rows[0]["nome_produto"].ToString();
                    tb_vl_produto_venda.Text = dt.Rows[0]["valor_venda"].ToString();
                    venda.valor_produto = Convert.ToDouble(tb_vl_produto_venda.Text);
                    tb_desconto_venda.Text = "0.00";
                    tb_qtde_produto_venda.Text = "1";
                    venda.qtde = Convert.ToInt32(tb_qtde_produto_venda.Text);
                    venda.desconto = Convert.ToDouble(tb_desconto_venda.Text);
                    venda.valor_produto = Convert.ToDouble(tb_vl_produto_venda.Text);
                    venda.valor_total = (venda.valor_produto * venda.qtde) - venda.desconto;
                    tb_vl_total_venda.Text = Convert.ToString(venda.valor_total);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                    pb_cadastrar_venda.Enabled = false;
                }
            }
            else
            {
                return;
            }
        }

        private void bt_limpar_vendas_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void tb_qtde_produto_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
            {
                e.Handled = true; // deixa digitar
            }
            tb_qtde_produto_venda.MaxLength = 10;
        }

        private void tb_desconto_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DEIXA DIGITAR APENAS UMA VEZ OU O PONTO OU A VIRGULA E NÃO ACEITA NADA ALÉM DE NÚMEROS E PONTO E VIRGULA
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //Troca o ponto pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (tb_desconto_venda.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //Aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            tb_desconto_venda.MaxLength = 10;
        }

        private void tb_desconto_venda_Leave(object sender, EventArgs e)
        {
            if (tb_desconto_venda.Text != "")
            {
                venda.qtde = Convert.ToInt32(tb_qtde_produto_venda.Text);
                venda.desconto = Convert.ToDouble(tb_desconto_venda.Text);
                venda.valor_produto = Convert.ToDouble(tb_vl_produto_venda.Text);
                venda.valor_total = (venda.valor_produto * venda.qtde) - venda.desconto;
                tb_vl_total_venda.Text = Convert.ToString(venda.valor_total);
            }
            else
            {
                return;
            }
        }

        private void tb_qtde_produto_venda_Leave(object sender, EventArgs e)
        {
            if (tb_qtde_produto_venda.Text != "")
            {
                venda.qtde = Convert.ToInt32(tb_qtde_produto_venda.Text);
                venda.desconto = Convert.ToDouble(tb_desconto_venda.Text);
                venda.valor_produto = Convert.ToDouble(tb_vl_produto_venda.Text);
                venda.valor_total = (venda.valor_produto * venda.qtde) - venda.desconto;
                tb_vl_total_venda.Text = Convert.ToString(venda.valor_total);
            }
            else
            {
                return;
            }
        }

        private void pb_consultar_venda_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string keywords;
            venda.data_venda = tb_dt_venda.Text;
            venda.cpf_cnpj_cliente = tb_cpf_cnpj_venda.Text;
            venda.nome_cliente = tb_cliente_venda.Text;
            venda.nome_produto = tb_produto_venda.Text;
            venda.qtde = Convert.ToInt32(tb_qtde_produto_venda.Text);
            venda.cod_barra = tb_cod_barra_venda.Text;
            venda.valor_produto = Convert.ToDouble(tb_vl_produto_venda.Text);
            venda.desconto = Convert.ToDouble(tb_desconto_venda.Text);
            venda.valor_total = Convert.ToDouble(tb_vl_total_venda.Text);


            if (tb_cpf_cnpj_venda == null)
            {
                MessageBox.Show("Para consultar, é necessário inserir o CPF/CNPJ");
            }
            else
            {
                keywords = tb_cpf_cnpj_venda.Text;
                dt = venda_conn.Search(keywords);
                tb_id_venda.Text = dt.Rows[0]["id_venda"].ToString();
                tb_dt_venda.Text = dt.Rows[0]["data_venda"].ToString();
                tb_cpf_cnpj_venda.Text = dt.Rows[0]["cpf_cnpj_cliente"].ToString();
                tb_cliente_venda.Text = dt.Rows[0]["nome_cliente"].ToString();
                tb_produto_venda.Text = dt.Rows[0]["nome_produto"].ToString();
                tb_qtde_produto_venda.Text = dt.Rows[0]["qtde"].ToString();
                tb_cod_barra_venda.Text = dt.Rows[0]["cod_barra"].ToString();
                tb_vl_produto_venda.Text = dt.Rows[0]["valor_produto"].ToString();
                tb_desconto_venda.Text = dt.Rows[0]["desconto"].ToString();
                tb_vl_total_venda.Text = dt.Rows[0]["valor_total"].ToString();

                DesabilitarCampos();
            }
        }

        private void pb_cadastrar_venda_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O CAMPO ESTÁ VAZIO
            Tratamento ttb = new Tratamento();
            if (ttb.CampoVazio(tb_dt_venda, "DATA"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_cpf_cnpj_venda, "CPF/CNPJ"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_cod_barra_venda, "CÓDIGO DE BARRA"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_qtde_produto_venda, "QUANTIDADE"))
            {
                return;
            }

            //INSERE NO BD
            venda.data_venda = tb_dt_venda.Text;
            venda.cpf_cnpj_cliente = tb_cpf_cnpj_venda.Text;
            venda.nome_cliente = tb_cliente_venda.Text;
            venda.nome_produto = tb_produto_venda.Text;
            venda.qtde = Convert.ToInt32(tb_qtde_produto_venda.Text);
            venda.cod_barra = tb_cod_barra_venda.Text;
            venda.valor_produto = Convert.ToDouble(tb_vl_produto_venda.Text);
            venda.desconto = Convert.ToDouble(tb_desconto_venda.Text);
            venda.valor_total = Convert.ToDouble(tb_vl_total_venda.Text);
            estoque.nome_produto = tb_cliente_venda.Text;
            estoque.cod_barra = tb_cod_barra_venda.Text;
            estoque.qtde = Convert.ToInt32(tb_qtde_produto_venda.Text);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            string cod;
            cod = tb_cod_barra_venda.Text;
            dt = estoque_conn.Search(cod);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Produto não consta cadastrado no estoque!");
                Limpar();
            }
            else
            {
                string id_estoque = dt.Rows[0]["id_estoque"].ToString();
                string qtde = dt.Rows[0]["qtde"].ToString();
                estoque.id_estoque = Convert.ToInt32(id_estoque);
                int qtde_estoque = Convert.ToInt32(qtde);
                int qtde_venda = Convert.ToInt32(tb_qtde_produto_venda.Text);
                estoque.qtde = Convert.ToInt32(qtde_estoque) - Convert.ToInt32(tb_qtde_produto_venda.Text);

                if (qtde_venda > qtde_estoque)
                {
                    MessageBox.Show("Não temos quantidade suficiente em estoque");
                }
                else
                {
                    bool sucess = venda_conn.Insert(venda);
                    bool sucessEst = estoque_conn.Update(estoque);

                    if (sucessEst == true && sucessEst == true)
                    {
                        //DA A MENSAGEM PARA AVISAR QUE FOI CADASTRADO OU NÃO E LIMPA TODOS OS CAMPOS
                        MessageBox.Show("Venda Cadastrada com sucesso!");
                        Limpar();
                    }
                    else
                    {

                        MessageBox.Show("Não foi possível realizar a venda! Favor tentar novamente ou entrar em contato com o suporte do sistema.");
                    }
                }
            }                   
        }
    }
}
