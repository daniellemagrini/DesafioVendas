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
    public partial class frm_compras : Form
    {
        public frm_compras()
        {
            InitializeComponent();
        }

        Compras compra = new Compras();
        CRUD_compras compra_conn = new CRUD_compras();
        Produto produto = new Produto();
        CRUD_produto produto_conn = new CRUD_produto();
        Estoque estoque = new Estoque();
        CRUD_estoque estoque_conn = new CRUD_estoque();

        //LIMPA OS CAMPOS
        private void Limpar()
        {
            tb_id_compras.Clear();
            tb_nf_compras.Clear();
            tb_dt_entrada_compras.Clear();
            tb_produto_compras.Clear();
            tb_cod_barra_compras.Clear();
            tb_qtde_compras.Clear();
            tb_vl_compra_produto.Clear();
        }

        //DISABILIDA OS CAMPOS
        private void DesabilitarCampos()
        {
            tb_nf_compras.Enabled = false;
            tb_dt_entrada_compras.Enabled = false;
            tb_produto_compras.Enabled = false;
            tb_cod_barra_compras.Enabled = false;
            tb_qtde_compras.Enabled = false; ;
            tb_vl_compra_produto.Enabled = false;
        }

        //HABILITA OS CAMPOS
        private void HabilitarCampos()
        {
            tb_nf_compras.Enabled = true;
            tb_dt_entrada_compras.Enabled = true;
            tb_produto_compras.Enabled = true;
            tb_cod_barra_compras.Enabled = true;
            tb_qtde_compras.Enabled = true; ;
            tb_vl_compra_produto.Enabled = true;
        }

        private void tb_nf_compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
            {
                e.Handled = true; // deixa digitar
            }
            tb_nf_compras.MaxLength = 10;
        }

        private void tb_dt_entrada_compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_dt_entrada_compras.MaxLength = 10;
        }

        private void tb_produto_compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_produto_compras.MaxLength = 50;
        }

        private void tb_produto_compras_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_produto_compras.Text = tb_produto_compras.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_produto_compras.Text = tb_produto_compras.Text.Replace("  ", " ");
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

        private void tb_qtde_compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
            {
                e.Handled = true; // deixa digitar
            }
            tb_qtde_compras.MaxLength = 10;
        }

        private void tb_vl_compra_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DEIXA DIGITAR APENAS UMA VEZ OU O PONTO OU A VIRGULA E NÃO ACEITA NADA ALÉM DE NÚMEROS E PONTO E VIRGULA
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //Troca o ponto pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (tb_vl_compra_produto.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //Aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            tb_vl_compra_produto.MaxLength = 10;
        }

        private void pb_cadastrar_compras_Click(object sender, EventArgs e)
        {

            // VERIFICA SE O CAMPO ESTÁ VAZIO
            Tratamento ttb = new Tratamento();
            if (ttb.CampoVazio(tb_nf_compras, "NF"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_dt_entrada_compras, "DATA DE ENTRADA"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_produto_compras, "PRODUTO"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_qtde_compras, "QUANTIDADE"))
            {
                return;
            }
            if (ttb.CampoVazio(tb_vl_compra_produto, "VALOR DE COMPRA"))
            {
                return;
            }

            bool existente = compra_conn.JaCadastrado(tb_nf_compras.Text, tb_cod_barra_compras.Text);
            if (existente == true)
            {
                MessageBox.Show("Nota já cadastrada no sistema!");
            }
            else
            {
                //INSERE NO BD
                compra.nota_fiscal = tb_nf_compras.Text;
                compra.data_entrada = tb_dt_entrada_compras.Text;
                compra.nome_produto = tb_produto_compras.Text;
                compra.cod_barra = tb_cod_barra_compras.Text;
                compra.qtde_comprada = tb_qtde_compras.Text;
                compra.valor_entrada = Convert.ToDouble(tb_vl_compra_produto.Text);
                produto.nome_produto = tb_produto_compras.Text;
                produto.cod_barra = tb_cod_barra_compras.Text;
                produto.valor_venda = Convert.ToDouble(tb_vl_compra_produto.Text) + Convert.ToDouble(tb_vl_compra_produto.Text) * 0.3;
                estoque.nome_produto = tb_produto_compras.Text;
                estoque.cod_barra = tb_cod_barra_compras.Text;
                estoque.qtde = Convert.ToInt32(tb_qtde_compras.Text);

                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                string cod;
                cod = tb_cod_barra_compras.Text;
                dt = estoque_conn.Search(cod);
                dt2 = produto_conn.Search(cod);

                if (dt.Rows.Count <= 0)
                {
                    bool sucess = compra_conn.Insert(compra);
                    bool sucess2 = produto_conn.Insert(produto);
                    bool sucess3 = estoque_conn.Insert(estoque);
                    MessageBox.Show("Entrada Cadastrada com sucesso!");
                    Limpar();
                }
                else
                {
                    bool sucess = compra_conn.Insert(compra);
                    string id_estoque = dt.Rows[0]["id_estoque"].ToString();
                    string qtde_estoque = dt.Rows[0]["qtde"].ToString();
                    estoque.id_estoque = Convert.ToInt32(id_estoque);
                    estoque.qtde = Convert.ToInt32(qtde_estoque) + Convert.ToInt32(tb_qtde_compras.Text);

                    string id_produto = dt2.Rows[0]["id_produto"].ToString();
                    produto.id_produto = Convert.ToInt32(id_produto);
                    produto.valor_venda = Convert.ToDouble(tb_vl_compra_produto.Text) * 0.3 + Convert.ToDouble(tb_vl_compra_produto.Text);

                    bool sucessEst = estoque_conn.Update(estoque);
                    bool sucessProd = produto_conn.Update(produto);

                    if (sucessEst == true && sucessProd == true)
                    {
                        MessageBox.Show("Quantidade e valor do produto atualizada no sistema");
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível dar entrada nessa nota! Favor tentar novamente ou entrar em contato com o suporte do sistema.");
                    }
                }
            }
        }

        private void pb_consultar_compras_Click(object sender, EventArgs e)
        {
            pb_cadastrar_compras.Enabled = false;
            DataTable dt = new DataTable();
            string nf;
            compra.nota_fiscal = tb_nf_compras.Text;
            compra.data_entrada = tb_dt_entrada_compras.Text;
            compra.nome_produto = tb_produto_compras.Text;
            compra.cod_barra = tb_cod_barra_compras.Text;
            compra.qtde_comprada = tb_qtde_compras.Text;

            if (tb_nf_compras.Text == "")
            {
                MessageBox.Show("Para consultar, é necessário inserir a NF");
            }
            else
            {
                nf = tb_nf_compras.Text; 
                dt = compra_conn.Search(nf);

                if (dt.Rows.Count > 0)
                {
                    tb_id_compras.Text = dt.Rows[0]["id_compras"].ToString();
                    tb_nf_compras.Text = dt.Rows[0]["nota_fiscal"].ToString();
                    tb_dt_entrada_compras.Text = dt.Rows[0]["data_entrada"].ToString();
                    tb_produto_compras.Text = dt.Rows[0]["nome_produto"].ToString();
                    tb_qtde_compras.Text = dt.Rows[0]["qtde_comprada"].ToString();
                    tb_cod_barra_compras.Text = dt.Rows[0]["cod_barra"].ToString();
                    tb_vl_compra_produto.Text = dt.Rows[0]["valor_entrada"].ToString();
                    DesabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Nota não encontrada");
                }
            }
        }

        private void bt_limpar_cliente_Click(object sender, EventArgs e)
        {
            Limpar();
            HabilitarCampos();
        }

        private void pb_remover_compras_Click(object sender, EventArgs e)
        {
            compra.id_compras = Convert.ToInt32(tb_id_compras.Text);
            estoque.cod_barra = tb_cod_barra_compras.Text;
            estoque.nome_produto = tb_produto_compras.Text;

            DataTable dt = new DataTable();
            string cod;
            cod = tb_cod_barra_compras.Text;
            dt = estoque_conn.Search(cod);

            string id_estoque = dt.Rows[0]["id_estoque"].ToString();
            string qtde_estoque_temp = dt.Rows[0]["qtde"].ToString();
            int qtde_estoque = Convert.ToInt32(qtde_estoque_temp);
            estoque.id_estoque = Convert.ToInt32(id_estoque);
            int qtde_compra = Convert.ToInt32(tb_qtde_compras.Text);
            estoque.qtde = qtde_estoque - qtde_compra;

            if (qtde_estoque > qtde_compra)
            {
                bool sucessEst = estoque_conn.Update(estoque);
               
                if (sucessEst == true)
                {
                    bool sucess = compra_conn.Delete(compra);
                    if (sucess == true)
                    {
                        Limpar();
                        pb_cadastrar_compras.Enabled = true;
                        MessageBox.Show("Compra removida com sucesso");
                    }
                    else
                {
                        MessageBox.Show("Não foi possível remover essa compra, favor entrar em contato com o suporte.");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o estoque, favor entrar em contato com o suporte.");
                }
            }
            else
            {
                MessageBox.Show("Não é permitido estoque negativo");
            }
        }

        private void pb_editar_compras_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pb_cadastrar_compras.Enabled = false;
            pb_remover_compras.Enabled = false;
        }

        private void bt_salvar_cliente_Click(object sender, EventArgs e)
        {
            compra.id_compras = Convert.ToInt32(tb_id_compras.Text);
            compra.nota_fiscal = tb_nf_compras.Text;
            compra.data_entrada = tb_dt_entrada_compras.Text;
            compra.nome_produto = tb_produto_compras.Text;
            compra.cod_barra = tb_cod_barra_compras.Text;
            compra.qtde_comprada = tb_qtde_compras.Text;

            bool sucess = compra_conn.Update(compra);
            if (sucess == true)
            {
                MessageBox.Show("Compra atualizado");
                Limpar();
                HabilitarCampos();
            }
            else
            {
                MessageBox.Show("Não foi possível editar as informações dessa compra, favor entrar em contato com o suporte.");
            }
        }
    }
}
