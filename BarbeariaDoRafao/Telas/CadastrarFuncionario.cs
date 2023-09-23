﻿using BarbeariaDoRafao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaDoRafao.Telas
{
    public partial class CadastrarFuncionario : Form
    {
        Funcionario _funcionarioSelecionado;
        List<Funcionario> _funcionario;

        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                _funcionario = Usuarios.BuscarUsuarios().ConvertAll(u => (Funcionario)u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
