using PetShopp;
using System;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmCadCliente cliente = new fmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;

            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(cliente);
            cliente.Show();

            //aplica a posição do eixo X do botao ao panel selecao 

            PanelSelecao.Top = btnCliente.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear();

            PanelSelecao.Top = btnInicio.Top;
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            fmAgendamento agendamento = new fmAgendamento();
            agendamento.TopLevel = false;
            agendamento.Dock = DockStyle.Fill;

            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(agendamento);
            agendamento.Show();

            PanelSelecao.Top = btnAgendamentos.Top;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            fmCadServico servico = new fmCadServico();
            servico.TopLevel = false;
            servico.Dock = DockStyle.Fill;

            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(servico);
            servico.Show();

            PanelSelecao.Top = btnServicos.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            fmCadAnimal animal = new fmCadAnimal();
            animal.TopLevel = false;
            animal.Dock = DockStyle.Fill;

            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(animal);
            animal.Show();

            
            PanelSelecao.Top = btnAnimal.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            fmCadRaca raca = new fmCadRaca();
            raca.TopLevel = false;
            raca.Dock = DockStyle.Fill;

            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(raca);
            raca.Show();

            PanelSelecao.Top = btnRaca.Top;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // minimizando
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTopo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
