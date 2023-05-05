using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFinanceiro
    {
        public ModeloFinanceiro()
        {
            this.FinCod = 0;
            this.Finnome = "";
        }

        public ModeloFinanceiro(int fincod, String nome)
        {
            this.FinCod = fincod;
            this.Finnome = nome;
        }

        private int fin_cod;
        public int FinCod
        {
            get { return this.fin_cod; }
            set { this.fin_cod = value; }
        }
        private string fin_nome;
        public String Finnome
        {
            get { return this.fin_nome; }
            set { this.fin_nome = value; }
        }
    }
}
