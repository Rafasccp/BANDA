using BANDA.Classes;
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
    public partial class frmMusicos : Form
    {
        Singleton s;
        public frmMusicos()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        public void Recarregar()
        {
            var source = new BindingSource();
            source.DataSource = s.musicos;
            dgvMusicos.DataSource = source;
        }

        private void frmMusicos_Load(object sender, EventArgs e)
        {
            Recarregar();
            LimparCampos();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmInicial f = new frmInicial();
            f.Show();
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (mtbCpf.Text.Length > 0 && txtNome.Text.Trim().Length > 0 && numIdade.Value > 0 && cbxTipo.SelectedIndex != -1)
            {
                if (cbxTipo.Enabled) // cadastro
                {
                    switch (cbxTipo.SelectedIndex)
                    {
                        case 0: // Baixista
                            s.musicos.Add(new Baixista(mtbCpf.Text, txtNome.Text, (int)numIdade.Value));
                            break;
                        case 1: // Baterista
                            s.musicos.Add(new Baterista(mtbCpf.Text, txtNome.Text, (int)numIdade.Value));
                            break;
                        case 2: // Guitarrista
                            s.musicos.Add(new Guitarrista(mtbCpf.Text, txtNome.Text, (int)numIdade.Value));
                            break;
                        case 3: // Vocalista
                            s.musicos.Add(new Vocalista(mtbCpf.Text, txtNome.Text, (int)numIdade.Value));
                            break;
                    }
                }
                else // edição
                {
                    Musico? musico = s.BuscarMusico(mtbCpf.Text);
                    if (musico != null)
                    {
                        musico.Nome = txtNome.Text;
                        musico.Idade = (int)numIdade.Value;
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

            LimparCampos();
            Recarregar();
        }

        private void frmMusicos_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void dgvMusicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvMusicos.SelectedCells[0].RowIndex;
            string cpf = dgvMusicos.Rows[linha].Cells[0].Value.ToString();
            Musico? musico = s.BuscarMusico(cpf);
            if (musico != null)
            {
                mtbCpf.Text = musico.Cpf;
                mtbCpf.Enabled = false;
                txtNome.Text = musico.Nome;
                numIdade.Value = musico.Idade;
                if (musico is Baixista)
                {
                    cbxTipo.SelectedIndex = 0;
                }
                else if (musico is Baterista)
                {
                    cbxTipo.SelectedIndex = 1;
                }
                else if (musico is Guitarrista)
                {
                    cbxTipo.SelectedIndex = 2;
                }
                else if (musico is Vocalista)
                {
                    cbxTipo.SelectedIndex = 3;
                }
                cbxTipo.Enabled = false;
                btExcluir.Enabled = true;
            }
        }

        public void LimparCampos()
        {
            btExcluir.Enabled = false;
            mtbCpf.Text = "";
            mtbCpf.Enabled = true;
            txtNome.Text = "";
            numIdade.Value = 0;
            cbxTipo.SelectedIndex = -1;
            cbxTipo.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja excluir esse músico?", "Confirmação", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Musico? m = s.BuscarMusico(mtbCpf.Text);
                if (m != null)
                {
                    s.musicos.Remove(m);
                }
            }
            LimparCampos();
            Recarregar();
        }
    }
}
