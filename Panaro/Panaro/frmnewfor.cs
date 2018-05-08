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
            txtboxnome.Text = (" ");
            txtboxmarca.Text = (" ");
            txtboxendereco.Text = (" ");
            txtboxnumero.Text = (" ");
            txtboxcelular.Text = (" ");
        }
    }
}
