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
    public partial class FuncionarioLista : Form
    {
        public FuncionarioLista()
        {
            InitializeComponent();
        }

        private void FuncionarioLista_Load(object sender, EventArgs e)
        {

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
    }
}
