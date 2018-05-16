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
    public partial class frmnewuser : Form
    {
        public frmnewuser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxnome.Focus();
            Camadas.Model.Usuarios usuarios = new Camadas.Model.Usuarios();
            Camadas.DAL.Usuarios dalUser = new Camadas.DAL.Usuarios();
            usuarios.nome = txtboxnome.Text;
            usuarios.usuario = txtboxuser.Text;
            usuarios.senha = txtboxsenha.Text;

            dalUser.Insert(usuarios);
            MessageBox.Show("Usuario cadastrado com sucesso", "Cadastro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtboxnome.Focus();
            txtboxnome.Text = (" ");
            txtboxuser.Text = (" ");
            txtboxsenha.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxnome.Focus();
            txtboxnome.Text = (" ");
            txtboxuser.Text = (" ");
            txtboxsenha.Text = ("");
        }
    }
}
