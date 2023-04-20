using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace SAP
{
    public partial class frm_cadastro_pessoas : Form
    {
        public String operacao;
        public frm_cadastro_pessoas()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            //op = operações que serao feitas com os botões
            //1  = Preparar os botoes para inserir e localizar
            //2  = prepara os botoes para inserir/alterar um registro
            //3 = prepara a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInseri.Enabled = false;
            //btAlterar.Enabled = false;
            //btLocalizar.Enabled = false;
            //btExcluir.Enabled = false;
            //btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInseri.Enabled = true;
                //btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                //btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                //btAlterar.Enabled = true;
                //btExcluir.Enabled = true;
                //btCancelar.Enabled = true;
            }
        }



        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                //leitura dos dados
                ModeloPessoas modelo = new ModeloPessoas();
                modelo.CliNome = txtNome.Text;
                modelo.CliRsocial = txtRsocial.Text;
                modelo.CliCpfCnpj = txtCPFCNPJ.Text;
                modelo.CliRgIe = txtRgie.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliFone = txtFone.Text;
                modelo.CliCelular = txtCelular.Text;
                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "F"; //pessoa fisica
                    modelo.CliRsocial = "";
                }
                else
                {
                    modelo.CliTipo = "J"; //pessoa Juridica
                }
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPessoas bll = new BLLPessoas(cx);
                if (this.operacao == "inserir")
                {
                    //cadasrar uma categoria

                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado: Código " + modelo.CliCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
                    //bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado");
                }
                //this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btInseri_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frm_consultar_pessoas abrirconsultapessoa = new frm_consultar_pessoas();
            abrirconsultapessoa.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPessoas bll = new BLLPessoas(cx);
                ModeloPessoas modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();

                if (modelo.CliTipo == "F")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                }
                txtNome.Text = modelo.CliNome;
                txtRsocial.Text = modelo.CliRsocial;
                txtCPFCNPJ.Text = modelo.CliCpfCnpj;
                txtRgie.Text = modelo.CliRgIe;
                txtCep.Text = modelo.CliCep;
                txtEstado.Text = modelo.CliEstado;
                txtCidade.Text = modelo.CliCidade;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNumero;
                txtBairro.Text = modelo.CliBairro;
                txtEmail.Text = modelo.CliEmail;
                txtFone.Text = modelo.CliFone;
                txtCelular.Text = modelo.CliCelular;
                alteraBotoes(3);
            }
            else
            {
                //this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
    }
}
