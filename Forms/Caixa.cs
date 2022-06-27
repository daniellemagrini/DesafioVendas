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
    public partial class frm_caixa : Form
    {
        public frm_caixa()
        {
            InitializeComponent();
        }

        Vendas venda = new Vendas();
        CRUD_vendas venda_conn = new CRUD_vendas();

        private void frm_caixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaDesafioVendasDataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.lojaDesafioVendasDataSet.Vendas);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendasTableAdapter.Fill(this.lojaDesafioVendasDataSet.Vendas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pb_consultar_caixa_Click(object sender, EventArgs e)
        {
            venda.data_venda = tb_dt_caixa.Text;
            DataTable dt = venda_conn.SelectCaixa(venda);
            dg_caixa.DataSource = dt;

            double soma = 0;
            for (int i = 0; i < dg_caixa.Rows.Count; ++i)
            {
                soma += Convert.ToDouble(dg_caixa.Rows[i].Cells[2].Value);
            }
            tb_vl_caixa.Text = soma.ToString();
        }
    }
}
