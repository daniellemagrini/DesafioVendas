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
    class CRUD_compras
    {
        static string conexao = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Selecionar dados do DataBase
        public DataTable Select() // Para selecionar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Compras"; // Criando a string com essa frase 
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

        public bool Insert(Compras compras)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "INSERT INTO Compras (nota_fiscal,data_entrada,nome_produto,cod_barra,qtde_comprada,valor_entrada) VALUES (@nota_fiscal,@data_entrada,@nome_produto,@cod_barra,@qtde_comprada,@valor_entrada)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nota_fiscal", compras.nota_fiscal);
                cmd.Parameters.AddWithValue("@data_entrada", compras.data_entrada);
                cmd.Parameters.AddWithValue("@nome_produto", compras.nome_produto);
                cmd.Parameters.AddWithValue("@cod_barra", compras.cod_barra);
                cmd.Parameters.AddWithValue("@qtde_comprada", compras.qtde_comprada);
                cmd.Parameters.AddWithValue("@valor_entrada", compras.valor_entrada);

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

        public bool Update(Compras compras)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "UPDATE Compras SET nota_fiscal=@nota_fiscal, data_entrada=@data_entrada, nome_produto=@nome_produto, cod_barra=@cod_barra, qtde_comprada=@qtde_comprada, valor_entrada=@valor_entrada WHERE id_compras=@id_compras";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nota_fiscal", compras.nota_fiscal);
                cmd.Parameters.AddWithValue("@data_entrada", compras.data_entrada);
                cmd.Parameters.AddWithValue("@nome_produto", compras.nome_produto);
                cmd.Parameters.AddWithValue("@cod_barra", compras.cod_barra);
                cmd.Parameters.AddWithValue("@qtde_comprada", compras.qtde_comprada);
                cmd.Parameters.AddWithValue("@valor_entrada", compras.valor_entrada);
                cmd.Parameters.AddWithValue("@id_compras", compras.id_compras);

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

        public bool Delete(Compras compras)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "DELETE FROM Compras WHERE id_compras=@id_compras";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_compras", compras.id_compras);

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
                string sql = "SELECT * FROM Compras WHERE nota_fiscal LIKE '%" + keywords + "%' OR nome_produto LIKE '%" + keywords + "%' OR cod_barra LIKE '%" + keywords + "%'"; // Criando a string com essa frase 
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

        public bool JaCadastrado(string nf, string cod_barra) // Para pesquisar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Compras WHERE nota_fiscal LIKE '%" + nf + "%' AND cod_barra LIKE '%" + cod_barra + "%'"; // Criando a string com essa frase 
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

        #region ALTERAR APENAS A QUANTIDADE

        public bool AlteraQtde(string cod_barra, Estoque estoque) // Para pesquisar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Estoque WHERE cod_barra LIKE '%" + cod_barra + "%'"; // Criando a string com essa frase 
                SqlCommand cmd = new SqlCommand(sql, conn); // que vai até o bd  e roda a string que quer dizer - selecionar tudo da tabela
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Recebe os dados e armazena
                conn.Open(); // abrir a conexão
                adapter.Fill(dt); // preenche a tabela
                SqlDataReader read = cmd.ExecuteReader();
                int qtde_bd = 0;

                if (read.Read())
                {
                    qtde_bd = Convert.ToInt32(read["qtde"]);
                    string sql2 = "UPDATE Estoque SET qtde=@qtde WHERE id_estoque=@id_estoque";
                    SqlCommand cmd2 = new SqlCommand(sql, conn);
                    cmd2.Parameters.AddWithValue("@qtde", estoque.qtde + qtde_bd);
                    cmd2.Parameters.AddWithValue("@id_estoque", estoque.id_estoque);
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
