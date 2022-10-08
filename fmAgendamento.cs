using PetShopp.petshopDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace PetShopp
{
    public partial class fmAgendamento : Form
    {
        public fmAgendamento()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void fmAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.petshopDataSet.agendamento);

        }

        private void ag_codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ag_codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.MovePrevious();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.MoveLast();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agendamentoBindingSource.RemoveCurrent();
                    agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                }
            }
            catch (Exception)
            {
                agendamentoTableAdapter.Fill(petshopDataSet.agendamento);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(petshopDataSet.agendamento);
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
            ag_situacaoComboBox.Text = "Agendado";
            ag_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            ag_horarioMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            ag_totalTextBox.Text = "0.00";

            agendamentoBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void ag_animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
