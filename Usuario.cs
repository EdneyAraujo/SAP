using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP
{
    public class Usuario
    {
        private int usuario_id;
        private int ativo;
        private string nome;
        private string nome_usuario;
        private string senha;
        private int grupo_usuario_id;
        private string operadorcadastro;
        private DateTime datacadastro;
        private string operadoralteracao;
        private DateTime dataalteracao;

        public int Usuario_id { get => usuario_id; set => usuario_id = value; }
        public int Ativo { get => ativo; set => ativo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Nome_usuario { get => nome_usuario; set => nome_usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Grupo_usuario_id { get => grupo_usuario_id; set => grupo_usuario_id = value; }
        public string Operadorcadastro { get => operadorcadastro; set => operadorcadastro = value; }
        public DateTime Datacadastro { get => datacadastro; set => datacadastro = value; }
        public string Operadoralteracao { get => operadoralteracao; set => operadoralteracao = value; }
        public DateTime Dataalteracao { get => dataalteracao; set => dataalteracao = value; }
    }
}
