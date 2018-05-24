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
    public partial class frmnewpro : Form
    {
        public frmnewpro()
        {
            InitializeComponent();
        }

        private void frmnewpro_Load(object sender, EventArgs e)
        {
            txtboxdesc.Focus();
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet7.tipo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoTableAdapter.Fill(this.panaroDataSet7.tipo);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet3.tipos'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposTableAdapter1.Fill(this.panaroDataSet3.tipos);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet.tipos'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposTableAdapter.Fill(this.panaroDataSet.tipos);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmnewtip frmtip = new frmnewtip();
            frmtip.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar o produto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txtboxdesc.Focus();
                Camadas.Model.Produtos produto = new Camadas.Model.Produtos();
                Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();
                produto.produto = cbbprod.Text;
                produto.descricao = txtboxdesc.Text;
                produto.valor = txtboxvalor.Text;
                produto.quantidade = txtboxqtd.Text;

                dalPro.Insert(produto);
                MessageBox.Show("Produto cadastrado com sucesso", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxdesc.Text = ("");
                txtboxvalor.Text = ("");
                txtboxqtd.Text = ("");

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxdesc.Focus();
            txtboxdesc.Text = ("");
            txtboxvalor.Text = ("");
            txtboxqtd.Text = ("");
        }
    }
}
