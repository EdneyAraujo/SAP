using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace DAL
{
    public class DALPessoas
    {
        private DALConexao conexao;

        public DALPessoas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPessoas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into PESSOAS(nome, cpfcnpj, rgie, rsocial," +
            "tipo, cep, endereco, bairro, fone, cel, email, endnumero," +
            "cidade, estado) values (@nome, @cpfcnpj, @rgie, @rsocial," +
            "@tipo, @cep, @endereco, @bairro, @fone, @cel, @email, @endnumero," +
            "@cidade, @estado);  select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@rgie", modelo.CliRgIe);
            cmd.Parameters.AddWithValue("@rsocial", modelo.CliRsocial);
            cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cel", modelo.CliCelular);
            cmd.Parameters.AddWithValue("@email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);
            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public ModeloPessoas CarregaModeloPessoas(int codigo)
        {
            ModeloPessoas modelo = new ModeloPessoas();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from PESSOAS where COD = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["COD"]);
                modelo.CliNome = Convert.ToString(registro["NOME"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["cpfcnpj"]);
                modelo.CliRgIe = Convert.ToString(registro["rgie"]);
                modelo.CliRsocial = Convert.ToString(registro["rsocial"]);
                modelo.CliTipo = Convert.ToString(registro["tipo"]);
                modelo.CliCep = Convert.ToString(registro["cep"]);
                modelo.CliEndereco = Convert.ToString(registro["endereco"]);
                modelo.CliBairro = Convert.ToString(registro["bairro"]);
                modelo.CliFone = Convert.ToString(registro["fone"]);
                modelo.CliCelular = Convert.ToString(registro["cel"]);
                modelo.CliEmail = Convert.ToString(registro["email"]);
                modelo.CliEndNumero = Convert.ToString(registro["endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cidade"]);
                modelo.CliEstado = Convert.ToString(registro["estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloPessoas CarregaModeloPessoas(string cpfcnpj)
        {
            ModeloPessoas modelo = new ModeloPessoas();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cpfcnpj = @cpfcnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRsocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToString(registro["cli_tipo"]);
                modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCelular = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from PESSOAS where NOME like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarporNome(String valor)
        {

            return Localizar(valor);
        }

        public DataTable LocalizarporCPFCNPJ(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from PESSOAS where cpfcnpj like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
