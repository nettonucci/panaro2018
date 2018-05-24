using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaro
{
    public partial class frmlogin : Form
    {
        Camadas.BLL.Usuarios BLLuser = new Camadas.BLL.Usuarios();
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
            Boolean result = BLLuser.Login(txtboxuser.Text, txtboxsenha.Text);

            if (result)
            {
                MessageBox.Show("Logado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form f = new fmrinicio();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incoreto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
    }
}
