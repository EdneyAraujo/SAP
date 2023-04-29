using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using DAL;
using Modelo;
using Ferramentas;


namespace BLL
{
    public class BLLPessoas
    {
        private DALConexao conexao;
    

    public BLLPessoas(DALConexao cx)
    {
        this.conexao = cx;
    }


    public void Incluir(ModeloPessoas modelo)
    {
        if (modelo.CliNome.Trim().Length == 0)
        {
            throw new Exception("O Nome do Cliente é Obrigatorio");
        }

        if (modelo.CliCpfCnpj.Trim().Length == 0)
        {
            throw new Exception("O CPF/CNPJ do Clie é Obrigatorio");
        }

        if (modelo.CliTipo == "F")
        {
            //cpf
            if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
            {
                throw new Exception("O CPF do Cliente é Invalido");
            }
        }
        else
        {//CNPJ
            if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
            {
                throw new Exception("O CNPJ do Clie é Invalido");
            }
        }
        //verifica CPF/CNPJ

        if (modelo.CliRgIe.Trim().Length == 0)
        {
            throw new Exception("O RG/IE do Clie é Obrigatorio");
        }

        if (modelo.CliFone.Trim().Length == 0)
        {
            throw new Exception("O Telefone do Clie é Obrigatorio");
        }

        //cli_tipo = 0 -> fisica
        //cli_tipo = 1 -> juridica

        // VALIDACAIEMAIL
        string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
        Regex re = new Regex(strRegex);
        if (!re.IsMatch(modelo.CliEmail))
        {
            throw new Exception("Email Invalido");
        }

        DALPessoas DALobj = new DALPessoas(conexao);
        DALobj.Incluir(modelo);
    }
        public ModeloPessoas CarregaModeloCliente(int codigo)
        {
            DALPessoas DALobj = new DALPessoas(conexao);
            return DALobj.CarregaModeloPessoas(codigo);
        }

        public ModeloPessoas CarregaModeloCliente(string cpfcnpj)
        {
            DALPessoas DALobj = new DALPessoas(conexao);
            return DALobj.CarregaModeloPessoas(cpfcnpj);
        }

        public DataTable LocalizarporNome(String valor)
        {
            DALPessoas DALobj = new DALPessoas(conexao);
            return DALobj.LocalizarporNome(valor);
        }

        public DataTable LocalizarporCPFCNPJ(String valor)
        {
            DALPessoas DALobj = new DALPessoas(conexao);
            return DALobj.LocalizarporCPFCNPJ(valor);
        }

    }
}
