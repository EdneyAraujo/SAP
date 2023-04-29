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
    public partial class frm_consultar_pessoas : Form
    {
        public int codigo = 0;
        public frm_consultar_pessoas()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPessoas bll = new BLLPessoas(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarporNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarporCPFCNPJ(txtValor.Text);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
