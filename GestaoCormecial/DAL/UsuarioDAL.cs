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
            try
            {
                SqlConnection cn = new SqlConnection();   
                SqlCommand cmd = cn.CreateCommand();

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados",ex);
            }
        
        
        }
        public void Alterar(Usuario _usuario)
        {



    
        }
        public void Excluir(Usuario _usuario)
        {




        }
        public List<Usuario> BuscarTodos()
        {

            throw new NotImplementedException();    


        }







    }
}
