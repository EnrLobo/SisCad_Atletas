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
    public partial class FrmCadAtleta : Form
    {
        public FrmCadAtleta()
        {
            InitializeComponent();
        }



        public void listaCbClube()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDadosClub = new DataTable();
            tabelaDadosClub = con.listaClubes();
            cbClubeCadAt.DataSource = tabelaDadosClub;
            cbClubeCadAt.DisplayMember = "nomeClube";
            cbClubeCadAt.ValueMember = "id_clube";
        }

        void limpaCampos()
        {
            txtNomeCadAt.Clear();
            cbClubeCadAt.Text = "";
            txtDataNascCadAt.Clear();
            txtCidadeCadAt.Clear();
            txtFederado.Clear();
            txtNomeCadAt.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbClubeCadAt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnConfirmaCadAt_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Atleta novoAtleta = new Atleta();
            novoAtleta.Nome = txtNomeCadAt.Text;
            novoAtleta.Clube = Convert.ToInt32(cbClubeCadAt.SelectedValue.ToString());
            novoAtleta.Data_nasc = txtDataNascCadAt.Text;
            novoAtleta.Cidade = txtCidadeCadAt.Text;
            novoAtleta.Federacao = txtFederado.Text;
            bool retorno = con.insereAtleta(novoAtleta);

            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }

            limpaCampos();
            // FrmBusca.dgAtleta
            //lista_gridAtletas();
        }

        private void FrmCadAtleta_Load(object sender, EventArgs e)
        {
            listaCbClube();
        }
    }
}
