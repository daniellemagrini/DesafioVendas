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
    class CRUD_estoque
    {
        static string conexao = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Selecionar dados do DataBase
        public DataTable Select() // Para selecionar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Estoque"; // Criando a string com essa frase 
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

        public bool Insert(Estoque estoque)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "INSERT INTO Estoque (cod_barra,qtde,nome_produto) VALUES (@cod_barra,@qtde,@nome_produto)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod_barra", estoque.cod_barra);
                cmd.Parameters.AddWithValue("@qtde", estoque.qtde);
                cmd.Parameters.AddWithValue("@nome_produto", estoque.nome_produto);

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

        public bool Update(Estoque estoque)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "UPDATE Estoque SET cod_barra=@cod_barra, qtde=@qtde, nome_produto=@nome_produto WHERE id_estoque=@id_estoque";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod_barra", estoque.cod_barra);
                cmd.Parameters.AddWithValue("@qtde", estoque.qtde);
                cmd.Parameters.AddWithValue("@nome_produto", estoque.nome_produto);
                cmd.Parameters.AddWithValue("@id_estoque", estoque.id_estoque);

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

        public bool Delete(Estoque estoque)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "DELETE FROM Estoque WHERE id_estoque=@id_estoque";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_estoque", estoque.id_estoque);

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
                string sql = "SELECT * FROM Estoque WHERE cod_barra LIKE '%" + keywords + "%' OR nome_produto LIKE '%" + keywords + "%'"; // Criando a string com essa frase 
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
