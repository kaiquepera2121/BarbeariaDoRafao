namespace BarbeariaDoRafao.Telas
{
    partial class FuncionarioLista
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
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbbBuscar = new System.Windows.Forms.ComboBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(3, 243);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(1444, 344);
            this.DgvUsuarios.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(6, 178);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(377, 26);
            this.TxtBuscar.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbbBuscar);
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 225);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Funcionários:";
            // 
            // CbbBuscar
            // 
            this.CbbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbBuscar.FormattingEnabled = true;
            this.CbbBuscar.Items.AddRange(new object[] {
            "Nome",
            "E-mail",
            "Id"});
            this.CbbBuscar.Location = new System.Drawing.Point(10, 102);
            this.CbbBuscar.Name = "CbbBuscar";
            this.CbbBuscar.Size = new System.Drawing.Size(373, 28);
            this.CbbBuscar.TabIndex = 23;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(1304, 12);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(119, 32);
            this.BtnVoltar.TabIndex = 24;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // FuncionarioLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 586);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvUsuarios);
            this.Name = "FuncionarioLista";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FuncionarioLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbbBuscar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}