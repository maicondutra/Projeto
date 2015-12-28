namespace Restauradora
{
    partial class ViewPadrao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPadrao));
            this.pControl = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.btnAddPadrao = new System.Windows.Forms.Button();
            this.pAddCliente = new System.Windows.Forms.Panel();
            this.pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.pAddCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pControl.Controls.Add(this.btnEditar);
            this.pControl.Controls.Add(this.btnAtualizar);
            this.pControl.Controls.Add(this.btnExluir);
            this.pControl.Controls.Add(this.btnNovo);
            this.pControl.Location = new System.Drawing.Point(1, 2);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(557, 85);
            this.pControl.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(173, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 79);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Location = new System.Drawing.Point(258, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(79, 79);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExluir.BackgroundImage")));
            this.btnExluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExluir.Location = new System.Drawing.Point(88, 3);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(79, 79);
            this.btnExluir.TabIndex = 1;
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(79, 79);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToOrderColumns = true;
            this.dgvCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Location = new System.Drawing.Point(4, 93);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(550, 181);
            this.dgvCadastro.TabIndex = 1;
            // 
            // btnAddPadrao
            // 
            this.btnAddPadrao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPadrao.Location = new System.Drawing.Point(472, 3);
            this.btnAddPadrao.Name = "btnAddPadrao";
            this.btnAddPadrao.Size = new System.Drawing.Size(75, 23);
            this.btnAddPadrao.TabIndex = 0;
            this.btnAddPadrao.Text = "Adiciona";
            this.btnAddPadrao.UseVisualStyleBackColor = true;
            this.btnAddPadrao.Click += new System.EventHandler(this.btnAddPadrao_Click);
            // 
            // pAddCliente
            // 
            this.pAddCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAddCliente.Controls.Add(this.btnAddPadrao);
            this.pAddCliente.Location = new System.Drawing.Point(4, 280);
            this.pAddCliente.Name = "pAddCliente";
            this.pAddCliente.Size = new System.Drawing.Size(550, 30);
            this.pAddCliente.TabIndex = 2;
            this.pAddCliente.Visible = false;
            // 
            // ViewPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 312);
            this.Controls.Add(this.pAddCliente);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.pControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPadrao";
            this.Text = "View Padrão";
            this.pControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.pAddCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnAddPadrao;
        private System.Windows.Forms.Panel pAddCliente;
    }
}