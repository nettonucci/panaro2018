using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panaro.Camadas;

namespace Panaro
{
    public partial class frmnewcom : Form
    {
        public frmnewcom()
        {
            InitializeComponent();
        }

        private void frmcomanda_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalCli.Select();
            rdbtodos_CheckedChanged(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmnewcli frmcli = new frmnewcli();
            frmcli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbtodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnbuscar.Visible = false;
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCliente.Select();
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
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            List<Camadas.Model.Cliente> lstCliente = new List<Camadas.Model.Cliente>();

            if (rdbcod.Checked)
                lstCliente = bllCli.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbnome.Checked)
                lstCliente = bllCli.SelectByNome(txtPesquisa.Text);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = lstCliente;

        }
    }
}
