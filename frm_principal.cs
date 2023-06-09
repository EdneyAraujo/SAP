﻿using System;
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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_pessoas abrir_frm_pessoas = new frm_cadastro_pessoas();
            abrir_frm_pessoas.ShowDialog();
            abrir_frm_pessoas.Dispose();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consulta_financeiro abrirfinanceiro = new frm_consulta_financeiro();
            abrirfinanceiro.ShowDialog();
        }
    }
}
