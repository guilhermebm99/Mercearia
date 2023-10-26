using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {

        public void Inserir(Usuario _usuario)
        {
            if (string.IsNullOrEmpty(_usuario.Nome))
                throw new Exception("Informe o nome do usuario");

            new UsuarioDAL().Inserir(_usuario);

        }
        public void Alterar(Usuario _usuario)
        {

            new UsuarioDAL().Alterar(_usuario);


        }
        public void Excluir(int _id)
        {

            new UsuarioDAL().Excluir(_id);


        }
        public List<Usuario> BuscarTodos()
        {

            return new UsuarioDAL().BuscarTodos();


        }
        public Usuario BuscarPorId(int _id)
        {

            return new UsuarioDAL().BuscarPorId(_id);


        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPornome(_nome);


        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuarioDAL().BuscarPornomeUsuario(_nomeUsuario);
        }
    }
}
