

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
        public void Excluir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @" Delete from Produto
                                  Where Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);

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













    }
}
