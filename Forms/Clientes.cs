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
    public partial class frm_clientes : Form
    {
        public frm_clientes()
        {
            InitializeComponent();
        }

        // VARIÁVEIS GLOBAIS QUE FAZ COMUNICAÇÃO COM O BANCO DE DADOS
        Cliente cliente = new Cliente();
        CRUD_cliente cliente_conn = new CRUD_cliente();
        private void LocalizaCEP()
        {
            if (!string.IsNullOrWhiteSpace(tb_cep_cliente.Text)) // Só executa se o campo cep estiver com algum valor digitado
            {
                using (var ws = new WebServiceCorreios.AtendeClienteClient()) // Referencia o web service com a variavel ws
                {
                    try
                    {
                        var endereco = ws.consultaCEP(tb_cep_cliente.Text.Trim());
                        tb_endereco_cliente.Text = endereco.end.ToUpper();
                        tb_cidade_cliente.Text = endereco.cidade.ToUpper();
                        tb_estado_cliente.Text = endereco.uf.ToUpper();
                        tb_bairro_cliente.Text = endereco.bairro.ToUpper();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Favor informar o CEP!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //LIMPA OS CAMPOS
        private void Limpar()
        {
            cb_tipo_cliente.ResetText();
            tb_cpf_cnpj_cliente.Clear();
            tb_nome_cliente.Clear();
            tb_dt_nascimento_cliente.Clear();
            tb_celular_cliente.Clear();
            tb_cep_cliente.Clear();
            tb_cidade_cliente.Clear();
            tb_estado_cliente.Clear();
            tb_bairro_cliente.Clear();
            tb_complemento_cliente.Clear();
            tb_endereco_cliente.Clear();
            tb_numero_end_cliente.Clear();
            tb_email_cliente.Clear();
        }
        //DISABILIDA OS CAMPOS
        private void DesabilitarCampos()
        {
            cb_tipo_cliente.Enabled = false;
            tb_cpf_cnpj_cliente.Enabled = false;
            tb_nome_cliente.Enabled = false;
            tb_dt_nascimento_cliente.Enabled = false;
            tb_celular_cliente.Enabled = false;
            tb_cep_cliente.Enabled = false;
            tb_cidade_cliente.Enabled = false;
            tb_estado_cliente.Enabled = false;
            tb_bairro_cliente.Enabled = false;
            tb_complemento_cliente.Enabled = false;
            tb_endereco_cliente.Enabled = false;
            tb_numero_end_cliente.Enabled = false;
            tb_email_cliente.Enabled = false;
        }
        //HABILITA OS CAMPOS
        private void HabilitarCampos()
        {
            cb_tipo_cliente.Enabled = true;
            tb_cpf_cnpj_cliente.Enabled = true;
            tb_nome_cliente.Enabled = true;
            tb_dt_nascimento_cliente.Enabled = true;
            tb_celular_cliente.Enabled = true;
            tb_cep_cliente.Enabled = true;
            tb_cidade_cliente.Enabled = true;
            tb_estado_cliente.Enabled = true;
            tb_bairro_cliente.Enabled = true;
            tb_complemento_cliente.Enabled = true;
            tb_endereco_cliente.Enabled = true;
            tb_numero_end_cliente.Enabled = true;
            tb_email_cliente.Enabled = true;
        }

        private void pb_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            bool existente = cliente_conn.JaCadastrado(tb_cpf_cnpj_cliente.Text);
            if (existente == true)
            {
                MessageBox.Show("Cliente já cadastrado!");
            }
            else
            {
                if (cb_tipo_cliente.Text != "PESSOA FÍSICA" && cb_tipo_cliente.Text != "PESSOA JURÍDICA")
                {
                    MessageBox.Show("TIPO INVÁLIDO!");
                }
                if (cb_tipo_cliente.Text == "PESSOA FÍSICA")
                {
                    if (tb_cpf_cnpj_cliente.Text.Length < 11)
                    {
                        MessageBox.Show("CPF INVÁLIDO!");
                    }
                }
                if (cb_tipo_cliente.Text == "PESSOA JURÍDICA")
                {
                    if (tb_cpf_cnpj_cliente.Text.Length < 14)
                    {
                        MessageBox.Show("CNPJ INVÁLIDO!");
                    }
                }

                // VERIFICA SE O CAMPO ESTÁ VAZIO
                Tratamento ttb = new Tratamento();
                if (ttb.CampoVazio(cb_tipo_cliente, "TIPO"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_cpf_cnpj_cliente, "CPF/CNPJ"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_nome_cliente, "NOME COMPLETO"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_dt_nascimento_cliente, "DATA DE NASCIMENTO"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_celular_cliente, "CELULAR"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_celular_cliente, "CEP"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_bairro_cliente, "BAIRRO"))
                {
                    return;
                }
                if (ttb.CampoVazio(cb_tipo_cliente, "ENDEREÇO"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_numero_end_cliente, "Nª"))
                {
                    return;
                }
                if (ttb.CampoVazio(tb_email_cliente, "E-MAIL"))
                {
                    return;
                }

                // CHAMA O MÉTODO PARA VALIDAR O EMAIL
                if (Tratamento.validaEmail(tb_email_cliente.Text) == false)
                {
                    MessageBox.Show("Endereço de email inválido");
                }

                //INSERE NO BD
                cliente.tipo = cb_tipo_cliente.Text;
                cliente.cpf_cpnj = tb_cpf_cnpj_cliente.Text;
                cliente.nome = tb_nome_cliente.Text;
                cliente.data_nascimento = tb_dt_nascimento_cliente.Text;
                cliente.celular = tb_celular_cliente.Text;
                cliente.cep = tb_cep_cliente.Text;
                cliente.cidade = tb_cidade_cliente.Text;
                cliente.estado = tb_estado_cliente.Text;
                cliente.bairro = tb_bairro_cliente.Text;
                cliente.complemento = tb_complemento_cliente.Text;
                cliente.endereco = tb_endereco_cliente.Text;
                cliente.numero_endereco = tb_numero_end_cliente.Text;
                cliente.email = tb_email_cliente.Text;


                bool sucess = cliente_conn.Insert(cliente);

                if (sucess == true)
                {
                    //DA A MENSAGEM PARA AVISAR QUE FOI CADASTRADO OU NÃO E LIMPA TODOS OS CAMPOS
                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                    Limpar();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado! Favor tentar novamente ou entrar em contato com o suporte do sistema.");
                }
            }
        }

            private void tb_cpf_cnpj_cliente_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
                {
                    e.Handled = true; // deixa digitar
                }
                if (cb_tipo_cliente.Text == "PESSOA FÍSICA")
                {
                    tb_cpf_cnpj_cliente.MaxLength = 11;
                }
                if (cb_tipo_cliente.Text == "PESSOA JURÍDICA")
                {
                    tb_cpf_cnpj_cliente.MaxLength = 14;
                }
            }

        private void tb_nome_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_nome_cliente.MaxLength = 50;
        }

        private void tb_nome_cliente_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_nome_cliente.Text = tb_nome_cliente.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_nome_cliente.Text = tb_nome_cliente.Text.Replace("  ", " ");
            }
        }

        private void tb_dt_nascimento_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_dt_nascimento_cliente.MaxLength = 10;
        }

        private void tb_celular_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
            {
                e.Handled = true; // deixa digitar
            }
            tb_celular_cliente.MaxLength = 11;
        }

        private void bt_consulta_cep_cliente_Click(object sender, EventArgs e)
        {
            var uri = "https://buscacepinter.correios.com.br/app/endereco/index.php";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void tb_cep_cliente_Leave(object sender, EventArgs e)
        {
            LocalizaCEP();
        }

        private void tb_cep_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Só pode digitar teclas de controle, tipo backspace e números
            {
                e.Handled = true; // deixa digitar
            }
            tb_cep_cliente.MaxLength = 8;
        }

        private void tb_bairro_cliente_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_bairro_cliente.Text = tb_bairro_cliente.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_bairro_cliente.Text = tb_bairro_cliente.Text.Replace("  ", " ");
            }
        }

        private void tb_complemento_cliente_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_complemento_cliente.Text = tb_complemento_cliente.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_complemento_cliente.Text = tb_complemento_cliente.Text.Replace("  ", " ");
            }
        }

        private void tb_endereco_cliente_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_endereco_cliente.Text = tb_endereco_cliente.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_endereco_cliente.Text = tb_endereco_cliente.Text.Replace("  ", " ");
            }
        }

        private void tb_endereco_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_endereco_cliente.MaxLength = 50;
        }

        private void tb_bairro_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_bairro_cliente.MaxLength = 50;
        }

        private void tb_complemento_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_complemento_cliente.MaxLength = 50;
        }

        private void tb_numero_end_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_numero_end_cliente.MaxLength = 10;
        }

        private void tb_numero_end_cliente_Leave(object sender, EventArgs e)
        {
            //DEIXA TUDO NO PADRÃO QUE É MAIUSCULO E SEM ESPAÇOS EM BRANCO SOBRANDO
            tb_numero_end_cliente.Text = tb_numero_end_cliente.Text.ToUpper().Trim();
            for (int i = 0; i < 10; i++)
            {
                tb_numero_end_cliente.Text = tb_numero_end_cliente.Text.Replace("  ", " ");
            }
        }

        private void pb_consultar_cliente_Click(object sender, EventArgs e)
        {
            pb_cadastrar_cliente.Enabled = false;
            DataTable dt = new DataTable();
            string keywords;
            cliente.tipo = cb_tipo_cliente.Text;
            cliente.cpf_cpnj = tb_cpf_cnpj_cliente.Text;
            cliente.nome = tb_nome_cliente.Text;
            cliente.data_nascimento = tb_dt_nascimento_cliente.Text;
            cliente.celular = tb_celular_cliente.Text;
            cliente.cep = tb_cep_cliente.Text;
            cliente.cidade = tb_cidade_cliente.Text;
            cliente.estado = tb_estado_cliente.Text;
            cliente.bairro = tb_bairro_cliente.Text;
            cliente.complemento = tb_complemento_cliente.Text;
            cliente.endereco = tb_endereco_cliente.Text;
            cliente.numero_endereco = tb_numero_end_cliente.Text;
            cliente.email = tb_email_cliente.Text;

            if (tb_id_cliente.Text == null && cb_tipo_cliente.Text == null && tb_cpf_cnpj_cliente.Text == null && tb_nome_cliente.Text == null && tb_dt_nascimento_cliente.Text == null && tb_celular_cliente.Text == null && tb_cep_cliente.Text == null && tb_cidade_cliente.Text == null && tb_estado_cliente == null && tb_bairro_cliente.Text == null && tb_complemento_cliente.Text == null && tb_endereco_cliente.Text == null && tb_email_cliente.Text == null)
            {
                MessageBox.Show("Para consultar, é necessário preencher um dos campos: CPF, NOME, CELULAR, EMAIL");
            }
            else if (tb_cpf_cnpj_cliente != null)
            {
                keywords = tb_cpf_cnpj_cliente.Text;
                dt = cliente_conn.Search(keywords);
                tb_id_cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                cb_tipo_cliente.Text = dt.Rows[0]["tipo"].ToString();
                tb_cpf_cnpj_cliente.Text = dt.Rows[0]["cpf_cpnj"].ToString();
                tb_nome_cliente.Text = dt.Rows[0]["nome"].ToString();
                tb_dt_nascimento_cliente.Text = dt.Rows[0]["data_nascimento"].ToString();
                tb_celular_cliente.Text = dt.Rows[0]["celular"].ToString();
                tb_cep_cliente.Text = dt.Rows[0]["cep"].ToString();
                tb_cidade_cliente.Text = dt.Rows[0]["cidade"].ToString();
                tb_estado_cliente.Text = dt.Rows[0]["estado"].ToString();
                tb_bairro_cliente.Text = dt.Rows[0]["bairro"].ToString();
                tb_complemento_cliente.Text = dt.Rows[0]["complemento"].ToString();
                tb_endereco_cliente.Text = dt.Rows[0]["endereco"].ToString();
                tb_numero_end_cliente.Text = dt.Rows[0]["numero_endereco"].ToString();
                tb_email_cliente.Text = dt.Rows[0]["email"].ToString();
                DesabilitarCampos();
            }
            else if (tb_nome_cliente != null)
            {
                keywords = tb_nome_cliente.Text;
                dt = cliente_conn.Search(keywords);
                tb_id_cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                cb_tipo_cliente.Text = dt.Rows[0]["tipo"].ToString();
                tb_cpf_cnpj_cliente.Text = dt.Rows[0]["cpf_cpnj"].ToString();
                tb_nome_cliente.Text = dt.Rows[0]["nome"].ToString();
                tb_dt_nascimento_cliente.Text = dt.Rows[0]["data_nascimento"].ToString();
                tb_celular_cliente.Text = dt.Rows[0]["celular"].ToString();
                tb_cep_cliente.Text = dt.Rows[0]["cep"].ToString();
                tb_cidade_cliente.Text = dt.Rows[0]["cidade"].ToString();
                tb_estado_cliente.Text = dt.Rows[0]["estado"].ToString();
                tb_bairro_cliente.Text = dt.Rows[0]["bairro"].ToString();
                tb_complemento_cliente.Text = dt.Rows[0]["complemento"].ToString();
                tb_endereco_cliente.Text = dt.Rows[0]["endereco"].ToString();
                tb_numero_end_cliente.Text = dt.Rows[0]["numero_endereco"].ToString();
                tb_email_cliente.Text = dt.Rows[0]["email"].ToString();
                DesabilitarCampos();
            }
            else if (tb_celular_cliente != null)
            {
                keywords = tb_celular_cliente.Text;
                dt = cliente_conn.Search(keywords);
                tb_id_cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                cb_tipo_cliente.Text = dt.Rows[0]["tipo"].ToString();
                tb_cpf_cnpj_cliente.Text = dt.Rows[0]["cpf_cpnj"].ToString();
                tb_nome_cliente.Text = dt.Rows[0]["nome"].ToString();
                tb_dt_nascimento_cliente.Text = dt.Rows[0]["data_nascimento"].ToString();
                tb_celular_cliente.Text = dt.Rows[0]["celular"].ToString();
                tb_cep_cliente.Text = dt.Rows[0]["cep"].ToString();
                tb_cidade_cliente.Text = dt.Rows[0]["cidade"].ToString();
                tb_estado_cliente.Text = dt.Rows[0]["estado"].ToString();
                tb_bairro_cliente.Text = dt.Rows[0]["bairro"].ToString();
                tb_complemento_cliente.Text = dt.Rows[0]["complemento"].ToString();
                tb_endereco_cliente.Text = dt.Rows[0]["endereco"].ToString();
                tb_numero_end_cliente.Text = dt.Rows[0]["numero_endereco"].ToString();
                tb_email_cliente.Text = dt.Rows[0]["email"].ToString();
                DesabilitarCampos();
            }
            else if (tb_email_cliente != null)
            {
                keywords = tb_email_cliente.Text;
                dt = cliente_conn.Search(keywords);
                tb_id_cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                cb_tipo_cliente.Text = dt.Rows[0]["tipo"].ToString();
                tb_cpf_cnpj_cliente.Text = dt.Rows[0]["cpf_cpnj"].ToString();
                tb_nome_cliente.Text = dt.Rows[0]["nome"].ToString();
                tb_dt_nascimento_cliente.Text = dt.Rows[0]["data_nascimento"].ToString();
                tb_celular_cliente.Text = dt.Rows[0]["celular"].ToString();
                tb_cep_cliente.Text = dt.Rows[0]["cep"].ToString();
                tb_cidade_cliente.Text = dt.Rows[0]["cidade"].ToString();
                tb_estado_cliente.Text = dt.Rows[0]["estado"].ToString();
                tb_bairro_cliente.Text = dt.Rows[0]["bairro"].ToString();
                tb_complemento_cliente.Text = dt.Rows[0]["complemento"].ToString();
                tb_endereco_cliente.Text = dt.Rows[0]["endereco"].ToString();
                tb_numero_end_cliente.Text = dt.Rows[0]["numero_endereco"].ToString();
                tb_email_cliente.Text = dt.Rows[0]["email"].ToString();
                DesabilitarCampos();
            }           
        }
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
            HabilitarCampos();
        }

        private void pb_remover_cliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cliente.id_cliente = Convert.ToInt32(tb_id_cliente.Text);

            bool sucess = cliente_conn.Delete(cliente);
            if ( sucess == true)
            {
                Limpar();
                HabilitarCampos();
                MessageBox.Show("Cliente removido com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível remover esse cliente, favor entrar em contato com o suporte.");
            }
        }

        private void pb_editar_cliente_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pb_cadastrar_cliente.Enabled = false;
            pb_remover_cliente.Enabled = false;
        }

        private void bt_salvar_cliente_Click(object sender, EventArgs e)
        {
            cliente.id_cliente = Convert.ToInt32(tb_id_cliente.Text);
            cliente.tipo = cb_tipo_cliente.Text;
            cliente.cpf_cpnj = tb_cpf_cnpj_cliente.Text;
            cliente.nome = tb_nome_cliente.Text;
            cliente.data_nascimento = tb_dt_nascimento_cliente.Text;
            cliente.celular = tb_celular_cliente.Text;
            cliente.cep = tb_cep_cliente.Text;
            cliente.cidade = tb_cidade_cliente.Text;
            cliente.estado = tb_estado_cliente.Text;
            cliente.bairro = tb_bairro_cliente.Text;
            cliente.complemento = tb_complemento_cliente.Text;
            cliente.endereco = tb_endereco_cliente.Text;
            cliente.numero_endereco = tb_numero_end_cliente.Text;
            cliente.email = tb_email_cliente.Text;

            bool sucess = cliente_conn.Update(cliente);
            if (sucess == true)
            { 
                MessageBox.Show("Cliente atualizado");
                Limpar();
                HabilitarCampos();
            }
            else
            {
                MessageBox.Show("Não foi possível editar as informações desse cliente, favor entrar em contato com o suporte.");
            }
        }
    }
}
