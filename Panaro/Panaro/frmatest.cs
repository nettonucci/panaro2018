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
        }

        private void dgvprod_DoubleClick(object sender, EventArgs e)
        {
            if (dgvprod.SelectedRows.Count > 0)
            {
                txtboxid.Text = dgvprod.SelectedRows[0].Cells["id"].Value.ToString();
                txtboxprod.Text = dgvprod.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtboxqtd.Text = dgvprod.SelectedRows[0].Cells["quantidade"].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
