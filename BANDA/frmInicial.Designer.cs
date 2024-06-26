namespace BANDA
{
    partial class frmInicial
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
            btBandas = new Button();
            btMusicos = new Button();
            SuspendLayout();
            // 
            // btBandas
            // 
            btBandas.Location = new Point(89, 33);
            btBandas.Name = "btBandas";
            btBandas.Size = new Size(176, 23);
            btBandas.TabIndex = 0;
            btBandas.Text = "Gerenciar bandas";
            btBandas.UseVisualStyleBackColor = true;
            btBandas.Click += btBandas_Click;
            // 
            // btMusicos
            // 
            btMusicos.Location = new Point(89, 80);
            btMusicos.Name = "btMusicos";
            btMusicos.Size = new Size(176, 23);
            btMusicos.TabIndex = 1;
            btMusicos.Text = "Gerenciar músicos";
            btMusicos.UseVisualStyleBackColor = true;
            btMusicos.Click += btMusicos_Click;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 143);
            Controls.Add(btMusicos);
            Controls.Add(btBandas);
            MaximizeBox = false;
            Name = "frmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bandas - Tela Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btBandas;
        private Button btMusicos;
    }
}
