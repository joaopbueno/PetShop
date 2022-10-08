using PetShopp.petshopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopp
{
    public partial class fmCadRaca : Form
    {
        public fmCadRaca()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void fmCadRaca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            racaBindingSource.MoveFirst();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            racaBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            racaBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            racaBindingSource.MoveLast();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            racaBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    racaBindingSource.RemoveCurrent();
                    racaTableAdapter.Update(petshopDataSet.raca);
                }
            }
            catch (Exception)
            {
                racaTableAdapter.Fill(petshopDataSet.raca);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.racaBindingSource.EndEdit();
                racaTableAdapter.Update(petshopDataSet.raca);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            racaBindingSource.CancelEdit();
            groupBox1.Enabled =false;

        }
    }
}
