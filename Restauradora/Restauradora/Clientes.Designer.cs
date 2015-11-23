namespace Restauradora
{
    partial class FClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnRemoveCliente = new System.Windows.Forms.Button();
            this.btnAdicionaCliente = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 81);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(666, 227);
            this.dgvClientes.TabIndex = 10;
            // 
            // btnRemoveCliente
            // 
            this.btnRemoveCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCliente.Image")));
            this.btnRemoveCliente.Location = new System.Drawing.Point(82, 12);
            this.btnRemoveCliente.Name = "btnRemoveCliente";
            this.btnRemoveCliente.Size = new System.Drawing.Size(66, 63);
            this.btnRemoveCliente.TabIndex = 1;
            this.btnRemoveCliente.UseVisualStyleBackColor = true;
            this.btnRemoveCliente.Click += new System.EventHandler(this.btnRemoveCliente_Click);
            // 
            // btnAdicionaCliente
            // 
            this.btnAdicionaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionaCliente.Image")));
            this.btnAdicionaCliente.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionaCliente.Name = "btnAdicionaCliente";
            this.btnAdicionaCliente.Size = new System.Drawing.Size(64, 63);
            this.btnAdicionaCliente.TabIndex = 0;
            this.btnAdicionaCliente.UseVisualStyleBackColor = true;
            this.btnAdicionaCliente.Click += new System.EventHandler(this.btnAdicionaCliente_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(155, 13);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(62, 62);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 320);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnRemoveCliente);
            this.Controls.Add(this.btnAdicionaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionaCliente;
        private System.Windows.Forms.Button btnRemoveCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAtualizar;
    }
}