namespace cadastroAtletas
{
    public partial class FrmCadastro : Form
    {
        private Form frmAtivo;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnlMenu.Controls)
            {
                ctrl.ForeColor = Color.White;

            }

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadAtleta_Click(object sender, EventArgs e)
        {

        }

        private void btnCadClube_Click(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadAtleta_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnCadAtleta);
            FormShow(new FrmCadAtleta());
            marcador.Height = btnCadAtleta.Height;
            marcador.Top = btnCadAtleta.Top;

        }

        private void btnCadClube_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnCadClube);
            FormShow(new FrmCadClube());
            marcador.Height = btnCadClube.Height;
            marcador.Top = btnCadClube.Top;
        }

        private void btnBusca_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnBusca);
            FormShow(new FrmBusca());
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
        }

        private void btnAlteraAtleta_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAlteraAtleta);
            FormShow(new FrmAlteraAtleta());
            marcador.Height = btnAlteraAtleta.Height;
            marcador.Top = btnAlteraAtleta.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}