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
    public partial class frmedcli : Form
    {
        public frmedcli()
        {
            InitializeComponent();
        }

        private void frmedcli_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dgvedcli.DataSource = "";
            dgvedcli.DataSource = dalCli.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
                Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();

                cliente.id = Convert.ToInt32(txtboxId.Text);
                cliente.nome = txtboxnome.Text;
                cliente.endereco = txtboxend.Text;
                cliente.numero = txtboxnum.Text;
                cliente.bairro = txtboxbairro.Text;
                cliente.telefone = txtboxtel.Text;
                cliente.celular = txtboxcel.Text;

                dalCli.Update(cliente);

                
                MessageBox.Show("Cliente alterado com sucesso", "Ediçao de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxnome.Focus();
                txtboxId.Text = ("");
                txtboxnome.Text = ("");
                txtboxend.Text = ("");
                txtboxnum.Text = ("");
                txtboxbairro.Text = ("");
                txtboxtel.Text = ("");
                txtboxcel.Text = ("");
                dgvedcli.DataSource = "";
                dgvedcli.DataSource = dalCli.Select();
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover o cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
                Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();

                cliente.id = Convert.ToInt32(txtboxId.Text);

                dalCli.Delete(cliente);

                MessageBox.Show("Cliente removido com sucesso", "Ediçao de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxnome.Focus();
                txtboxId.Text = ("");
                txtboxnome.Text = ("");
                txtboxend.Text = ("");
                txtboxnum.Text = ("");
                txtboxbairro.Text = ("");
                txtboxtel.Text = ("");
                txtboxcel.Text = ("");
                dgvedcli.DataSource = "";
                dgvedcli.DataSource = dalCli.Select();
            }
        }

        private void dgvedcli_DoubleClick(object sender, EventArgs e)
        {
            if (dgvedcli.SelectedRows.Count > 0)
            {
                txtboxId.Text = dgvedcli.SelectedRows[0].Cells["id"].Value.ToString();
                txtboxnome.Text = dgvedcli.SelectedRows[0].Cells["nome"].Value.ToString();
                txtboxend.Text = dgvedcli.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtboxnum.Text = dgvedcli.SelectedRows[0].Cells["numero"].Value.ToString();
                txtboxbairro.Text = dgvedcli.SelectedRows[0].Cells["bairro"].Value.ToString();
                txtboxtel.Text = dgvedcli.SelectedRows[0].Cells["telefone"].Value.ToString();
                txtboxcel.Text = dgvedcli.SelectedRows[0].Cells["celular"].Value.ToString();

            }
        }
    }
}
