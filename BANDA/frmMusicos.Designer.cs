namespace BANDA { 
    partial class frmMusicos
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
            components = new System.ComponentModel.Container();
            dgvMusicos = new DataGridView();
            cpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musicoBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            mtbCpf = new MaskedTextBox();
            numIdade = new NumericUpDown();
            cbxTipo = new ComboBox();
            btExcluir = new Button();
            btSalvar = new Button();
            btVoltar = new Button();
            btCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMusicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdade).BeginInit();
            SuspendLayout();
            // 
            // dgvMusicos
            // 
            dgvMusicos.AllowUserToAddRows = false;
            dgvMusicos.AllowUserToDeleteRows = false;
            dgvMusicos.AutoGenerateColumns = false;
            dgvMusicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusicos.Columns.AddRange(new DataGridViewColumn[] { cpfDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, idadeDataGridViewTextBoxColumn });
            dgvMusicos.DataSource = musicoBindingSource;
            dgvMusicos.Location = new Point(36, 37);
            dgvMusicos.Name = "dgvMusicos";
            dgvMusicos.Size = new Size(426, 368);
            dgvMusicos.TabIndex = 0;
            dgvMusicos.CellClick += dgvMusicos_CellClick;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            // 
            // musicoBindingSource
            // 
            musicoBindingSource.DataSource = typeof(Classes.Musico);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 81);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 122);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 164);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 211);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Tipo:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(571, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(167, 23);
            txtNome.TabIndex = 2;
            // 
            // mtbCpf
            // 
            mtbCpf.Culture = new System.Globalization.CultureInfo("en-US");
            mtbCpf.Location = new Point(571, 73);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(167, 23);
            mtbCpf.TabIndex = 1;
            // 
            // numIdade
            // 
            numIdade.Location = new Point(571, 162);
            numIdade.Name = "numIdade";
            numIdade.Size = new Size(167, 23);
            numIdade.TabIndex = 3;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Baixista", "Baterista", "Guitarrista", "Vocalista" });
            cbxTipo.Location = new Point(571, 208);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(167, 23);
            cbxTipo.TabIndex = 4;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(510, 291);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(104, 23);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "Excluir Músico";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(634, 291);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(104, 23);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Salvar Músico";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(36, 415);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(75, 23);
            btVoltar.TabIndex = 11;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(126, 415);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 12;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // frmMusicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btVoltar);
            Controls.Add(btSalvar);
            Controls.Add(btExcluir);
            Controls.Add(cbxTipo);
            Controls.Add(numIdade);
            Controls.Add(mtbCpf);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMusicos);
            MaximizeBox = false;
            Name = "frmMusicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bandas - Gerenciar Músicos";
            FormClosed += frmMusicos_FormClosed;
            Load += frmMusicos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMusicos;
        private BindingSource musicoBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private MaskedTextBox mtbCpf;
        private NumericUpDown numIdade;
        private ComboBox cbxTipo;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private Button btExcluir;
        private Button btSalvar;
        private Button btVoltar;
        private Button btCancelar;
    }
}