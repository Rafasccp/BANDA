namespace BANDA
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btMusicos_Click(object sender, EventArgs e)
        {
            frmMusicos f = new frmMusicos();
            f.Show();
            this.Hide();
        }

        private void btBandas_Click(object sender, EventArgs e)
        {
            frmBandas f = new frmBandas();
            f.Show();
            this.Hide();
        }
    }
}
