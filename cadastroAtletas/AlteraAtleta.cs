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
    public partial class FrmAlteraAtleta : Form
    {
        int idAlterar;
        public FrmAlteraAtleta()
        {
            InitializeComponent();
            listaCbClube();
            lblIdAlterar.Visible = false;
        }

        public void lista_gridAtletas()
        {
            FrmBusca frmBusca = new FrmBusca();
            ConectaBanco con = new ConectaBanco();
            frmBusca.dgAtletas.DataSource = con.listaAtletas();
            frmBusca.dgAtletas.Columns["ID"].Visible = false;
        }
        public void listaCbClube()
        {

            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDadosClub = new DataTable();
            tabelaDadosClub = con.listaClubes();
            cbClubeAlteraAt.DataSource = tabelaDadosClub;
            cbClubeAlteraAt.DisplayMember = "nomeClube";
            cbClubeAlteraAt.ValueMember = "id_clube";
        }
        private void btnConfirmaAltAt_Click(object sender, EventArgs e)
        {

            ConectaBanco con = new ConectaBanco();
            Atleta novoAtleta = new Atleta();
            novoAtleta.Nome = txtNomeAlteraAt.Text;
            novoAtleta.Data_nasc = txtDataNascAlteraAt.Text;
            novoAtleta.Cidade = txtCidadeAlteraAt.Text;
            novoAtleta.Federacao = txtAlteraFederadoAt.Text;
            novoAtleta.Clube = Convert.ToInt32(cbClubeAlteraAt.SelectedValue.ToString());
            idAlterar = Convert.ToInt32(lblIdAlterar.Text);
            

            bool retorno = con.alteraAtleta(novoAtleta, idAlterar);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
            else
            {
                MessageBox.Show("Alteração realizada com sucesso!");
            }

            lista_gridAtletas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtNomeAlteraAt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAlteraAtleta_Load(object sender, EventArgs e)
        {
         
        }
    }
}
