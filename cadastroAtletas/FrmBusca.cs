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
    public partial class FrmBusca : Form
    {
        int idAlterar;

        private Form frmAtivo;
        public FrmBusca()
        {
            InitializeComponent();

        }


        private void FormShow(Form frm)
        {
            FrmCadastro frmCad = new FrmCadastro();
            FrmAlteraAtleta frmAlteraAtleta = new FrmAlteraAtleta();
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            frmAlteraAtleta.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveButton(Button frmAtivo)
        {
            FrmAlteraAtleta frmAltAt = new FrmAlteraAtleta();
            foreach (Control ctrl in frmAltAt.Controls)
            {
                ctrl.ForeColor = Color.White;
            }

        }


        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }


        public void lista_gridAtletas()
        {
            ConectaBanco con = new ConectaBanco();
            dgAtletas.DataSource = con.listaAtletas();
            dgAtletas.Columns["ID"].Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgAtletas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgAtletas.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome like '{0}%'", txtBusca.Text);
        }


        private void FrmBusca_Load(object sender, EventArgs e)
        {
            lista_gridAtletas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int linha = dgAtletas.CurrentRow.Index;
            int id = Convert.ToInt32(dgAtletas.Rows[linha].Cells["ID"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem Certeza que deseja remover esse Atleta?", "Remove Atleta", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaAtleta(id);
                if (retorno == true)
                {
                    MessageBox.Show("Atleta excluido com sucesso!");
                    lista_gridAtletas();
                }//fim do if com retorno true
                else
                {
                    MessageBox.Show(con.mensagem);
                }
            }//fim do if ok cancela
            else
            {
                MessageBox.Show("Exclusão Cancelada");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmAlteraAtleta frmaltat = new FrmAlteraAtleta();
            FrmCadastro frmCad = new FrmCadastro();
            int linha = dgAtletas.CurrentRow.Index;//pega a linha selecionada
            idAlterar = Convert.ToInt32(dgAtletas.Rows[linha].Cells["ID"].Value.ToString());
            frmaltat.txtNomeAlteraAt.Text = dgAtletas.Rows[linha].Cells["nome"].Value.ToString();
            frmaltat.txtDataNascAlteraAt.Text = dgAtletas.Rows[linha].Cells["data_nasc"].Value.ToString();
            frmaltat.txtCidadeAlteraAt.Text = dgAtletas.Rows[linha].Cells["cidade"].Value.ToString();
            frmaltat.cbClubeAlteraAt.Text = dgAtletas.Rows[linha].Cells["clube"].Value.ToString();
            frmaltat.txtAlteraFederadoAt.Text = dgAtletas.Rows[linha].Cells["federado"].Value.ToString();
            frmaltat.lblIdAlterar.Text = idAlterar.ToString();
            this.Hide();
            frmaltat.Show();
            

        }
    }
}
