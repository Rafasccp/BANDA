using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANDA
{
    public partial class frmBandas : Form
    {
        public frmBandas()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmInicial f = new frmInicial();
            f.Show();
            this.Hide();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
