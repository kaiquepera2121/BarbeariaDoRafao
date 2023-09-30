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
            TslNome.Text = _userLogado.Nome;
            TslEmail.Text = _userLogado.Email;
           if (_userLogado.NivelAcesso == 1)
            {
                TslAcesso.Text = "ADM";
            }
            if (_userLogado.NivelAcesso == 2)
            {
                TslAcesso.Text = "Recpsionista";
            }
            else if (_userLogado.NivelAcesso == 3)
            {
                TslAcesso.Text = "Barbeiro";
                BtnGerenciar.Visible = false;
                BtnFaturamento.Visible = false;
                BtnFuncionarios.Visible = false;
                BtnAgenda.Location = new Point(55,182);
                
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< Updated upstream
        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionarioLista funcionario = new FuncionarioLista();
            funcionario.ShowDialog();
        }

        private void BtnGerenciar_Click(object sender, EventArgs e)
        {
            CadastrarTela cadastrar = new CadastrarTela(_userLogado);
            cadastrar.ShowDialog();
=======
        private void BtnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}
