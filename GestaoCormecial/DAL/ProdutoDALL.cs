

using Microsoft.VisualBasic;
using Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ProdutoDall
    {

        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"Insert into Produto(Nome, Preco, Estoque)
                                    VALUES(@Nome, @Preco, @Estoque)";

                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
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
        public void Alterar(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"UPDATE Produto SET Nome = @Nome,
                  Preco = @Preco  WHERE Id = @Id";
                 
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
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
        public void Excluir(int _id)
        {

            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"Delete from Produto
                                 Where Id = @Id";


                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Id", _id);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
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
        public List<Produto> BuscarTodos()
        {

            throw new NotImplementedException();


        }

        public Produto BuscarPorId(int _id)
        {

            Produto produto;

            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "SELECT Nome,Preco,Estoque FROM Produto WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Estoque = (double)rd["Estoque"];
                    }
                }
                return produto;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }

        }


    }
     


















}

