using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constantes1
    {
        private static string stringDeConexao = "User ID=SA;Initial Catalog=merce;Data Source=.\\SQLEXPRESS2019;Password=Senailab02";
        public static string StringDeConexao
        {

            get 
            {


                return stringDeConexao;

            } 
        }


    }
}
