using BLL;
using DAL;
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
    public partial class frm_consulta_financeiro : Form
    {
        public int codigo = 0;
        public frm_consulta_financeiro()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frm_cadastro_financeiro abrircadfinanceiro = new frm_cadastro_financeiro();
            abrircadfinanceiro.ShowDialog();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFinanceiro bll = new BLLFinanceiro(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }
    }
}
