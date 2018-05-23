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
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet8.comandas'. Você pode movê-la ou removê-la conforme necessário.
            this.comandasTableAdapter.Fill(this.panaroDataSet8.comandas);

        }
    }
}
