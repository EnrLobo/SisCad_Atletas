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
    public partial class FrmCadClube : Form
    {
        public FrmCadClube()
        {
            InitializeComponent();
        }

        void limpaCampos()
        {
            txtNomeCadCb.Clear();
            txtCidadeCadCb.Clear();
            txtEstadoCadCb.Clear();
            txtFiliadoCadCb.Clear();
            txtNomeCadCb.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaCadCb_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Clube novoClube = new Clube();
            novoClube.NomeClube = txtNomeCadCb.Text;
            novoClube.CidadeClube = txtCidadeCadCb.Text;
            novoClube.Estado = txtEstadoCadCb.Text;
            novoClube.Filiado = txtFiliadoCadCb.Text;
            bool retorno = con.insereClube(novoClube);

            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }

            limpaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
