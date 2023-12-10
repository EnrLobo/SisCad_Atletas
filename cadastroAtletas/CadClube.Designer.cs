namespace cadastroAtletas
{
    partial class FrmCadClube
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
            pnlCadCb = new Panel();
            button1 = new Button();
            label1 = new Label();
            btnConfirmaCadCb = new Button();
            txtEstadoCadCb = new TextBox();
            txtFiliadoCadCb = new TextBox();
            txtNomeCadCb = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtCidadeCadCb = new TextBox();
            pnlCadCb.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadCb
            // 
            pnlCadCb.BackColor = Color.FromArgb(7, 47, 100);
            pnlCadCb.Controls.Add(button1);
            pnlCadCb.Controls.Add(label1);
            pnlCadCb.Dock = DockStyle.Top;
            pnlCadCb.Location = new Point(0, 0);
            pnlCadCb.Name = "pnlCadCb";
            pnlCadCb.Size = new Size(735, 107);
            pnlCadCb.TabIndex = 1;
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
            label1.Location = new Point(224, 33);
            label1.Name = "label1";
            label1.Size = new Size(288, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Clube";
            // 
            // btnConfirmaCadCb
            // 
            btnConfirmaCadCb.BackColor = Color.FromArgb(7, 47, 100);
            btnConfirmaCadCb.FlatAppearance.BorderSize = 0;
            btnConfirmaCadCb.FlatStyle = FlatStyle.Flat;
            btnConfirmaCadCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmaCadCb.ForeColor = Color.White;
            btnConfirmaCadCb.Location = new Point(255, 456);
            btnConfirmaCadCb.Name = "btnConfirmaCadCb";
            btnConfirmaCadCb.Size = new Size(219, 60);
            btnConfirmaCadCb.TabIndex = 25;
            btnConfirmaCadCb.Text = "Cadastrar";
            btnConfirmaCadCb.UseVisualStyleBackColor = false;
            btnConfirmaCadCb.Click += btnConfirmaCadCb_Click;
            // 
            // txtEstadoCadCb
            // 
            txtEstadoCadCb.Location = new Point(305, 296);
            txtEstadoCadCb.Name = "txtEstadoCadCb";
            txtEstadoCadCb.Size = new Size(347, 27);
            txtEstadoCadCb.TabIndex = 23;
            // 
            // txtFiliadoCadCb
            // 
            txtFiliadoCadCb.Location = new Point(305, 346);
            txtFiliadoCadCb.Name = "txtFiliadoCadCb";
            txtFiliadoCadCb.Size = new Size(347, 27);
            txtFiliadoCadCb.TabIndex = 22;
            // 
            // txtNomeCadCb
            // 
            txtNomeCadCb.Location = new Point(305, 196);
            txtNomeCadCb.Name = "txtNomeCadCb";
            txtNomeCadCb.Size = new Size(347, 27);
            txtNomeCadCb.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 296);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 20;
            label6.Text = "Estado: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 246);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 17;
            label3.Text = "Cidade: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 196);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 16;
            label2.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 346);
            label4.Name = "label4";
            label4.Size = new Size(248, 27);
            label4.TabIndex = 18;
            label4.Text = "Filiado a Federação: ";
            // 
            // txtCidadeCadCb
            // 
            txtCidadeCadCb.Location = new Point(305, 246);
            txtCidadeCadCb.Name = "txtCidadeCadCb";
            txtCidadeCadCb.Size = new Size(347, 27);
            txtCidadeCadCb.TabIndex = 26;
            // 
            // FrmCadClube
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(735, 581);
            Controls.Add(txtCidadeCadCb);
            Controls.Add(btnConfirmaCadCb);
            Controls.Add(txtEstadoCadCb);
            Controls.Add(txtFiliadoCadCb);
            Controls.Add(txtNomeCadCb);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlCadCb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadClube";
            Text = "CadClube";
            pnlCadCb.ResumeLayout(false);
            pnlCadCb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCadCb;
        private Label label1;
        private Button btnConfirmaCadCb;
        private TextBox txtEstadoCadCb;
        private TextBox txtFiliadoCadCb;
        private TextBox txtNomeCadCb;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtCidadeCadCb;
        private Button button1;
    }
}