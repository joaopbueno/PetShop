using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetShopp
{
    public partial class fmCadAnimal : Form
    {
        public fmCadAnimal()
        {
            InitializeComponent();
        }

        private void fmCadAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.petshopDataSet.servico);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void animalBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(petshopDataSet.animal);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void animalBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ani_alergiaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFotoAni_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog2.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar arquivo" + ex.Message, "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarAni_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
        }

        private void btnEditarAni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(petshopDataSet.animal);
                }
            }
            catch (Exception)
            {
                animalTableAdapter.Fill(petshopDataSet.animal);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do resgistro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(petshopDataSet.animal);
                }
            }
            catch (Exception)
            {
                animalTableAdapter.Fill(petshopDataSet.animal);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(petshopDataSet.animal);
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
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            animalBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            animalBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            animalBindingSource.MovePrevious();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            animalBindingSource.MoveFirst();
        }
    }
}
