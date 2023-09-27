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
                _clientes = Usuarios.BuscarUsuarios("Cliente").ConvertAll(u => (Cliente)u);
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
            if (RdbMulher.Checked)
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
            CarregarDgvClientes();
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
                if (!cliente.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                else
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
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
            RdbMulher.Checked = false;
            RdbHomem.Checked = true;
            TxtId.Clear();
           
        }

        private void DgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(_clienteSelecionado.Ativo == true)
                {
                     DialogResult dr = MessageBox.Show($"Você realmente deseja remover o cliente {_clienteSelecionado.Nome}?"
                  , "Remover Cliente"
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
                else
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja ativar esse cliente {_clienteSelecionado.Nome}?"
                        , "Ativar CLiente"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        //TODO 2908 - Realizar o update do ativo para 0 de quem está selecionado.
                        _clienteSelecionado.Ativo = true;
                        _clienteSelecionado.Ativar();
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
                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
                if (_clienteSelecionado.Genero == "Masculino")
                {
                    RdbHomem.Checked = true;
                    RdbMulher.Checked = false;
                }
                else
                {
                    RdbHomem.Checked = false;
                    RdbMulher.Checked = true;
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            _clienteSelecionado.Nome = TxtNome.Text;
            _clienteSelecionado.Email = TxtEmail.Text;
            _clienteSelecionado.Genero = RdbHomem.Checked == true ? "Masculino" : "Feminino";

            _clienteSelecionado.Alterar();
            CarregarDgvClientes();

        }

        private void BtnLimapr_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            RdbHomem.Checked = true;
            RdbMulher.Checked = false;
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = Cliente.Buscar(_clientes,CbbBuscar.SelectedIndex,TxtBuscar.Text);
            CarregarDgvClientes(lista);

        }
    }
}
