namespace BarbeariaDoRafao.Telas
{
    partial class CadastrarTela
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
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnServico = new System.Windows.Forms.Button();
            this.GnxCadastar = new System.Windows.Forms.GroupBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.GnxCadastar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(162, 101);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(151, 52);
            this.BtnCliente.TabIndex = 16;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuncionario.Location = new System.Drawing.Point(162, 184);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(151, 52);
            this.BtnFuncionario.TabIndex = 17;
            this.BtnFuncionario.Text = "Funcionário";
            this.BtnFuncionario.UseVisualStyleBackColor = true;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // BtnServico
            // 
            this.BtnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServico.Location = new System.Drawing.Point(162, 275);
            this.BtnServico.Name = "BtnServico";
            this.BtnServico.Size = new System.Drawing.Size(151, 52);
            this.BtnServico.TabIndex = 18;
            this.BtnServico.Text = "Serviço";
            this.BtnServico.UseVisualStyleBackColor = true;
            this.BtnServico.Click += new System.EventHandler(this.BtnServico_Click);
            // 
            // GnxCadastar
            // 
            this.GnxCadastar.Controls.Add(this.BtnVoltar);
            this.GnxCadastar.Controls.Add(this.BtnCliente);
            this.GnxCadastar.Controls.Add(this.BtnServico);
            this.GnxCadastar.Controls.Add(this.BtnFuncionario);
            this.GnxCadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GnxCadastar.Location = new System.Drawing.Point(2, 12);
            this.GnxCadastar.Name = "GnxCadastar";
            this.GnxCadastar.Size = new System.Drawing.Size(458, 398);
            this.GnxCadastar.TabIndex = 19;
            this.GnxCadastar.TabStop = false;
            this.GnxCadastar.Text = "Cadastar:";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(10, 40);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(119, 32);
            this.BtnVoltar.TabIndex = 19;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // CadastrarTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 422);
            this.Controls.Add(this.GnxCadastar);
            this.Name = "CadastrarTela";
            this.Text = "CadastrarTela";
            this.Load += new System.EventHandler(this.CadastrarTela_Load);
            this.GnxCadastar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnServico;
        private System.Windows.Forms.GroupBox GnxCadastar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}