using BarbeariaDoRafao.Classes;
using BarbeariaDoRafao.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaDoRafao
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
 

                Usuarios usuarios = Usuarios.RealizarLogin(TxtEmail.Text, TxtSenha.Text);

                TelaPrincipal principal = new TelaPrincipal((Funcionario)usuarios);
                this.Hide();
                principal.ShowDialog();
                this.Show();
                TxtSenha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
              , "Escola X"
              , MessageBoxButtons.OK
              , MessageBoxIcon.Error);

            }
        }


    }
}
