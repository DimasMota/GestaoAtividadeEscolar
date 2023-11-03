using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoAtividadeEscolar
{
    public partial class FormAtividade : Form
    {
        public TurmaModels turma = new TurmaModels();
        public FormAtividade(TurmaModels _turma)
        {
            InitializeComponent();
            try
            {
                turma = _turma;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Selecione uma Turma");
                Close();
            }


        }

        private void FormAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                txtTurma.Text = turma.Descricao;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovaAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxCadastrarAtividade.Enabled = true;
                txtDescricaoAtividade.Focus();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelarCadastroAtividade_Click(object sender, EventArgs e)
        {
            try
            {
              txtDescricaoAtividade.Clear();
                btnNovaAtividade.Focus();
                groupBoxCadastrarAtividade.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btnListarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                atividadeModelsBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                AtividadeModels atividade = new AtividadeModels();
                atividade.Descricao = txtDescricaoAtividade.Text;
                new AtividadeBLL().Cadastrar(atividade, turma.Id);
                MessageBox.Show("Atividade cadastrada com sucesso!");
                txtTurma.Clear();
                groupBoxCadastrarAtividade.Enabled = false;

                btnNovaAtividade.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
