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
    public partial class CadastrarCliente : Form
    {
        Cliente _clienteSelecionado;
        List<Cliente> _clientes;

        public CadastrarCliente()
        {
            InitializeComponent();

            try
            {
                _clientes = Usuarios.BuscarUsuarios().ConvertAll(u => (Cliente)u);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string genero;
            if (ChxMulher.Checked)
            {
                genero = "Mulher";
            }
            else
            {
                genero = "Homem";
            }

            Cliente cliente = new Cliente(0, TxtNome.Text, TxtEmail.Text, "123", genero,true);

            cliente.Cadastrar(_clientes);
            LimparCampos();
            
        }

        private void ConfiguraDgvClientes()
        {
            DgvUsuarios.Columns.Add("Id", "Id");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("Genero", "Genero");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");

            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Genero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Genero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void CarregarDgvClientes(List<Cliente> clientes = null)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Cliente cliente in clientes == null ? _clientes : clientes)
            {
                DgvUsuarios.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.Genero, cliente.Ativo);
            }
     
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraDgvClientes();
                CarregarDgvClientes();
                LimparCampos();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                         "Erro",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }

       
        }

        private void LimparCampos()
        {
            TxtEmail.Clear();
            TxtNome.Clear();
            ChxMulher.Checked = false;
            CbxHomen.Checked = true;
        }

        private void DgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(_clienteSelecionado.Ativo == true)
                {
                     DialogResult dr = MessageBox.Show($"Você realmente deseja remover {_clienteSelecionado.Nome}?"
                  , "Remover Aluno"
                  , MessageBoxButtons.YesNo
                  , MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        //TODO 2908 - Realizar o update do ativo para 0 de quem está selecionado.
                        _clienteSelecionado.Ativo = false;
                        _clienteSelecionado.Excluir();
                        CarregarDgvClientes();
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

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
                    return;

                _clienteSelecionado = _clientes.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);

                TxtEmail.Text = _clienteSelecionado.Email;
                TxtNome.Text = _clienteSelecionado.Nome;
                TxtId.Text = _clienteSelecionado.Id.ToString();
                if (_clienteSelecionado.Genero == "Masculino")
                {
                    CbxHomen.Checked = true;
                    ChxMulher.Checked = false;
                }
                else
                {
                    CbxHomen.Checked = false;
                    ChxMulher.Checked = true;
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

        private void TmrCadastro_Tick(object sender, EventArgs e)
        {
            CarregarDgvClientes();
            TmrCadastro.Start();
        }
    }
}
