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
    public partial class frmconcom : Form
    {
        public frmconcom()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {

            Camadas.DAL.Comanda dalCom = new Camadas.DAL.Comanda();
            dgvComanda.DataSource = "";
            dgvComanda.DataSource = dalCom.Select();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvComanda_DoubleClick(object sender, EventArgs e)
        {
            if (dgvComanda.SelectedRows.Count > 0)
            {
                txtboxCom.Text = dgvComanda.SelectedRows[0].Cells["cliente"].Value.ToString();
            }
        }
    }
}
