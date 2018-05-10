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
    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmconsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet5.tipos'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposTableAdapter1.Fill(this.panaroDataSet5.tipos);
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet4.tipos'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposTableAdapter.Fill(this.panaroDataSet4.tipos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
