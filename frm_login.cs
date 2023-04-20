using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SAP
{
    public partial class frm_login : Form
    {
        //string vtextocanlogin = "Deseja Cancelar o Login?";
        //string vtitulo = "Controle Financeiro";
        //Usuario usuario = new Usuario();
        public frm_login()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=022621-GTI\SQLEXPRESS;Initial Catalog=SAPINTEGRADO;User ID=sa;Password=Onl3023@#");
        SqlConnection con = new SqlConnection(@"Data Source=HOUSERMASTER\SQLEXPRESS;Initial Catalog=SAPINTEGRADO;User ID=sa;Password=30232800");
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "Select USUARIO, SENHA from USUARIOS where USUARIO='" + txt_user.Text + "'and SENHA='" + txt_senha.Text + "'";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            if (dt.Rows.Count > 0)
            {
                frm_principal principalabrir = new frm_principal();
                principalabrir.Show();
            }
            else
            {
                MessageBox.Show("Senha ou Usuario Errado");
            }
            con.Close();
        }
    }
}
