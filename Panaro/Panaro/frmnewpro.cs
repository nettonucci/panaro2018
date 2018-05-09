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
    public partial class frmnewpro : Form
    {
        public frmnewpro()
        {
            InitializeComponent();
        }

        private void frmnewpro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet3.tipos'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposTableAdapter1.Fill(this.panaroDataSet3.tipos);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet.tipos'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposTableAdapter.Fill(this.panaroDataSet.tipos);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmnewtip frmtip = new frmnewtip();
            frmtip.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
