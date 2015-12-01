namespace Restauradora
{
    partial class FNovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNovoUsuario));
            this.pTopo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblDataNacimento = new System.Windows.Forms.Label();
            this.tbxDataNacimento = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.pTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pTopo
            // 
            this.pTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTopo.AutoSize = true;
            this.pTopo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pTopo.Controls.Add(this.lblUsuario);
            this.pTopo.Controls.Add(this.pbUsuario);
            this.pTopo.Location = new System.Drawing.Point(12, 12);
            this.pTopo.Name = "pTopo";
            this.pTopo.Size = new System.Drawing.Size(704, 64);
            this.pTopo.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(117, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(240, 25);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Cadastro de Usuários";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUsuario.InitialImage")));
            this.pbUsuario.Location = new System.Drawing.Point(11, 11);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(51, 42);
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Location = new System.Drawing.Point(23, 276);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbxAtivo.TabIndex = 22;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(298, 305);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Código:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Location = new System.Drawing.Point(301, 321);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbxCodigo.TabIndex = 20;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 318);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-mail:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(23, 196);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(378, 20);
            this.tbxEmail.TabIndex = 17;
            // 
            // lblDataNacimento
            // 
            this.lblDataNacimento.AutoSize = true;
            this.lblDataNacimento.Location = new System.Drawing.Point(20, 139);
            this.lblDataNacimento.Name = "lblDataNacimento";
            this.lblDataNacimento.Size = new System.Drawing.Size(61, 13);
            this.lblDataNacimento.TabIndex = 16;
            this.lblDataNacimento.Text = "Nacimento:";
            // 
            // tbxDataNacimento
            // 
            this.tbxDataNacimento.Location = new System.Drawing.Point(23, 155);
            this.tbxDataNacimento.Name = "tbxDataNacimento";
            this.tbxDataNacimento.Size = new System.Drawing.Size(378, 20);
            this.tbxDataNacimento.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(23, 113);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(378, 20);
            this.tbxNome.TabIndex = 13;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 218);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 24;
            this.lblSenha.Text = "Senha:";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(23, 234);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(378, 20);
            this.tbxSenha.TabIndex = 23;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(422, 97);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(292, 246);
            this.dgvUsuario.TabIndex = 25;
            // 
            // FNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 355);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblDataNacimento);
            this.Controls.Add(this.tbxDataNacimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.pTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FNovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.pTopo.ResumeLayout(false);
            this.pTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTopo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.CheckBox cbxAtivo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblDataNacimento;
        private System.Windows.Forms.TextBox tbxDataNacimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.DataGridView dgvUsuario;
    }
}