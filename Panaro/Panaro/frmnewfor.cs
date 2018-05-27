using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaro
{
    public partial class frmnewfor : Form
    {
        public frmnewfor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxnome.Focus();
            //rdbtnbebidas.Select();
            txtboxnome.Text = (" ");
            txtboxmarca.Text = (" ");
            txtboxendereco.Text = (" ");
            txtboxnumero.Text = (" ");
            txtboxcelular.Text = (" ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar o fornecedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Camadas.Model.Fornecedor fornecedor = new Camadas.Model.Fornecedor();
                Camadas.DAL.Fornecedor dalFor = new Camadas.DAL.Fornecedor();
                txtboxnome.Focus();
                fornecedor.nome = txtboxnome.Text;
                fornecedor.marca = txtboxmarca.Text;
                fornecedor.endereco = txtboxendereco.Text;
                fornecedor.numero = txtboxnumero.Text;
                fornecedor.produto = cbboxtipos.Text;
                fornecedor.celular = txtboxcelular.Text;

                dalFor.Insert(fornecedor);
                MessageBox.Show("Fornecedor cadastrado com sucesso", "Cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxnome.Focus();
                txtboxnome.Text = (" ");
                txtboxmarca.Text = (" ");
                txtboxendereco.Text = (" ");
                txtboxnumero.Text = (" ");
                txtboxcelular.Text = (" ");
            }

        }

        private void frmnewfor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet6.tipo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoTableAdapter.Fill(this.panaroDataSet6.tipo);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet2.tipos'. Você pode movê-la ou removê-la conforme necessário.
            //this.tiposTableAdapter2.Fill(this.panaroDataSet2.tipos);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet1.tipos'. Você pode movê-la ou removê-la conforme necessário.
            //this.tiposTableAdapter1.Fill(this.panaroDataSet1.tipos);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet.tipos'. Você pode movê-la ou removê-la conforme necessário.
            //this.tiposTableAdapter.Fill(this.panaroDataSet.tipos);
            txtboxnome.Focus();
            //rdbtnbebidas.Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmnewtip frmtip = new frmnewtip();
            frmtip.Show();
        }

        private void cbboxtipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
