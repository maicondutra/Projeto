namespace Restauradora
{
    partial class FNovoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNovoCliente));
            this.pTopo = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.tbxCPFCNPJ = new System.Windows.Forms.TextBox();
            this.lblDataNacimento = new System.Windows.Forms.Label();
            this.tbxDataNacimento = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.pTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pTopo
            // 
            this.pTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTopo.AutoSize = true;
            this.pTopo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pTopo.Controls.Add(this.lblCliente);
            this.pTopo.Controls.Add(this.pbCliente);
            this.pTopo.Location = new System.Drawing.Point(1, 1);
            this.pTopo.Name = "pTopo";
            this.pTopo.Size = new System.Drawing.Size(400, 64);
            this.pTopo.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(117, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(233, 25);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cadastro de Clientes";
            // 
            // pbCliente
            // 
            this.pbCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbCliente.Image")));
            this.pbCliente.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCliente.InitialImage")));
            this.pbCliente.Location = new System.Drawing.Point(11, 11);
            this.pbCliente.Margin = new System.Windows.Forms.Padding(0);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(51, 42);
            this.pbCliente.TabIndex = 0;
            this.pbCliente.TabStop = false;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(15, 106);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(378, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(12, 129);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(62, 13);
            this.lblcpf.TabIndex = 4;
            this.lblcpf.Text = "CPF/CNPJ:";
            // 
            // tbxCPFCNPJ
            // 
            this.tbxCPFCNPJ.Location = new System.Drawing.Point(15, 145);
            this.tbxCPFCNPJ.Name = "tbxCPFCNPJ";
            this.tbxCPFCNPJ.Size = new System.Drawing.Size(378, 20);
            this.tbxCPFCNPJ.TabIndex = 3;
            // 
            // lblDataNacimento
            // 
            this.lblDataNacimento.AutoSize = true;
            this.lblDataNacimento.Location = new System.Drawing.Point(12, 168);
            this.lblDataNacimento.Name = "lblDataNacimento";
            this.lblDataNacimento.Size = new System.Drawing.Size(61, 13);
            this.lblDataNacimento.TabIndex = 6;
            this.lblDataNacimento.Text = "Nacimento:";
            // 
            // tbxDataNacimento
            // 
            this.tbxDataNacimento.Location = new System.Drawing.Point(15, 184);
            this.tbxDataNacimento.Name = "tbxDataNacimento";
            this.tbxDataNacimento.Size = new System.Drawing.Size(378, 20);
            this.tbxDataNacimento.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 207);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(15, 223);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(378, 20);
            this.tbxTelefone.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 284);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Location = new System.Drawing.Point(293, 284);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbxCodigo.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(290, 268);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código:";
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Location = new System.Drawing.Point(15, 261);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbxAtivo.TabIndex = 12;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // FNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 319);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.lblDataNacimento);
            this.Controls.Add(this.tbxDataNacimento);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.tbxCPFCNPJ);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.pTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FNovoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FNovoCliente_FormClosed);
            this.pTopo.ResumeLayout(false);
            this.pTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTopo;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox tbxCPFCNPJ;
        private System.Windows.Forms.Label lblDataNacimento;
        private System.Windows.Forms.TextBox tbxDataNacimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.CheckBox cbxAtivo;
    }
}