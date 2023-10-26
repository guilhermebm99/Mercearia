using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class ClienteBLLcs
    {

        public void Inserir(Cliente _cliente)
        {
            if (string.IsNullOrEmpty(_cliente.Nome))
                throw new Exception("Informe o nome do Cliente");

            new ClienteDALL().Inserir(_cliente);

        }
        public void Alterar(Cliente _cliente)
        {

            new ClienteDALL().Alterar(_cliente);


        }
        public void Excluir(int _id)
        {

            new ClienteDALL().Excluir(_id);


        }
        public List<Cliente> BuscarTodos()
        {

            return new ClienteDALL().BuscarTodos();


        }
        public Cliente BuscarPorId(int _id)
        {

            return new ClienteDALL().BuscarPorId(_id);


        }


        public List<Cliente> BuscarPorNome(string _nome)
        {
            return new ClienteDALL().BuscarPornome(_nome);


        }

        public Cliente BuscarPorNomeCliente(string _nomeCliente)
        {
            return new ClienteDALL().BuscarPornomeCliente(_nomeCliente);
        }













    }


}
