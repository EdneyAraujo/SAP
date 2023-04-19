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
            cmd.CommandText = "insert into cliente(cli_nome, cli_cpfcnpj, cli_rgie, cli_rsocial," +
            "cli_tipo, cli_cep, cli_endereco, cli_bairro, cli_fone, cli_cel, cli_email, cli_endnumero," +
            "cli_cidade, cli_estado) values (@cli_nome, @cli_cpfcnpj, @cli_rgie, @cli_rsocial," +
            "@cli_tipo, @cli_cep, @cli_endereco, @cli_bairro, @cli_fone, @cli_cel, @cli_email, @cli_endnumero," +
            "@cli_cidade, @cli_estado);  select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@cli_nome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@cli_cpfcnpj", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@cli_rgie", modelo.CliRgIe);
            cmd.Parameters.AddWithValue("@cli_rsocial", modelo.CliRsocial);
            cmd.Parameters.AddWithValue("@cli_tipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@cli_cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@cli_endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@cli_bairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@cli_fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cli_cel", modelo.CliCelular);
            cmd.Parameters.AddWithValue("@cli_email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@cli_endnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cli_cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@cli_estado", modelo.CliEstado);
            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
    }
}
