namespace cadastroAtletas
{
    partial class FrmBusca
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlBusca = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBusca = new TextBox();
            btnAlterar = new Button();
            dgAtletas = new DataGridView();
            btnRemover = new Button();
            pnlBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAtletas).BeginInit();
            SuspendLayout();
            // 
            // pnlBusca
            // 
            pnlBusca.BackColor = Color.FromArgb(7, 47, 100);
            pnlBusca.Controls.Add(button1);
            pnlBusca.Controls.Add(label1);
            pnlBusca.Dock = DockStyle.Top;
            pnlBusca.Location = new Point(0, 0);
            pnlBusca.Name = "pnlBusca";
            pnlBusca.Size = new Size(735, 107);
            pnlBusca.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.fechar_o_simbolo_da_cruz_em_um_circulo__2___1_1;
            button1.Location = new Point(677, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 32);
            label1.Name = "label1";
            label1.Size = new Size(127, 40);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 161);
            label2.Name = "label2";
            label2.Size = new Size(202, 27);
            label2.TabIndex = 3;
            label2.Text = "Nome do Atleta: ";
            label2.Click += label2_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(216, 161);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(331, 27);
            txtBusca.TabIndex = 4;
            txtBusca.TextChanged += textBox1_TextChanged;
            // 
            // btnAlterar
            // 
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Image = Properties.Resources.alterar__1_;
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(567, 150);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(152, 49);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // dgAtletas
            // 
            dgAtletas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAtletas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgAtletas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgAtletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgAtletas.DefaultCellStyle = dataGridViewCellStyle2;
            dgAtletas.Location = new Point(12, 207);
            dgAtletas.Margin = new Padding(3, 2, 3, 2);
            dgAtletas.Name = "dgAtletas";
            dgAtletas.RowHeadersWidth = 51;
            dgAtletas.RowTemplate.Height = 29;
            dgAtletas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAtletas.Size = new Size(711, 308);
            dgAtletas.TabIndex = 6;
            dgAtletas.CellContentClick += dgAtletas_CellContentClick;
            // 
            // btnRemover
            // 
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = Color.White;
            btnRemover.Image = Properties.Resources.remover__1_;
            btnRemover.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemover.Location = new Point(273, 520);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(152, 49);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // FrmBusca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(735, 581);
            Controls.Add(btnRemover);
            Controls.Add(dgAtletas);
            Controls.Add(btnAlterar);
            Controls.Add(txtBusca);
            Controls.Add(label2);
            Controls.Add(pnlBusca);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBusca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBusca";
            Load += FrmBusca_Load;
            pnlBusca.ResumeLayout(false);
            pnlBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAtletas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBusca;
        private Label label1;
        private Label label2;
        private TextBox txtBusca;
        private Button btnAlterar;
        private Button btnRemover;
        private Button button1;
        public DataGridView dgAtletas;
    }
}