using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP
{
    public partial class frm_cadastro_financeiro : Form
    {
        public String operacao;
        public frm_cadastro_financeiro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            //op = operações que serao feitas com os botões
            //1  = Preparar os botoes para inserir e localizar
            //2  = prepara os botoes para inserir/alterar um registro
            //3 = prepara a tela para excluir ou alterar

            //pnDados.Enabled = false;
            //btInseri.Enabled = false;
            //btAlterar.Enabled = false;
            //btLocalizar.Enabled = false;
            //btExcluir.Enabled = false;
            //btCancelar.Enabled = false;
            //btSalvar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                //btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                //btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                //btAlterar.Enabled = true;
                //btExcluir.Enabled = true;
                //btCancelar.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btnInsetir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //leitura dos dados
                ModeloFinanceiro modelo = new ModeloFinanceiro();
                modelo.Finnome = txtNome.Text;
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFinanceiro bll = new BLLFinanceiro(cx);
                if (this.operacao == "inserir")
                {
                    //cadasrar uma categoria

                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado: Código " + modelo.FinCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.FinCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
