namespace Projeto.Desktop
{
    partial class ChamadoAbrir
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
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbProblema = new System.Windows.Forms.ComboBox();
            this.txtDes = new System.Windows.Forms.RichTextBox();
            this.txtSol = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(100, 39);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(223, 21);
            this.cmbEmpresa.TabIndex = 0;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(100, 99);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(223, 21);
            this.cmbArea.TabIndex = 1;
            // 
            // cmbProblema
            // 
            this.cmbProblema.FormattingEnabled = true;
            this.cmbProblema.Location = new System.Drawing.Point(100, 150);
            this.cmbProblema.Name = "cmbProblema";
            this.cmbProblema.Size = new System.Drawing.Size(223, 21);
            this.cmbProblema.TabIndex = 2;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(100, 221);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(223, 134);
            this.txtDes.TabIndex = 3;
            this.txtDes.Text = "";
            // 
            // txtSol
            // 
            this.txtSol.Location = new System.Drawing.Point(100, 380);
            this.txtSol.Name = "txtSol";
            this.txtSol.Size = new System.Drawing.Size(223, 20);
            this.txtSol.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(100, 435);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(223, 20);
            this.txtTel.TabIndex = 5;
            this.txtTel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Problema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Solicitante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(100, 473);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(223, 23);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Abrir Chamado";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChamadoAbrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 508);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSol);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cmbProblema);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbEmpresa);
            this.Name = "ChamadoAbrir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamadoAbrir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbProblema;
        private System.Windows.Forms.RichTextBox txtDes;
        private System.Windows.Forms.TextBox txtSol;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbrir;
    }
}