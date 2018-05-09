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
    public partial class frmnewtip : Form
    {
        public frmnewtip()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.Model.Tipos tipos = new Camadas.Model.Tipos();
            Camadas.DAL.Tipos dalTip = new Camadas.DAL.Tipos();
            txtboxtipo.Focus();
            tipos.descricao = txtboxtipo.Text;
            dalTip.Insert(tipos);
            MessageBox.Show("Tipo cadastrado com sucesso", "Cadastro de Tipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtboxtipo.Focus();
            txtboxtipo.Text = (" ");
        }
    }
}
