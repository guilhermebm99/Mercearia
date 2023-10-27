
using Microsoft.VisualBasic;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDALL
    {
        public void Inserir(Cliente _cliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"Insert into Cliente (Nome, Fone)
                                    VALUES(@Nome,@Fone)"))
                {

                    try
                    {



                        cmd.CommandType = System.Data.CommandType.Text;




                        cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                        cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)

                    {

                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir o cliente no banco de dados", ex);
                    }
                }

            }
        }

        public void Alterar(Cliente _cliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE Cliente SET Nome = @Nome,
                  Fone = @Fone
                  WHERE Id = @Id"))
                {

                    try
                    {



                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _cliente.Id);
                        cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                        cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);


                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)

                    {

                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir o cliente no banco de dados", ex);
                    }
                }

            }
        }


        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"Delete from Cliente
                                 Where Id = @Id"))
                {

                    try
                    {



                        cmd.CommandType = System.Data.CommandType.Text;


                        cmd.Parameters.AddWithValue("@Id", _id);


                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)

                    {

                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir o cliente no banco de dados", ex);
                    }
                }

            }




        }




        public List<Cliente> BuscarTodos()
        {

            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "SELECT Id,Nome, Fone FROM Cliente";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        clienteList.Add(cliente);
                    }


                }
                return clienteList;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }




        }


        public Cliente BuscarPorId(int _id)
        {

            Cliente cliente
                ;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "SELECT Nome,Fone FROM Cliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    if (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();

                    }
                }
                return cliente;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o cliente no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }

        }

        public List<Cliente> BuscarPornome(string nome)
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Id,Nome,Fone
                                    FROM Cliente WHERE Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();                  
                        clienteList.Add(cliente);
                    }


                }
                return clienteList;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar o cliente no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }


        }

        public Cliente BuscarPornomeCliente(string _clienteNome)
        {
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Nome,Fone 
                                   FROM Cliente
                                   WHERE Nome = @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _clienteNome);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    if (rd.Read())
                    {

                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();


                    }
                }
                return cliente;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar mostrar o cliente por nome de usuário no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }
        }
    }

   
}
