namespace cadastroAtletas
{
    partial class FrmCadAtleta
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
            pnlCadAt = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNomeCadAt = new TextBox();
            txtCidadeCadAt = new TextBox();
            txtDataNascCadAt = new TextBox();
            cbClubeCadAt = new ComboBox();
            btnConfirmaCadAt = new Button();
            pictureBox1 = new PictureBox();
            txtFederado = new TextBox();
            pnlCadAt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlCadAt
            // 
            pnlCadAt.BackColor = Color.FromArgb(7, 47, 100);
            pnlCadAt.Controls.Add(button1);
            pnlCadAt.Controls.Add(label1);
            pnlCadAt.Dock = DockStyle.Top;
            pnlCadAt.Location = new Point(0, 0);
            pnlCadAt.Name = "pnlCadAt";
            pnlCadAt.Size = new Size(735, 107);
            pnlCadAt.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.fechar_o_simbolo_da_cruz_em_um_circulo__2___1_1;
            button1.Location = new Point(677, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(224, 33);
            label1.Name = "label1";
            label1.Size = new Size(286, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Atleta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 190);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 240);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 2;
            label3.Text = "Clube:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 340);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 3;
            label4.Text = "Cidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 390);
            label5.Name = "label5";
            label5.Size = new Size(126, 27);
            label5.TabIndex = 4;
            label5.Text = "Federado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 290);
            label6.Name = "label6";
            label6.Size = new Size(249, 27);
            label6.TabIndex = 5;
            label6.Text = "Data de Nascimento:";
            // 
            // txtNomeCadAt
            // 
            txtNomeCadAt.Location = new Point(309, 190);
            txtNomeCadAt.Name = "txtNomeCadAt";
            txtNomeCadAt.Size = new Size(347, 27);
            txtNomeCadAt.TabIndex = 6;
            // 
            // txtCidadeCadAt
            // 
            txtCidadeCadAt.Location = new Point(309, 340);
            txtCidadeCadAt.Name = "txtCidadeCadAt";
            txtCidadeCadAt.Size = new Size(347, 27);
            txtCidadeCadAt.TabIndex = 7;
            // 
            // txtDataNascCadAt
            // 
            txtDataNascCadAt.Location = new Point(309, 290);
            txtDataNascCadAt.Name = "txtDataNascCadAt";
            txtDataNascCadAt.Size = new Size(347, 27);
            txtDataNascCadAt.TabIndex = 8;
            // 
            // cbClubeCadAt
            // 
            cbClubeCadAt.FormattingEnabled = true;
            cbClubeCadAt.Location = new Point(309, 239);
            cbClubeCadAt.Name = "cbClubeCadAt";
            cbClubeCadAt.Size = new Size(347, 28);
            cbClubeCadAt.TabIndex = 12;
            cbClubeCadAt.SelectedIndexChanged += cbClubeCadAt_SelectedIndexChanged;
            // 
            // btnConfirmaCadAt
            // 
            btnConfirmaCadAt.BackColor = Color.FromArgb(7, 47, 100);
            btnConfirmaCadAt.FlatAppearance.BorderSize = 0;
            btnConfirmaCadAt.FlatStyle = FlatStyle.Flat;
            btnConfirmaCadAt.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmaCadAt.ForeColor = Color.White;
            btnConfirmaCadAt.Location = new Point(244, 450);
            btnConfirmaCadAt.Name = "btnConfirmaCadAt";
            btnConfirmaCadAt.Size = new Size(219, 60);
            btnConfirmaCadAt.TabIndex = 13;
            btnConfirmaCadAt.Text = "Cadastrar";
            btnConfirmaCadAt.UseVisualStyleBackColor = false;
            btnConfirmaCadAt.Click += btnConfirmaCadAt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.silhueta_de_natacao__2___1_;
            pictureBox1.Location = new Point(12, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // txtFederado
            // 
            txtFederado.Location = new Point(309, 390);
            txtFederado.Name = "txtFederado";
            txtFederado.Size = new Size(347, 27);
            txtFederado.TabIndex = 15;
            // 
            // FrmCadAtleta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(735, 581);
            Controls.Add(txtFederado);
            Controls.Add(pictureBox1);
            Controls.Add(btnConfirmaCadAt);
            Controls.Add(cbClubeCadAt);
            Controls.Add(txtDataNascCadAt);
            Controls.Add(txtCidadeCadAt);
            Controls.Add(txtNomeCadAt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlCadAt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadAtleta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadAtleta";
            Load += FrmCadAtleta_Load;
            pnlCadAt.ResumeLayout(false);
            pnlCadAt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCadAt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNomeCadAt;
        private TextBox txtCidadeCadAt;
        private TextBox txtDataNascCadAt;
        private Button btnConfirmaCadAt;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtFederado;
        public ComboBox cbClubeCadAt;
    }
}