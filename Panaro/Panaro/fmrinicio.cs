﻿using System;
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
    public partial class fmrinicio : Form
    {
        public fmrinicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconcom test = new frmconcom();

            test.Show();
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsobre frmsob = new frmsobre();
            frmsob.MdiParent = this;
            frmsob.Show();
        }

        private void addcmd_Click(object sender, EventArgs e)
        {
            frmnewcom frmcom = new frmnewcom();
            frmcom.MdiParent = this;
            frmcom.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja fechar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewcli frmcli = new frmnewcli();
            frmcli.MdiParent = this;
            frmcli.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewfor frmfor = new frmnewfor();
            frmfor.MdiParent = this;
            frmfor.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewpro frmpro = new frmnewpro();
            frmpro.MdiParent = this;
            frmpro.Show();
        }

        private void colsultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconpro frmconp = new frmconpro();
            frmconp.MdiParent = this;
            frmconp.Show();
        }

        private void atualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmatest frmat = new frmatest();
            frmat.MdiParent = this;
            frmat.Show();
        }

        private void produtosEmFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprofalt frmfalt = new frmprofalt();
            frmfalt.MdiParent = this;
            frmfalt.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewconta frmconta = new frmnewconta();
            frmconta.MdiParent = this;
            frmconta.Show();
        }

        private void contasAreceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrec frmrec = new frmcontrec();
            frmrec.MdiParent = this;
            frmrec.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewuser frmus = new frmnewuser();
            frmus.MdiParent = this;
            frmus.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrelcli frmrelc = new frmrelcli();
            frmrelc.MdiParent = this;
            frmrelc.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
