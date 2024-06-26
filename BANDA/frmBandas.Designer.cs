namespace BANDA
{
    partial class frmBandas
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
            btVoltar = new Button();
            btCancelar = new Button();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bandaBindingSource = new BindingSource(components);
            musicoBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bandaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(29, 385);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(112, 37);
            btVoltar.TabIndex = 0;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(176, 385);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(109, 37);
            btCancelar.TabIndex = 1;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, nomeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bandaBindingSource;
            dataGridView1.Location = new Point(29, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 330);
            dataGridView1.TabIndex = 6;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // bandaBindingSource
            // 
            bandaBindingSource.DataSource = typeof(Classes.Banda);
            // 
            // musicoBindingSource
            // 
            musicoBindingSource.DataSource = typeof(Classes.Musico);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 151);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(641, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(641, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // frmBandas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btCancelar);
            Controls.Add(btVoltar);
            Name = "frmBandas";
            Text = "frmBandas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bandaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVoltar;
        private Button btCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private BindingSource bandaBindingSource;
        private BindingSource musicoBindingSource;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}