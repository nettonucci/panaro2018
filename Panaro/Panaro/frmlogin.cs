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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            txtboxsenha.PasswordChar = '*';
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fmrinicio frmini = new fmrinicio();
            frmini.Show();
            this.Close();
        }
    }
}
