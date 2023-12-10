namespace cadastroAtletas
{
    partial class FrmAlteraAtleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTituloAltAt = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtAlteraFederadoAt = new TextBox();
            btnConfirmaAltAt = new Button();
            cbClubeAlteraAt = new ComboBox();
            txtDataNascAlteraAt = new TextBox();
            txtCidadeAlteraAt = new TextBox();
            txtNomeAlteraAt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblIdAlterar = new Label();
            pnlTituloAltAt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTituloAltAt
            // 
            pnlTituloAltAt.BackColor = Color.FromArgb(7, 47, 100);
            pnlTituloAltAt.Controls.Add(button1);
            pnlTituloAltAt.Controls.Add(label1);
            pnlTituloAltAt.Dock = DockStyle.Top;
            pnlTituloAltAt.Location = new Point(0, 0);
            pnlTituloAltAt.Name = "pnlTituloAltAt";
            pnlTituloAltAt.Size = new Size(735, 107);
            pnlTituloAltAt.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.fechar_o_simbolo_da_cruz_em_um_circulo__2___1_1;
            button1.Location = new Point(677, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(156, 29);
            label1.Name = "label1";
            label1.Size = new Size(402, 40);
            label1.TabIndex = 0;
            label1.Text = "Alterar Dados do Atleta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.conjunto_de_setas_de_sincronizacao__2___1_;
            pictureBox1.Location = new Point(12, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtAlteraFederadoAt
            // 
            txtAlteraFederadoAt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlteraFederadoAt.Location = new Point(326, 402);
            txtAlteraFederadoAt.Name = "txtAlteraFederadoAt";
            txtAlteraFederadoAt.Size = new Size(347, 28);
            txtAlteraFederadoAt.TabIndex = 26;
            // 
            // btnConfirmaAltAt
            // 
            btnConfirmaAltAt.BackColor = Color.FromArgb(7, 47, 100);
            btnConfirmaAltAt.FlatAppearance.BorderSize = 0;
            btnConfirmaAltAt.FlatStyle = FlatStyle.Flat;
            btnConfirmaAltAt.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmaAltAt.ForeColor = Color.White;
            btnConfirmaAltAt.Location = new Point(261, 462);
            btnConfirmaAltAt.Name = "btnConfirmaAltAt";
            btnConfirmaAltAt.Size = new Size(219, 60);
            btnConfirmaAltAt.TabIndex = 25;
            btnConfirmaAltAt.Text = "Alterar";
            btnConfirmaAltAt.UseVisualStyleBackColor = false;
            btnConfirmaAltAt.Click += btnConfirmaAltAt_Click;
            // 
            // cbClubeAlteraAt
            // 
            cbClubeAlteraAt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbClubeAlteraAt.FormattingEnabled = true;
            cbClubeAlteraAt.Location = new Point(326, 251);
            cbClubeAlteraAt.Name = "cbClubeAlteraAt";
            cbClubeAlteraAt.Size = new Size(347, 29);
            cbClubeAlteraAt.TabIndex = 24;
            // 
            // txtDataNascAlteraAt
            // 
            txtDataNascAlteraAt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataNascAlteraAt.Location = new Point(326, 302);
            txtDataNascAlteraAt.Name = "txtDataNascAlteraAt";
            txtDataNascAlteraAt.Size = new Size(347, 28);
            txtDataNascAlteraAt.TabIndex = 23;
            // 
            // txtCidadeAlteraAt
            // 
            txtCidadeAlteraAt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidadeAlteraAt.Location = new Point(326, 352);
            txtCidadeAlteraAt.Name = "txtCidadeAlteraAt";
            txtCidadeAlteraAt.Size = new Size(347, 28);
            txtCidadeAlteraAt.TabIndex = 22;
            // 
            // txtNomeAlteraAt
            // 
            txtNomeAlteraAt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeAlteraAt.Location = new Point(326, 202);
            txtNomeAlteraAt.Name = "txtNomeAlteraAt";
            txtNomeAlteraAt.Size = new Size(347, 28);
            txtNomeAlteraAt.TabIndex = 21;
            txtNomeAlteraAt.TextChanged += txtNomeAlteraAt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(46, 302);
            label6.Name = "label6";
            label6.Size = new Size(249, 27);
            label6.TabIndex = 20;
            label6.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 402);
            label5.Name = "label5";
            label5.Size = new Size(126, 27);
            label5.TabIndex = 19;
            label5.Text = "Federado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 352);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 18;
            label4.Text = "Cidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 252);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 17;
            label3.Text = "Clube:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 202);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 16;
            label2.Text = "Nome:";
            // 
            // lblIdAlterar
            // 
            lblIdAlterar.AutoSize = true;
            lblIdAlterar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdAlterar.ForeColor = Color.White;
            lblIdAlterar.Location = new Point(326, 141);
            lblIdAlterar.Name = "lblIdAlterar";
            lblIdAlterar.Size = new Size(34, 27);
            lblIdAlterar.TabIndex = 27;
            lblIdAlterar.Text = "ID";
            lblIdAlterar.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmAlteraAtleta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(735, 581);
            Controls.Add(lblIdAlterar);
            Controls.Add(txtAlteraFederadoAt);
            Controls.Add(btnConfirmaAltAt);
            Controls.Add(cbClubeAlteraAt);
            Controls.Add(txtDataNascAlteraAt);
            Controls.Add(txtCidadeAlteraAt);
            Controls.Add(txtNomeAlteraAt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pnlTituloAltAt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAlteraAtleta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlteraAtleta";
            Load += FrmAlteraAtleta_Load;
            pnlTituloAltAt.ResumeLayout(false);
            pnlTituloAltAt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTituloAltAt;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnConfirmaAltAt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        public TextBox txtNomeAlteraAt;
        public ComboBox cbClubeAlteraAt;
        public TextBox txtAlteraFederadoAt;
        public TextBox txtDataNascAlteraAt;
        public TextBox txtCidadeAlteraAt;
        public Label lblIdAlterar;
    }
}