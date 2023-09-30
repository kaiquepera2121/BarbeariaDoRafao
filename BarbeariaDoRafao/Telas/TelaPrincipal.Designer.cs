namespace BarbeariaDoRafao.Telas
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslNome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslEmail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslAcesso = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAgenda = new System.Windows.Forms.Button();
            this.BtnFuncionarios = new System.Windows.Forms.Button();
            this.BtnFaturamento = new System.Windows.Forms.Button();
            this.BtnGerenciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 924);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(41, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raff\'a Barber";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(71, 849);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Since 1995";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label9.Location = new System.Drawing.Point(171, 848);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 34);
            this.label9.TabIndex = 10;
            this.label9.Text = "®";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label11.Location = new System.Drawing.Point(211, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "™";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.AutoSize = true;
            this.BtnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.BtnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPerfil.Location = new System.Drawing.Point(1706, 18);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(165, 38);
            this.BtnPerfil.TabIndex = 17;
            this.BtnPerfil.Text = "Perfil";
            this.BtnPerfil.UseVisualStyleBackColor = false;
            this.BtnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1603, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1631, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(258, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1634, 10);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuText;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TslNome,
            this.toolStripStatusLabel2,
            this.TslEmail,
            this.toolStripStatusLabel4,
            this.TslAcesso,
            this.TslDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1014);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1904, 27);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripStatusLabel1.Text = "User:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TslNome
            // 
            this.TslNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslNome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TslNome.Name = "TslNome";
            this.TslNome.Size = new System.Drawing.Size(207, 22);
            this.TslNome.Text = "Raffael Fernando Moreira";
            this.TslNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripStatusLabel2.Text = "E-mail:";
            // 
            // TslEmail
            // 
            this.TslEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TslEmail.Name = "TslEmail";
            this.TslEmail.Size = new System.Drawing.Size(197, 22);
            this.TslEmail.Text = "raffanoreira@gmail.com";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 22);
            this.toolStripStatusLabel4.Text = "Profile:";
            // 
            // TslAcesso
            // 
            this.TslAcesso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslAcesso.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TslAcesso.Name = "TslAcesso";
            this.TslAcesso.Size = new System.Drawing.Size(120, 22);
            this.TslAcesso.Text = "Administrador";
            // 
            // TslDataHora
            // 
            this.TslDataHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslDataHora.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TslDataHora.Name = "TslDataHora";
            this.TslDataHora.Size = new System.Drawing.Size(1178, 22);
            this.TslDataHora.Spring = true;
            this.TslDataHora.Text = "27/09/2023 00:00";
            this.TslDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAgenda
            // 
            this.BtnAgenda.AutoSize = true;
            this.BtnAgenda.BackColor = System.Drawing.Color.Black;
            this.BtnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgenda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgenda.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnAgenda.Location = new System.Drawing.Point(48, 410);
            this.BtnAgenda.Name = "BtnAgenda";
            this.BtnAgenda.Size = new System.Drawing.Size(165, 39);
            this.BtnAgenda.TabIndex = 25;
            this.BtnAgenda.Text = "Agenda";
            this.BtnAgenda.UseVisualStyleBackColor = false;
            this.BtnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // BtnFuncionarios
            // 
            this.BtnFuncionarios.AutoSize = true;
            this.BtnFuncionarios.BackColor = System.Drawing.Color.Black;
            this.BtnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuncionarios.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnFuncionarios.Location = new System.Drawing.Point(48, 527);
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Size = new System.Drawing.Size(165, 45);
            this.BtnFuncionarios.TabIndex = 27;
            this.BtnFuncionarios.Text = "Funcionários";
            this.BtnFuncionarios.UseVisualStyleBackColor = false;
            this.BtnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // BtnFaturamento
            // 
            this.BtnFaturamento.AutoSize = true;
            this.BtnFaturamento.BackColor = System.Drawing.Color.Black;
            this.BtnFaturamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaturamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaturamento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnFaturamento.Location = new System.Drawing.Point(48, 653);
            this.BtnFaturamento.Name = "BtnFaturamento";
            this.BtnFaturamento.Size = new System.Drawing.Size(165, 44);
            this.BtnFaturamento.TabIndex = 28;
            this.BtnFaturamento.Text = "Faturamento";
            this.BtnFaturamento.UseVisualStyleBackColor = false;
            // 
            // BtnGerenciar
            // 
            this.BtnGerenciar.AutoSize = true;
            this.BtnGerenciar.BackColor = System.Drawing.Color.Black;
            this.BtnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerenciar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerenciar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGerenciar.Location = new System.Drawing.Point(27, 304);
            this.BtnGerenciar.Name = "BtnGerenciar";
            this.BtnGerenciar.Size = new System.Drawing.Size(206, 46);
            this.BtnGerenciar.TabIndex = 30;
            this.BtnGerenciar.Text = "Gerenciar Cadastro";
            this.BtnGerenciar.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
            this.BtnGerenciar.Click += new System.EventHandler(this.BtnGerenciar_Click);
=======
>>>>>>> Stashed changes
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(264, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bem-Vindo(a) !";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGerenciar);
            this.Controls.Add(this.BtnFaturamento);
            this.Controls.Add(this.BtnFuncionarios);
            this.Controls.Add(this.BtnAgenda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnPerfil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "TelaPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button BtnPerfil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TslNome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TslEmail;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel TslAcesso;
        private System.Windows.Forms.ToolStripStatusLabel TslDataHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button BtnAgenda;
        public System.Windows.Forms.Button BtnFuncionarios;
        public System.Windows.Forms.Button BtnFaturamento;
        public System.Windows.Forms.Button BtnGerenciar;
        private System.Windows.Forms.Label label2;
    }
}

