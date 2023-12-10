namespace cadastroAtletas
{
    partial class FrmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            marcador = new Panel();
            btnAlteraAtleta = new Button();
            btnBusca = new Button();
            btnCadClube = new Button();
            btnCadAtleta = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnlForm = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(7, 47, 100);
            pnlMenu.Controls.Add(marcador);
            pnlMenu.Controls.Add(btnAlteraAtleta);
            pnlMenu.Controls.Add(btnBusca);
            pnlMenu.Controls.Add(btnCadClube);
            pnlMenu.Controls.Add(btnCadAtleta);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 581);
            pnlMenu.TabIndex = 0;
            // 
            // marcador
            // 
            marcador.BackColor = Color.Yellow;
            marcador.Location = new Point(0, 107);
            marcador.Name = "marcador";
            marcador.Size = new Size(12, 80);
            marcador.TabIndex = 6;
            // 
            // btnAlteraAtleta
            // 
            btnAlteraAtleta.Dock = DockStyle.Top;
            btnAlteraAtleta.FlatAppearance.BorderSize = 0;
            btnAlteraAtleta.FlatStyle = FlatStyle.Flat;
            btnAlteraAtleta.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlteraAtleta.ForeColor = Color.Gainsboro;
            btnAlteraAtleta.Image = Properties.Resources.alterar__1_;
            btnAlteraAtleta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlteraAtleta.Location = new Point(0, 347);
            btnAlteraAtleta.Name = "btnAlteraAtleta";
            btnAlteraAtleta.Padding = new Padding(12, 0, 0, 0);
            btnAlteraAtleta.Size = new Size(220, 80);
            btnAlteraAtleta.TabIndex = 5;
            btnAlteraAtleta.Text = "Alterar Dados do Atleta";
            btnAlteraAtleta.TextAlign = ContentAlignment.MiddleLeft;
            btnAlteraAtleta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlteraAtleta.UseVisualStyleBackColor = true;
            btnAlteraAtleta.Click += btnAlteraAtleta_Click;
            // 
            // btnBusca
            // 
            btnBusca.Dock = DockStyle.Top;
            btnBusca.FlatAppearance.BorderSize = 0;
            btnBusca.FlatStyle = FlatStyle.Flat;
            btnBusca.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusca.ForeColor = Color.Gainsboro;
            btnBusca.Image = Properties.Resources.pesquisa_de_lupa__1_;
            btnBusca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusca.Location = new Point(0, 267);
            btnBusca.Name = "btnBusca";
            btnBusca.Padding = new Padding(12, 0, 0, 0);
            btnBusca.Size = new Size(220, 80);
            btnBusca.TabIndex = 3;
            btnBusca.Text = "Buscar";
            btnBusca.TextAlign = ContentAlignment.MiddleLeft;
            btnBusca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click_1;
            // 
            // btnCadClube
            // 
            btnCadClube.Dock = DockStyle.Top;
            btnCadClube.FlatAppearance.BorderSize = 0;
            btnCadClube.FlatStyle = FlatStyle.Flat;
            btnCadClube.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadClube.ForeColor = Color.Gainsboro;
            btnCadClube.Image = Properties.Resources.fa_clube__1_;
            btnCadClube.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadClube.Location = new Point(0, 187);
            btnCadClube.Name = "btnCadClube";
            btnCadClube.Padding = new Padding(12, 0, 0, 0);
            btnCadClube.Size = new Size(220, 80);
            btnCadClube.TabIndex = 2;
            btnCadClube.Text = "Cadastrar Clube";
            btnCadClube.TextAlign = ContentAlignment.MiddleLeft;
            btnCadClube.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadClube.UseVisualStyleBackColor = true;
            btnCadClube.Click += btnCadClube_Click_1;
            // 
            // btnCadAtleta
            // 
            btnCadAtleta.Dock = DockStyle.Top;
            btnCadAtleta.FlatAppearance.BorderSize = 0;
            btnCadAtleta.FlatStyle = FlatStyle.Flat;
            btnCadAtleta.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadAtleta.ForeColor = Color.Gainsboro;
            btnCadAtleta.Image = Properties.Resources.silhueta_de_natacao__1_2;
            btnCadAtleta.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadAtleta.Location = new Point(0, 107);
            btnCadAtleta.Name = "btnCadAtleta";
            btnCadAtleta.Padding = new Padding(12, 0, 0, 0);
            btnCadAtleta.Size = new Size(220, 80);
            btnCadAtleta.TabIndex = 1;
            btnCadAtleta.Text = "Cadastrar Atleta";
            btnCadAtleta.TextAlign = ContentAlignment.MiddleLeft;
            btnCadAtleta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadAtleta.UseVisualStyleBackColor = true;
            btnCadAtleta.Click += btnCadAtleta_Click_1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 107);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(4, 30, 65);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Nova_Logo_CBDA_2021__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(7, 47, 100);
            pnlForm.Controls.Add(pictureBox4);
            pnlForm.Controls.Add(label4);
            pnlForm.Controls.Add(pictureBox3);
            pnlForm.Controls.Add(pictureBox2);
            pnlForm.Controls.Add(button1);
            pnlForm.Controls.Add(label3);
            pnlForm.Controls.Add(label2);
            pnlForm.Controls.Add(label1);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(220, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(735, 581);
            pnlForm.TabIndex = 2;
            pnlForm.Paint += pnlForm_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.fechar_o_simbolo_da_cruz_em_um_circulo__2___1_1;
            button1.Location = new Point(677, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 325);
            label3.Name = "label3";
            label3.Size = new Size(551, 102);
            label3.TabIndex = 2;
            label3.Text = "Confederação Brasileira \r\nde Desportos Aquaticos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(308, 245);
            label2.Name = "label2";
            label2.Size = new Size(77, 51);
            label2.TabIndex = 1;
            label2.Text = "na\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 158);
            label1.Name = "label1";
            label1.Size = new Size(643, 51);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Atletas e Clubes";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Carinhas_nadando;
            pictureBox2.Location = new Point(0, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(735, 471);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(7, 47, 100);
            pictureBox3.Image = Properties.Resources.Speedo_Logo__1_;
            pictureBox3.Location = new Point(159, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(207, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 40);
            label4.Name = "label4";
            label4.Size = new Size(147, 27);
            label4.TabIndex = 31;
            label4.Text = "Patrocinios: ";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.yakult_4096__1_;
            pictureBox4.Location = new Point(372, -7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(207, 114);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(955, 581);
            Controls.Add(pnlForm);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastro";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmCadastro_Load;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLogo;
        private Button btnCadAtleta;
        private PictureBox pictureBox1;
        private Button btnCadClube;
        private Button btnBusca;
        private Label label1;
        private Label label3;
        private Label label2;
        public Panel pnlForm;
        public Panel pnlMenu;
        public Button btnAlteraAtleta;
        private Panel marcador;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox4;
    }
}