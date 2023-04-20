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
    }
}
