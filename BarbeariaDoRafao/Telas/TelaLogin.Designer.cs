﻿namespace BarbeariaDoRafao
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
            this.ChxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QdoLabel
            // 
            this.QdoLabel.BackColor = System.Drawing.Color.Gray;
            this.QdoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QdoLabel.Location = new System.Drawing.Point(342, 137);
            this.QdoLabel.Name = "QdoLabel";
            this.QdoLabel.Size = new System.Drawing.Size(370, 307);
            this.QdoLabel.TabIndex = 0;
            // 
            // ChxMostrarSenha
            // 
            this.ChxMostrarSenha.AutoSize = true;
            this.ChxMostrarSenha.BackColor = System.Drawing.Color.Gray;
            this.ChxMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChxMostrarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.ChxMostrarSenha.Location = new System.Drawing.Point(383, 336);
            this.ChxMostrarSenha.Name = "ChxMostrarSenha";
            this.ChxMostrarSenha.Size = new System.Drawing.Size(85, 16);
            this.ChxMostrarSenha.TabIndex = 3;
            this.ChxMostrarSenha.Text = "Mostrar Senha";
            this.ChxMostrarSenha.UseVisualStyleBackColor = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtEmail.Location = new System.Drawing.Point(380, 237);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(295, 42);
            this.TxtEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(468, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtSenha.Location = new System.Drawing.Point(379, 285);
            this.TxtSenha.Multiline = true;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(295, 42);
            this.TxtSenha.TabIndex = 8;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BarbeariaDoRafao.Properties.Resources.smooth_gray_background;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.ChxMostrarSenha);
            this.Controls.Add(this.QdoLabel);
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QdoLabel;
        private System.Windows.Forms.CheckBox ChxMostrarSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSenha;
    }
}

