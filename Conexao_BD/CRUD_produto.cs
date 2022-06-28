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
    class CRUD_produto
    {
        static string conexao = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Selecionar dados do DataBase
        public DataTable Select() // Para selecionar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Produto"; // Criando a string com essa frase 
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

        public bool Insert(Produto produto)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "INSERT INTO Produto (nome_produto,cod_barra,valor_venda) VALUES (@nome_produto,@cod_barra,@valor_venda)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_produto", produto.nome_produto);
                cmd.Parameters.AddWithValue("@cod_barra", produto.cod_barra);
                cmd.Parameters.AddWithValue("@valor_venda", produto.valor_venda);

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

        public bool Update(Produto produto)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "UPDATE Produto SET nome_produto=@nome_produto, cod_barra=@cod_barra, valor_venda=@valor_venda WHERE id_produto=@id_produto";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_produto", produto.nome_produto);
                cmd.Parameters.AddWithValue("@cod_barra", produto.cod_barra);
                cmd.Parameters.AddWithValue("@valor_venda", produto.valor_venda);
                cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);

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

        public bool Delete(Produto produto)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "DELETE FROM Produto WHERE id_produto=@id_produto";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);

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
                string sql = "SELECT * FROM Produto WHERE nome_produto LIKE '%" + keywords + "%' OR cod_barra LIKE '%" + keywords + "%'"; // Criando a string com essa frase 
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

        #region Verifica se já consta no BD

        public bool JaCadastrado(string cod_barra) // Para pesquisar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Produto WHERE cod_barra LIKE '%" + cod_barra + "%'"; // Criando a string com essa frase 
                SqlCommand cmd = new SqlCommand(sql, conn); // que vai até o bd  e roda a string que quer dizer - selecionar tudo da tabela
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Recebe os dados e armazena
                conn.Open(); // abrir a conexão
                adapter.Fill(dt); // preenche a tabela
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); // Se tiver erro, ele mostra
            }
            finally
            {
                conn.Close(); // Para finalizar, ele fecha a conexao.
            }
            return false; // Retorna a tabela atualizada (com os campos preenchidos)
        }
        #endregion
    }
}
