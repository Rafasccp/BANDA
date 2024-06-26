namespace BANDA
{
    partial class frmMembros
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
            btExcluir = new Button();
            dataGridView1 = new DataGridView();
            pessoaBindingSource = new BindingSource(components);
            cpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(21, 390);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(129, 23);
            btExcluir.TabIndex = 1;
            btExcluir.Text = "Excluir Membro";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cpfDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, idadeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pessoaBindingSource;
            dataGridView1.Location = new Point(21, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(702, 372);
            dataGridView1.TabIndex = 2;
            // 
            // pessoaBindingSource
            // 
            pessoaBindingSource.DataSource = typeof(Classes.Pessoa);
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
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
            // btNovo
            // 
            btNovo.Location = new Point(572, 390);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(151, 23);
            btNovo.TabIndex = 3;
            btNovo.Text = "Novo Membro";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // frmMembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 425);
            Controls.Add(btNovo);
            Controls.Add(dataGridView1);
            Controls.Add(btExcluir);
            Name = "frmMembros";
            Text = "frmMembros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pessoaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btExcluir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private BindingSource pessoaBindingSource;
        private Button btNovo;
    }
}