﻿
using Microsoft.VisualBasic;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDALL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"Insert into Cliente (Nome, Fone)
                                    VALUES(@Nome,@Fone)";

                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);
   

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
        public void Alterar(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"UPDATE Cliente SET Nome = @Nome,
                  Fone = @Fone
                  WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);


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

                cmd.CommandText = @"Delete from Cliente
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
        public List<Cliente> BuscarTodos()
        {

            throw new NotImplementedException();


        }


        public Cliente BuscarPorId(int _id)
        {

            Cliente cliente
                ;

            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);

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


    }





}
