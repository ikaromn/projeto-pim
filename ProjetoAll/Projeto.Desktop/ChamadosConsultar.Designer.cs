namespace Projeto.Desktop
{
    partial class ChamadosConsultar
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
            this.GrdChamados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCha = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.Chamado = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdChamados
            // 
            this.GrdChamados.AllowUserToAddRows = false;
            this.GrdChamados.AllowUserToDeleteRows = false;
            this.GrdChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chamado});
            this.GrdChamados.Location = new System.Drawing.Point(27, 116);
            this.GrdChamados.Name = "GrdChamados";
            this.GrdChamados.ReadOnly = true;
            this.GrdChamados.Size = new System.Drawing.Size(685, 276);
            this.GrdChamados.TabIndex = 0;
            this.GrdChamados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdChamados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chamado";
            // 
            // txtIdCha
            // 
            this.txtIdCha.Location = new System.Drawing.Point(111, 41);
            this.txtIdCha.Name = "txtIdCha";
            this.txtIdCha.Size = new System.Drawing.Size(100, 20);
            this.txtIdCha.TabIndex = 2;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(45, 76);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Chamado
            // 
            this.Chamado.HeaderText = "Chamado";
            this.Chamado.Name = "Chamado";
            // 
            // ChamadosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 437);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtIdCha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdChamados);
            this.Name = "ChamadosConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamadosConsultar";
            this.Load += new System.EventHandler(this.ChamadosConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdChamados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCha;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DataGridViewLinkColumn Chamado;
    }
}