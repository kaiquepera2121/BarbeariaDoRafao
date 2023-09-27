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
    public partial class CadastrarFuncionario : Form
    {
        Funcionario _funcionarioSelecionado;
        List<Funcionario> _funcionario;

        public CadastrarFuncionario()
        {
            InitializeComponent();

            _funcionario = Usuarios.BuscarUsuarios("Funcionario").ConvertAll(u => (Funcionario)u);
        }

        private void ConfiguraDgvUsuarios()
        {
 
            DgvUsuarios.Columns.Add("Id", "Id");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("NivelAcesso", "NIvel Acesso");
            DgvUsuarios.Columns.Add("DtNascimento", "Data Nascimento");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");
   
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["NivelAcesso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["NivelAcesso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {              
                Funcionario funcionario = new Funcionario(0
                     , TxtNome.Text
                     , txtEmail.Text
                     , "123"
                     , RdbBarbeiro.Checked == true ? 3 : 2
                     , DtpDataNAscimento.Value
                     , DateTime.Now
                     , DateTime.MinValue
                     , 1000
                     , true);

                funcionario.Cadastrar(_funcionario);
                CarregaDgvUsuarios();
                LimpaCampos();

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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            _funcionarioSelecionado.Nome = TxtNome.Text;
            _funcionarioSelecionado.Email = txtEmail.Text;
            _funcionarioSelecionado.DtNascimento = DtpDataNAscimento.Value;
            //_funcionarioSelecionado.NivelAcesso = RdbBarbeiro.Checked == true ? 3 : 2 ;

            //if (RdbBarbeiro.Checked)
            //{
            //    _funcionarioSelecionado.NivelAcesso = 3;
            //}
            //else
            //{
            //    _funcionarioSelecionado.NivelAcesso = 2;
            //}

            _funcionarioSelecionado.Alterar();
            CarregaDgvUsuarios();

        }

        private void BtnLimapr_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void CarregaDgvUsuarios(List<Funcionario> funcionarios = null)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios == null ? _funcionario : funcionarios)
            {
                DgvUsuarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Email, funcionario.NivelAcesso, funcionario.DtNascimento, funcionario.Ativo);
                if (!funcionario.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
            }

        }

        private void LimpaCampos()
        {
            txtEmail.Clear();
            TxtNome.Clear();
            RdbBarbeiro.Checked = true;
            RdbRecepcionista.Checked = false;
            TxtId.Clear();
            DtpDataNAscimento.Value = new DateTime(1990, 1, 1);
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
    

            ConfiguraDgvUsuarios();
            CarregaDgvUsuarios();
            LimpaCampos();
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
                    return;

                _funcionarioSelecionado = _funcionario.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);

                txtEmail.Text = _funcionarioSelecionado.Email;
                TxtId.Text = _funcionarioSelecionado.Id.ToString();
                TxtNome.Text = _funcionarioSelecionado.Nome;
                DtpDataNAscimento.Value = _funcionarioSelecionado.DtNascimento.ToLocalTime();

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
                if (RdbBarbeiro.Checked)
                {
                    RdbBarbeiro.Checked = true;
                    RdbRecepcionista.Checked = false;
                }
                else if (RdbRecepcionista.Checked)
                {
                    RdbBarbeiro.Checked = false;
                    RdbRecepcionista.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (_funcionarioSelecionado.Ativo == true)
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja remover o funcionario {_funcionarioSelecionado.Nome}?"
                 , "Remover Cliente"
                 , MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        //TODO 2908 - Realizar o update do ativo para 0 de quem está selecionado.
                        _funcionarioSelecionado.Ativo = false;
                        _funcionarioSelecionado.Excluir();
                        CarregaDgvUsuarios();
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja ativar esse funcionario {_funcionarioSelecionado.Nome}?"
                        , "Ativar CLiente"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        //TODO 2908 - Realizar o update do ativo para 0 de quem está selecionado.
                        _funcionarioSelecionado.Ativo = true;
                        _funcionarioSelecionado.Ativar();
                        CarregaDgvUsuarios();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
