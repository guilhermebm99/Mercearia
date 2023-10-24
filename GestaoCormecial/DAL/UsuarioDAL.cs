﻿using Microsoft.VisualBasic;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {
                  
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"Insert into Usuario(Nome, NomeUsuario, Senha, Ativo )
                                    VALUES(@Nome,@NomeUsuario, @Senha, @Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteNonQuery();  
                cn.Close(); 
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados",ex);
            }
            finally
            {

                cn.Close();
            }
        
        }
        public void Alterar(Usuario _usuario)
        {

            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"UPDATE Usuario SET Nome = @Nome,
                  NomeUsuario = @NomeUsuario,
                  Senha = @Senha 
                  WHERE Id = @Id";





                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

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

                cmd.CommandText = @"Delete from Usuario
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
        public List<Usuario> BuscarTodos()
        {

            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "SELECT Id,Nome,NomeUsuario,Senha,Ativo FROM Usuario";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        usuario = new Usuario();
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuarioList.Add(usuario);
                    }


                }
                return usuarioList; 

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados", ex);
            }
            finally
            {

                cn.Close ();    

            }

        }

        public Usuario BuscarPorId(int _id)
        {
            
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Constantes1.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "SELECT Id,Nome,NomeUsuario,Senha,Ativo FROM Usuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    usuario = new Usuario();
                    if (rd.Read())
                    {          
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        
                    }
                }
                return usuario;

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






    }
}
