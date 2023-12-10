using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroAtletas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            if (con.verifica(txtUserLogin.Text, txtSenhaLogin.Text) == true)
            {
                FrmCadastro sistema = new FrmCadastro();
                this.Hide();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta" + con.mensagem);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
