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
    public partial class frmatest : Form
    {
        public frmatest()
        {
            InitializeComponent();
        }

        private void frmatest_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();
            dgvprod.DataSource = "";
            dgvprod.DataSource = dalPro.Select();
            rdbtodos_CheckedChanged(null, null);
        }

        private void dgvprod_DoubleClick(object sender, EventArgs e)
        {
            if (dgvprod.SelectedRows.Count > 0)
            {
                txtboxid.Text = dgvprod.SelectedRows[0].Cells["id"].Value.ToString();
                txtboxprod.Text = dgvprod.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtboxqtd.Text = dgvprod.SelectedRows[0].Cells["quantidade"].Value.ToString();
                txtboxqtda.Text = dgvprod.SelectedRows[0].Cells["quantidade"].Value.ToString();
                txtboxvalor.Text = dgvprod.SelectedRows[0].Cells["valor"].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar a quantidade e/ou valor do produto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Camadas.Model.Produtos produto = new Camadas.Model.Produtos();
                Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();

                produto.id = Convert.ToInt32(txtboxid.Text);
                produto.quantidade = txtboxqtda.Text;
                produto.valor = txtboxvalor.Text;

                dalPro.Update(produto);


                MessageBox.Show("Quantidade e/ou valor alterada com sucesso", "Ediçao de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxqtd.Focus();
                txtboxid.Text = ("");
                txtboxprod.Text = ("");
                txtboxqtd.Text = ("");
                txtboxqtda.Text = ("");
                txtboxvalor.Text = ("");
                dgvprod.DataSource = "";
                dgvprod.DataSource = dalPro.Select();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover o Produto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Camadas.Model.Produtos produto = new Camadas.Model.Produtos();
                Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();

                produto.id = Convert.ToInt32(txtboxid.Text);

                dalPro.Delete(produto);

                MessageBox.Show("Produto removido com sucesso", "Ediçao de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxqtd.Focus();
                txtboxid.Text = ("");
                txtboxprod.Text = ("");
                txtboxqtd.Text = ("");
                txtboxqtda.Text = ("");
                dgvprod.DataSource = "";
                dgvprod.DataSource = dalPro.Select();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produtos bllPro = new Camadas.BLL.Produtos();
            List<Camadas.Model.Produtos> lstProduto = new List<Camadas.Model.Produtos>();

            if (rdbcod.Checked)
                lstProduto = bllPro.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbnome.Checked)
                lstProduto = bllPro.SelectByNome(txtPesquisa.Text);

            dgvprod.DataSource = "";
            dgvprod.DataSource = lstProduto;
            txtPesquisa.Text = "";
        }

        private void rdbtodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnbuscar.Visible = false;
            Camadas.BLL.Produtos bllProduto = new Camadas.BLL.Produtos();
            dgvprod.DataSource = "";
            dgvprod.DataSource = bllProduto.Select();
        }

        private void rdbcod_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o Codigo";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnbuscar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbnome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o Nome";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnbuscar.Visible = true;
            txtPesquisa.Focus();
        }
    }
}
