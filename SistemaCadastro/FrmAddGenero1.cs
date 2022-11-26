using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddGenero1 : Form
    {
        public FrmAddGenero1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Sistema sistema = new Sistema();
            this.Hide();
            sistema.ShowDialog();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGenero_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereGenero(txtAddGenero.Text);

            if (retorno)
            {
                MessageBox.Show("Novo Genero Inserido!");
                txtAddGenero.Text = "";
                txtAddGenero.Focus();
            }
            else
                MessageBox.Show(conecta.mensagem);

        }//fim add genero
    }
}
