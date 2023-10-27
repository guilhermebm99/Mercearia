﻿using Microsoft.VisualBasic;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario,SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;  

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"Insert into Usuario(Nome, NomeUsuario, Senha, Ativo )
                                    VALUES(@Nome,@NomeUsuario, @Senha, @Ativo)"))
                {

                    try
                    {



                        cmd.CommandType = System.Data.CommandType.Text;  

                       


                        cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                        cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                        cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

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
                        throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados", ex);
                    }
                }

            }
        }


        public void Alterar(Usuario _usuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"Insert into Usuario(Nome, NomeUsuario, Senha, Ativo )
                                    VALUES(@Nome,@NomeUsuario, @Senha, @Ativo)"))
                {

                    try
                    {



                        cmd.CommandType = System.Data.CommandType.Text;




                        cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                        cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                        cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

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
                        throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados", ex);
                    }
                }

            }
        }


        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"Delete from Usuario
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
                        throw new Exception("Ocorreu um erro ao tentar excluir o usuário no banco de dados", ex);
                    }
                }

            }




        }
        public List<Usuario> BuscarTodos()
        {

            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

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
                        usuario = PreencherObjeto(rd);
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

        private static Usuario PreencherObjeto(SqlDataReader rd)
        {
            Usuario usuario = new Usuario();
            usuario.Id = (int)rd["Id"];
            usuario.Nome = rd["Nome"].ToString();
            usuario.NomeUsuario = rd["NomeUsuario"].ToString();
            usuario.Senha = rd["Senha"].ToString();
            usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
            return usuario;
        }

        public Usuario BuscarPorId(int _id)
        {
            
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

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

        public List<Usuario> BuscarPornome(string _nome)
        {

            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Id,Nome,NomeUsuario,Senha,Ativo
                                    FROM Usuario WHERE Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

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

                throw new Exception("Ocorreu um erro ao tentar buscar o usuário no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }

        }

        public Usuario BuscarPornomeUsuario(string _nomeUsuario)
        {

            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Id,Nome,NomeUsuario,Senha,Ativo 
                                   FROM Usuario 
                                   WHERE NomeUsuario = @NomeUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);

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

                throw new Exception("Ocorreu um erro ao tentar inserir o usuário por nome de usuário no banco de dados", ex);
            }
            finally
            {

                cn.Close();

            }
        }
    }
}
