namespace BarbeariaDoRafao
{
    partial class TelaLogin
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
            this.QdoLabel = new System.Windows.Forms.Label();
            this.EqcSenha = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QdoLabel
            // 
            this.QdoLabel.BackColor = System.Drawing.Color.Gray;
            this.QdoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QdoLabel.Location = new System.Drawing.Point(342, 141);
            this.QdoLabel.Name = "QdoLabel";
            this.QdoLabel.Size = new System.Drawing.Size(370, 307);
            this.QdoLabel.TabIndex = 0;
            // 
            // EqcSenha
            // 
            this.EqcSenha.AutoSize = true;
            this.EqcSenha.BackColor = System.Drawing.Color.Gray;
            this.EqcSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqcSenha.ForeColor = System.Drawing.Color.Transparent;
            this.EqcSenha.Location = new System.Drawing.Point(380, 364);
            this.EqcSenha.Name = "EqcSenha";
            this.EqcSenha.Size = new System.Drawing.Size(92, 16);
            this.EqcSenha.TabIndex = 3;
            this.EqcSenha.Text = "Esqueci a Senha";
            this.EqcSenha.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(377, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 42);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "E-mail:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(377, 314);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 42);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(465, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BarbeariaDoRafao.Properties.Resources.smooth_gray_background;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EqcSenha);
            this.Controls.Add(this.QdoLabel);
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QdoLabel;
        private System.Windows.Forms.CheckBox EqcSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

