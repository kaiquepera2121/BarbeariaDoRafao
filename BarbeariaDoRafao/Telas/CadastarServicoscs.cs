using BarbeariaDoRafao.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BarbeariaDoRafao.Telas
{
    public partial class CadastarServicoscs : Form
    {
        private Servico _servicoSelecionado;
        private List<Servico> _servico;

        public CadastarServicoscs()
        {
            InitializeComponent();

            _servico = Servico.BuscarServicos();
        }

        private void ConfiguraDgvUsuarios()
        {

            DgvUsuarios.Columns.Add("Id", "Id");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("Valor", "Valor");
            DgvUsuarios.Columns.Add("TempoEstimado", "Tempo Estimado");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");

            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["TempoEstimado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["TempoEstimado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void CarregaDgvUsuarios(List<Servico> servicos = null)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Servico servico in servicos == null ? _servico : servicos)
            {
                DgvUsuarios.Rows.Add(servico.Id, servico.Nome, servico.Valor, servico.TempoEstimado, servico.Ativo);
                if (!servico.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                else
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void LimpaCampos()
        {
            TxtNome.Clear();
            TxtId.Clear();
            TxtBuscar.Clear();
            TxtValor.Clear();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
        }
        private void CadastarServicoscs_Load(object sender, EventArgs e)
        {

            ConfiguraDgvUsuarios();
            CarregaDgvUsuarios();
            LimpaCampos();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Servico servico = new Servico(0, TxtNome.Text, Convert.ToDouble(TxtValor.Text), Convert.ToInt32(TxtTempoEstimado.Text), true);

                servico.Cadastrar(_servico);
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

        private void BtnLimapr_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            _servicoSelecionado.Nome = TxtNome.Text;
            _servicoSelecionado.Valor = Convert.ToDouble(TxtValor.Text);
            _servicoSelecionado.TempoEstimado = Convert.ToInt32(TxtTempoEstimado.Text);

            _servicoSelecionado.Alterar();
            CarregaDgvUsuarios();
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
                    return;

                TxtNome.Text = _servicoSelecionado.Nome;
                TxtValor.Text = _servicoSelecionado.Valor.ToString();
                TxtTempoEstimado.Text = _servicoSelecionado.TempoEstimado.ToString();
                TxtId.Text = _servicoSelecionado.Id.ToString();

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void DgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (_servicoSelecionado.Ativo == true)
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja remover o serviço {_servicoSelecionado.Nome}?"
                 , "Remover Cliente"
                 , MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        //TODO 2908 - Realizar o update do ativo para 0 de quem está selecionado.
                        _servicoSelecionado.Ativo = false;
                        _servicoSelecionado.Excluir();
                        CarregaDgvUsuarios();
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja ativar esse serviço {_servicoSelecionado.Nome}?"
                        , "Ativar CLiente"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        //TODO 2908 - Realizar o update do ativo para 0 de quem está selecionado.
                        _servicoSelecionado.Ativo = true;
                        _servicoSelecionado.Ativar();
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
