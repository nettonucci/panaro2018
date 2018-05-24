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
    public partial class frmrelcont : Form
    {
        public frmrelcont()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmrel_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Fornecedor dalFor = new Camadas.DAL.Fornecedor();
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = dalFor.Select();
        }
    }
}
