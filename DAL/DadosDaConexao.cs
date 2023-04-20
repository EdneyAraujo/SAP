using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {

        public static String servidor = @"HOUSERMASTER\SQLEXPRESS";
        public static String banco = "SAPINTEGRADO";
        public static String usuario = "sa";
        public static String senha = "30232800";

        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
                //return "Data Source=SERVERCPD\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;User ID=sa;Password=30232800";
                //return "Data Source=NOTE-EDNEY\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;User ID=sa;Password=30232800";
            }
        }
    }
}
