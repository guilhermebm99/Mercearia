using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {


        public void Inserir(Produto _produto)
        {
            if (string.IsNullOrEmpty(_produto.Nome))
                throw new Exception("Informe o nome do produto");

            new ProdutoDall().Inserir(_produto);

        }
        public void Alterar(Produto _produto)
        {

            new ProdutoDall().Alterar(_produto);


        }
        public void Excluir(int _id)
        {

            new ProdutoDall().Excluir(_id);


        }
        public List<Produto> BuscarTodos()
        {

            return new ProdutoDall().BuscarTodos();


        }
        public Produto BuscarPorId(int _id)
        {

            return new ProdutoDall().BuscarPorId(_id);


        }


    }







}
