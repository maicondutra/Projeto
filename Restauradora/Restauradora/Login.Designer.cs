namespace Restauradora
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbxEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEmpresa
            // 
            this.tbxEmpresa.Location = new System.Drawing.Point(111, 185);
            this.tbxEmpresa.Name = "tbxEmpresa";
            this.tbxEmpresa.Size = new System.Drawing.Size(152, 20);
            this.tbxEmpresa.TabIndex = 0;
            this.tbxEmpresa.Visible = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmpresa.Location = new System.Drawing.Point(108, 169);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa:";
            this.lblEmpresa.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Georgia", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLogin.Location = new System.Drawing.Point(108, 87);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 16);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Usuário";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(111, 103);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(152, 20);
            this.tbxLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Georgia", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSenha.Location = new System.Drawing.Point(108, 126);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(111, 142);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(152, 20);
            this.tbxSenha.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(285, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&Login";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(350, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(31, 20);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "x";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVersao.Location = new System.Drawing.Point(290, 234);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(91, 13);
            this.lblVersao.TabIndex = 8;
            this.lblVersao.Text = "Versão 1.001.001";
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.BackColor = System.Drawing.Color.Transparent;
            this.lblDireitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDireitos.Location = new System.Drawing.Point(108, 12);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(163, 52);
            this.lblDireitos.TabIndex = 9;
            this.lblDireitos.Text = "Cessão de Direitos de Uso à\r\n\r\nRestauradora Ltda\r\nCNPJ/CPF: 17.890.327/0001-98";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Restauradora.Properties.Resources.fundo7;
            this.ClientSize = new System.Drawing.Size(393, 256);
            this.Controls.Add(this.lblDireitos);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.tbxEmpresa);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblDireitos;
    }
}