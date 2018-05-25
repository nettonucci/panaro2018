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
    public partial class frmconpro : Form
    {
        public frmconpro()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmconpro_Load(object sender, EventArgs e)
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
                txtboxvalor.Text = dgvprod.SelectedRows[0].Cells["valor"].Value.ToString();
                txtboxqtd.Text = dgvprod.SelectedRows[0].Cells["quantidade"].Value.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtboxid.Text = ("");
            txtboxprod.Text = ("");
            txtboxqtd.Text = ("");
            txtboxvalor.Text = ("");
            dgvprod.DataSource = "";
            Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();
            dgvprod.DataSource = "";
            dgvprod.DataSource = dalPro.Select();
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
    }
}
