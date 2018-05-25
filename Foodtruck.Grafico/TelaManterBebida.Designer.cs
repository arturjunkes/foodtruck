namespace Foodtruck.Grafico
{
    partial class TelaManterBebida
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(35, 43);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(43, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(40, 82);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Location = new System.Drawing.Point(23, 121);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(55, 13);
            this.lbTamanho.TabIndex = 2;
            this.lbTamanho.Text = "Tamanho:";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(44, 159);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(34, 13);
            this.Valor.TabIndex = 3;
            this.Valor.Text = "Valor:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(84, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(84, 79);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 5;
            // 
            // tbTamanho
            // 
            this.tbTamanho.Location = new System.Drawing.Point(84, 118);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(100, 20);
            this.tbTamanho.TabIndex = 6;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(84, 156);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 7;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(262, 217);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(181, 217);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // TelaManterBebida
            // 
            this.ClientSize = new System.Drawing.Size(349, 252);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCodigo);
            this.Name = "TelaManterBebida";
            this.Text = "Bebida";
            this.Load += new System.EventHandler(this.TelaManterBebida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}