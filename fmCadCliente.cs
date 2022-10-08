using PetShopp.petshopDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetShopp
{
    public partial class fmCadCliente : Form
    {
        public fmCadCliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }

        }

        private void fmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(petshopDataSet.cliente);
                }
            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar arquivo" + ex.Message, "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(petshopDataSet.cliente);
                }
            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
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
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
        }
    }
}
