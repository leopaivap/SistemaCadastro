﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar; // variável global

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }





        void limpaCampos()
        {
            txtnome.Text = "";
            cbGenero.Text = "";
            txtintegrantes.Text = "";
            txtranking.Text = "";
            txtnome.Focus();
        }

        void limpaCamposAltera()
        {
            txtAlteraNome.Text = "";
            cbAlteraGenero.Text = "";
            txtAlteraIntegrantes.Text = "";
            txtAlteraRanking.Text = "";
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            listaGenero();
            listaBanda();
        }


        void listaGenero()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaGeneros();
            cbGenero.DataSource = tabelaDados;
            cbGenero.DisplayMember = "genero";
            cbGenero.ValueMember = "idgenero";
            // preenchendo cbAlteraGenero
            cbAlteraGenero.DataSource = tabelaDados;
            cbAlteraGenero.DisplayMember = "genero";
            cbAlteraGenero.ValueMember = "idgenero";
            //
            lblmsgerro.Text = con.mensagem;
            cbGenero.Text = "";
            cbAlteraGenero.Text = "";
        }


        void listaBanda()
        {
            ConectaBanco con = new ConectaBanco();
            dgBandas.DataSource = con.listaBandas();
        }

        private void BtnConfirmaCadastro_Click_1(object sender, EventArgs e)
        {
            Banda b = new Banda();
            b.Nome = txtnome.Text;
            b.Genero = Convert.ToInt32(cbGenero.SelectedValue.ToString());
            b.Integrantes = Convert.ToInt32(txtintegrantes.Text);
            b.Ranking = Convert.ToInt32(txtranking.Text);

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereBanda(b);
            if (retorno)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
                lblmsgerro.Text = conecta.mensagem;

            listaBanda();
            limpaCampos();

        } // fim confirma insere banda

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgBandas.DataSource as DataTable).DefaultView.RowFilter = String.Format("nome like'{0}%'", txtBusca.Text);
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
            int linha = dgBandas.CurrentRow.Index;
            int idRemover = Convert.ToInt32(dgBandas.Rows[linha].Cells["idbandas"].Value.ToString());
            DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remove Banda", MessageBoxButtons.OKCancel);

            if (resp == DialogResult.OK)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaBanda(idRemover);
                if (retorno)
                    MessageBox.Show("Banda Excluida!");
                else
                    lblmsgerro.Text = conecta.mensagem;
                listaBanda();
            }//fim if ok
            else
                MessageBox.Show("Operação Cancelada!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgBandas.CurrentRow.Index;
            idAlterar = Convert.ToInt32(dgBandas.Rows[linha].Cells["idbandas"].Value.ToString()); // pega o id da linha selecionada
            txtAlteraNome.Text = dgBandas.Rows[linha].Cells["nome"].Value.ToString();
            txtAlteraIntegrantes.Text = dgBandas.Rows[linha].Cells["integrantes"].Value.ToString();
            txtAlteraRanking.Text = dgBandas.Rows[linha].Cells["ranking"].Value.ToString();
            cbAlteraGenero.Text = dgBandas.Rows[linha].Cells["genero"].Value.ToString();

            tabControl1.SelectedTab = tabAlterar; // muda aba 
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            Banda b = new Banda();
            b.Nome = txtAlteraNome.Text;
            b.Integrantes = Convert.ToInt32(txtAlteraIntegrantes.Text);
            b.Ranking = Convert.ToInt32(txtAlteraRanking.Text);
            b.Genero = Convert.ToInt32(cbAlteraGenero.SelectedValue.ToString());

            // Enviar os dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraBanda(b, idAlterar);

            if (retorno)
            {
                MessageBox.Show("Dados alterados com sucesso!");

                limpaCamposAltera();
                listaBanda();
            }
            else
                lblmsgerro.Text = conecta.mensagem;
        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
          
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgBandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
