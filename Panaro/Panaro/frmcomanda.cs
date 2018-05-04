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
    public partial class frmcomanda : Form
    {
        public frmcomanda()
        {
            InitializeComponent();
        }

        private void frmcomanda_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalCli.Select();

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
    }
}
