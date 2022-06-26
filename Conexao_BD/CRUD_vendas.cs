using DesafioVendas.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioVendas.Conexao_BD
{
    class CRUD_vendas
    {
        static string conexao = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Selecionar dados do DataBase
        public DataTable Select() // Para selecionar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Vendas"; // Criando a string com essa frase 
                SqlCommand cmd = new SqlCommand(sql, conn); // que vai até o bd  e roda a string que quer dizer - selecionar tudo da tabela
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Recebe os dados e armazena
                conn.Open(); // abrir a conexão
                adapter.Fill(dt); // preenche a tabela
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); // Se tiver erro, ele mostra
            }
            finally
            {
                conn.Close(); // Para finalizar, ele fecha a conexao.
            }
            return dt; // Retorna a tabela atualizada (com os campos preenchidos)
        }
        #endregion

        #region Inserir dados no BD

        public bool Insert(Vendas vendas)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "INSERT INTO Vendas (data_venda,cpf_cnpj_cliente,nome_cliente,nome_produto,qtde,cod_barra,valor_produto,desconto,valor_total) VALUES (@data_venda,@cpf_cnpj_cliente,@nome_cliente,@nome_produto,@qtde,@cod_barra,@valor_produto,@desconto,@valor_total)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@data_venda", vendas.data_venda);
                cmd.Parameters.AddWithValue("@cpf_cnpj_cliente", vendas.cpf_cnpj_cliente);
                cmd.Parameters.AddWithValue("@nome_cliente", vendas.nome_cliente);
                cmd.Parameters.AddWithValue("@nome_produto", vendas.nome_produto);
                cmd.Parameters.AddWithValue("@qtde", vendas.qtde);
                cmd.Parameters.AddWithValue("@cod_barra", vendas.cod_barra);
                cmd.Parameters.AddWithValue("@valor_produto", vendas.valor_produto);
                cmd.Parameters.AddWithValue("@desconto", vendas.desconto);
                cmd.Parameters.AddWithValue("@valor_total", vendas.valor_total);

                conn.Open();
                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                {
                    sucedido = true;
                }
                else
                {
                    sucedido = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return sucedido;
        }
        #endregion

        #region Atualizar os dados do BD

        public bool Update(Vendas vendas)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "UPDATE Vendas SET data_venda=@data_venda, cpf_cnpj_cliente=@cpf_cnpj_cliente, nome_cliente=@nome_cliente, nome_produto=@nome_produto, qtde=@qtde, cod_barra=@cod_barra, valor_produto=@valor_produto, desconto=@desconto, valor_total=@valor_total WHERE id_venda=@id_venda";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@data_venda", vendas.data_venda);
                cmd.Parameters.AddWithValue("@cpf_cnpj_cliente", vendas.cpf_cnpj_cliente);
                cmd.Parameters.AddWithValue("@nome_cliente", vendas.nome_cliente);
                cmd.Parameters.AddWithValue("@nome_produto", vendas.nome_produto);
                cmd.Parameters.AddWithValue("@qtde", vendas.qtde);
                cmd.Parameters.AddWithValue("@cod_barra", vendas.cod_barra);
                cmd.Parameters.AddWithValue("@valor_produto", vendas.valor_produto);
                cmd.Parameters.AddWithValue("@desconto", vendas.desconto);
                cmd.Parameters.AddWithValue("@valor_total", vendas.valor_total);
                cmd.Parameters.AddWithValue("@id_venda", vendas.id_venda);

                conn.Open();
                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                {
                    sucedido = true;
                }
                else
                {
                    sucedido = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return sucedido;
        }
        #endregion

        #region Deletar dados do BD

        public bool Delete(Vendas vendas)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "DELETE FROM Vendas WHERE id_venda=@id_venda";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_venda", vendas.id_venda);

                conn.Open();
                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                {
                    sucedido = true;
                }
                else
                {
                    sucedido = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return sucedido;
        }
        #endregion

        #region Pesquisar no BD

        public DataTable Search(string keywords) // Para pesquisar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Vendas WHERE cpf_cnpj_cliente LIKE '%" + keywords + "%' OR cod_barra LIKE '%" + keywords + "%'"; // Criando a string com essa frase 
                SqlCommand cmd = new SqlCommand(sql, conn); // que vai até o bd  e roda a string que quer dizer - selecionar tudo da tabela
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Recebe os dados e armazena
                conn.Open(); // abrir a conexão
                adapter.Fill(dt); // preenche a tabela
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); // Se tiver erro, ele mostra
            }
            finally
            {
                conn.Close(); // Para finalizar, ele fecha a conexao.
            }
            return dt; // Retorna a tabela atualizada (com os campos preenchidos)
        }
        #endregion

    }
}
