namespace SAP
{
    partial class frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_cod);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Location = new System.Drawing.Point(33, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 549);
            this.panel1.TabIndex = 0;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(102, 123);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(88, 26);
            this.txt_cod.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(102, 286);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(118, 52);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(102, 225);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(250, 26);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(102, 175);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(250, 26);
            this.txt_user.TabIndex = 0;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 622);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_login";
            this.Text = "ENTRAR - LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_cod;
    }
}

