using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPessoas
    {
        public ModeloPessoas() 
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRsocial = "";
            this.CliTipo = "F";
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCelular = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }

        public ModeloPessoas(int cod, string nome, string cpfcnpj, string rgie, string rsocial, string tipo, string cep, string endereco, string bairro, string fone, string celular,
            string email, string endnumero, string cidade, string estado)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfcnpj;
            this.CliRgIe = rgie;
            this.CliRsocial = rsocial;
            this.CliTipo = tipo;
            this.CliCep = cep;
            this.CliEndereco = endereco;
            this.CliBairro = bairro;
            this.CliFone = fone;
            this.CliCelular = celular;
            this.CliEmail = email;
            this.CliEndNumero = endnumero;
            this.CliCidade = cidade;
            this.CliEstado = estado;
        }

        //propriedades da classe
        private int cli_cod;

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private string cli_nome;
        public String CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        private string cli_cpfcnpj;
        public String CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        private string cli_RgIe;
        public String CliRgIe
        {
            get { return this.cli_RgIe; }
            set { this.cli_RgIe = value; }
        }

        private string cli_RSocial;
        public String CliRsocial
        {
            get { return this.cli_RSocial; }
            set { this.cli_RSocial = value; }
        }

        private string cli_tipo;
        public string CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        private string cli_cep;
        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        private string cli_endereco;
        public string CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        private string cli_bairro;
        public string CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        private string cli_fone;
        public string CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }

        private string cli_cel;
        public string CliCelular
        {
            get { return this.cli_cel; }
            set { this.cli_cel = value; }
        }

        private string cli_email;
        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        private string cli_endnumero;
        public string CliEndNumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }

        private string cli_cidade;
        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        private string cli_estado;
        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }
    }
}
