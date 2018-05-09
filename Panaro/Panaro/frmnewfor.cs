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
            rdbtnbebidas.Select();
            txtboxnome.Text = (" ");
            txtboxmarca.Text = (" ");
            txtboxendereco.Text = (" ");
            txtboxnumero.Text = (" ");
            txtboxcelular.Text = (" ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.Model.Fornecedor fornecedor = new Camadas.Model.Fornecedor();
            Camadas.DAL.Fornecedor dalFor = new Camadas.DAL.Fornecedor();
            txtboxnome.Focus();
            rdbtnbebidas.Select();
            fornecedor.nome = txtboxnome.Text;
            fornecedor.marca = txtboxmarca.Text;
            fornecedor.endereco = txtboxendereco.Text;
            fornecedor.numero = txtboxnumero.Text;
            if (rdbtnbebidas.Checked)
            {
                fornecedor.produto = "bebidas";
            }
            else if (rdbtnespetinhos.Checked)
            {
                fornecedor.produto = "espetinhos";
            }
            else if (rdbtndoces.Checked)
            {
                fornecedor.produto = "doces";
            }
            else if (rdbtnoutros.Checked)
            {
                fornecedor.produto = "outros";
            }
            fornecedor.celular = txtboxcelular.Text;

            dalFor.Insert(fornecedor);
            MessageBox.Show("Fornecedor cadastrado com sucesso", "Cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtboxnome.Focus();
            rdbtnbebidas.Select();
        }

        private void frmnewfor_Load(object sender, EventArgs e)
        {
            txtboxnome.Focus();
            rdbtnbebidas.Select();
        }
    }
}
