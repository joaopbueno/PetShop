using PetShopp.petshopDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace PetShopp
{
    public partial class fmCadServico : Form
    {
        public fmCadServico()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void fmCadServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.petshopDataSet.servico);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    servicoBindingSource.RemoveCurrent();
                    servicoTableAdapter.Update(petshopDataSet.servico);
                }
            }
            catch (Exception)
            {
                servicoTableAdapter.Fill(petshopDataSet.servico);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.servicoBindingSource.EndEdit();
                servicoTableAdapter.Update(petshopDataSet.servico);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.MoveLast();
            }
            catch
            {
                MessageBox.Show("Este é o último registro");
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.MoveNext();
            }
            catch
            {
                MessageBox.Show("Este é o último registro");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.MovePrevious();
            }
            catch
            {
                MessageBox.Show("Não existe registro anterior");
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.MoveFirst();
            }
            catch
            {
                MessageBox.Show("Não existe registro anterior");
            }
        }
    }
}
