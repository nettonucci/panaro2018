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
    public partial class frmnewcli : Form
    {
        public frmnewcli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            cliente.nome = txtboxnome.Text;
            cliente.endereco = txtboxend.Text;
            cliente.numero = txtboxnum.Text;
            cliente.bairro = txtboxbairro.Text;
            cliente.telefone = txtboxtel.Text;
            cliente.celular = txtboxcel.Text;

            dalCli.Insert(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtboxnome.Text = (" ");
            txtboxend.Text = (" ");
            txtboxnum.Text = (" ");
            txtboxbairro.Text = (" ");
            txtboxtel.Text = (" ");
            txtboxcel.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxnome.Text = (" ");
            txtboxend.Text = (" ");
            txtboxnum.Text = (" ");
            txtboxbairro.Text = (" ");
            txtboxtel.Text = (" ");
            txtboxcel.Text = (" ");
        }
    }
}
