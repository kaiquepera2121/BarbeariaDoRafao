using BarbeariaDoRafao.Classes;
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
    public partial class CadastrarTela : Form
    {
        private Funcionario _userLogado;
        public CadastrarTela(Funcionario usuarios = null)
        {
            InitializeComponent();

            _userLogado = usuarios;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            this.Hide();
            cadastrarCliente.ShowDialog();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario cadastrarFuncionario = new CadastrarFuncionario();
            this.Hide();
            cadastrarFuncionario.ShowDialog();
        }

        private void BtnServico_Click(object sender, EventArgs e)
        {
            CadastarServicos cadastarServicos = new CadastarServicos();
            this.Hide();
            cadastarServicos.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarTela_Load(object sender, EventArgs e)
        {
            if (_userLogado.NivelAcesso == 2)
            {
                BtnServico.Visible = false;
                CadastrarTela cadastrarTela = new CadastrarTela();
            }
        }
    }
}
