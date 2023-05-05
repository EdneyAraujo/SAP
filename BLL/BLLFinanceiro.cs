using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFinanceiro
    {
        private DALConexao conexao;

        public BLLFinanceiro(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFinanceiro modelo)
        {
            if (modelo.Finnome.Trim().Length == 0)
            {
                throw new Exception("O Nome Da Categoria é Obrigatorio");
            }

            modelo.Finnome = modelo.Finnome.ToUpper();

            DALFinanceiro DALobj = new DALFinanceiro(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFinanceiro modelo)
        {
            if (modelo.FinCod <= 0)
            {
                throw new Exception("O Nome Da Categoria é Obrigatorio");
            }
            if (modelo.Finnome.Trim().Length == 0)
            {
                throw new Exception("O Nome Da Categoria é Obrigatorio");
            }

            modelo.Finnome = modelo.Finnome.ToUpper();

            DALFinanceiro DALobj = new DALFinanceiro(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFinanceiro DALobj = new DALFinanceiro(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFinanceiro DALobj = new DALFinanceiro(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloFinanceiro CarregaModeloCategoria(int codigo)
        {
            DALFinanceiro DALobj = new DALFinanceiro(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}
