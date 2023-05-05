using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {

        public static String servidor = @"0fTI\SQLEXPRESS";
        public static String banco = "SAPfGRADO";
        public static String usuario = "sa";
        public static String senha = "Onlf@#";

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
