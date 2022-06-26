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
    class CRUD_cliente
    {
        static string conexao = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Selecionar dados do DataBase
        public DataTable Select() // Para selecionar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Cliente"; // Criando a string com essa frase 
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

        public bool Insert(Cliente cliente)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "INSERT INTO Cliente (tipo,cpf_cpnj,nome,data_nascimento,celular,cep,cidade,estado,bairro,complemento,endereco,numero_endereco,email) VALUES (@tipo,@cpf_cpnj,@nome,@data_nascimento,@celular,@cep,@cidade,@estado,@bairro,@complemento,@endereco,@numero_endereco,@email)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tipo", cliente.tipo);
                cmd.Parameters.AddWithValue("@cpf_cpnj", cliente.cpf_cpnj);
                cmd.Parameters.AddWithValue("@nome", cliente.nome);
                cmd.Parameters.AddWithValue("@data_nascimento", cliente.data_nascimento);
                cmd.Parameters.AddWithValue("@celular", cliente.celular);
                cmd.Parameters.AddWithValue("@cep", cliente.cep);
                cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                cmd.Parameters.AddWithValue("@numero_endereco", cliente.numero_endereco);
                cmd.Parameters.AddWithValue("@email", cliente.email);

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

        public bool Update(Cliente cliente)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "UPDATE Cliente SET tipo=@tipo, cpf_cpnj=@cpf_cpnj, nome=@nome, data_nascimento=@data_nascimento, celular=@celular, cep=@cep, cidade=@cidade, estado=@estado, bairro=@bairro, complemento=@complemento, endereco=@endereco, numero_endereco=@numero_endereco, email=@email WHERE id_cliente=@id_cliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tipo", cliente.tipo);
                cmd.Parameters.AddWithValue("@cpf_cpnj", cliente.cpf_cpnj);
                cmd.Parameters.AddWithValue("@nome", cliente.nome);
                cmd.Parameters.AddWithValue("@data_nascimento", cliente.data_nascimento);
                cmd.Parameters.AddWithValue("@celular", cliente.celular);
                cmd.Parameters.AddWithValue("@cep", cliente.cep);
                cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                cmd.Parameters.AddWithValue("@numero_endereco", cliente.numero_endereco);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);

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

        public bool Delete(Cliente cliente)
        {
            bool sucedido = false;
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string sql = "DELETE FROM Cliente WHERE id_cliente=@id_cliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);

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
                string sql = "SELECT * FROM Cliente WHERE cpf_cpnj LIKE '%" + keywords + "%' OR nome LIKE '%" + keywords + "%' OR celular LIKE '%" + keywords + "%' OR email LIKE '%" + keywords + "%'"; // Criando a string com essa frase 
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

        public bool JaCadastrado(string cpf_cnpj) // Para pesquisar dados da tabela
        {
            SqlConnection conn = new SqlConnection(conexao); // Conectando ao banco de dados
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Cliente WHERE cpf_cpnj LIKE '%" + cpf_cnpj + "%'"; // Criando a string com essa frase 
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
