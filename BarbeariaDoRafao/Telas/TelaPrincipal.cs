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
    public partial class TelaPrincipal : Form
    {
        Funcionario _userLogado;

        public TelaPrincipal(Funcionario usuarios)
        {
            InitializeComponent();
           
            _userLogado = usuarios;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

            TslEmail.Text = _userLogado.Email;
            TslUserNome.Text = _userLogado.Nome;

            if (_userLogado.NivelAcesso == 3)
            {
                TslPerfil.Text = "Barbeiro";
                TsmCadastrar.Visible = false;
                TsmRelatorio.Visible = false;
                
            }
            if(_userLogado.NivelAcesso == 2)
            {
                TslPerfil.Text = "Recepcionista";
                TsmRelatorio.Visible= false;
                TsmCadastarServico.Visible = false;
            }
            if (_userLogado.NivelAcesso == 1)
            {
                TslPerfil.Text = "ADM";
            }
            
              
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsmCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.ShowDialog();
        }

        private void TsmCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario cadastrarFuncionario = new CadastrarFuncionario();
            cadastrarFuncionario.ShowDialog();
        }
    }
}
