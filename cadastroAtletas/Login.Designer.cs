namespace cadastroAtletas
{
    partial class FrmLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            txtUserLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnLogin = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._480px_Circulo_azul;
            pictureBox1.Location = new Point(-281, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(704, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(39, 53, 126);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(130, 146);
            label1.Name = "label1";
            label1.Size = new Size(135, 51);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(39, 53, 126);
            pictureBox2.Image = Properties.Resources.Nova_Logo_CBDA_2021__1_;
            pictureBox2.Location = new Point(73, 256);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(39, 53, 126);
            pictureBox3.Image = Properties.Resources.icons8_connect_50__1_;
            pictureBox3.Location = new Point(73, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(484, 174);
            label2.Name = "label2";
            label2.Size = new Size(210, 23);
            label2.TabIndex = 5;
            label2.Text = "Faça seu Login aqui!";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.imagem_do_usuario_com_fundo_preto__2___1_;
            pictureBox4.Location = new Point(505, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(160, 145);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // txtUserLogin
            // 
            txtUserLogin.BorderStyle = BorderStyle.FixedSingle;
            txtUserLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserLogin.Location = new Point(484, 269);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(210, 28);
            txtUserLogin.TabIndex = 7;
            txtUserLogin.TextChanged += txtUserLogin_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BorderStyle = BorderStyle.FixedSingle;
            txtSenhaLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaLogin.Location = new Point(484, 332);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PasswordChar = '*';
            txtSenhaLogin.Size = new Size(210, 28);
            txtSenhaLogin.TabIndex = 8;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Image = Properties.Resources.trancar__1___1_;
            pictureBox5.Location = new Point(445, 333);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonHighlight;
            pictureBox6.Image = Properties.Resources.sombra_de_usuario_masculino__1_;
            pictureBox6.Location = new Point(445, 269);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(39, 53, 126);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(505, 385);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 50);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.fechar_o_simbolo_da_cruz_em_um_circulo__2___1_1;
            btnFechar.Location = new Point(695, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 40);
            btnFechar.TabIndex = 12;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(753, 511);
            Controls.Add(btnFechar);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUserLogin);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox4;
        private TextBox txtUserLogin;
        private TextBox txtSenhaLogin;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnLogin;
        private Button btnFechar;
    }
}