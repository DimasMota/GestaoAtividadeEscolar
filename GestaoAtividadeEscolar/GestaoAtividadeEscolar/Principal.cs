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
    public partial class Principal : Form
    {
        private int id;
        public Principal()
        {
            InitializeComponent();
         
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                using (FormLoginSenha frm = new FormLoginSenha())
                {
                    frm.ShowDialog();


                }
                lblUsuarioLogado.Text = new ProfessorBLL().BuscarProfessorPorId(Constantes.IdUsuarioLogado).Nome;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNovaTurma_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxCadastrarTurma.Enabled = true;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvarTurma_Click(object sender, EventArgs e)
        {
            try
            {
                
                TurmaModels turma = new TurmaModels();
                turma.Descricao = textBoxDescricaoTurma.Text;

                new TurmaBLL().Cadastrar(turma, Constantes.IdUsuarioLogado);
                MessageBox.Show("Turma cadastrada com sucesso");
                textBoxDescricaoTurma.Clear();
                btnAtividade.Focus();
                groupBoxCadastrarTurma.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                             

               turmaModelsBindingSource.DataSource = new TurmaBLL().BuscarTodasTurma(Constantes.IdUsuarioLogado);

                groupBoxCadastrarTurma.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelarCadastroDeTurma_Click(object sender, EventArgs e)
        {
            textBoxDescricaoTurma.Clear();
            btnNovaTurma.Focus();
            groupBoxCadastrarTurma.Enabled = false;
        }

        private void btnAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                TurmaModels turma = new TurmaModels();
                turma = ((TurmaModels)turmaModelsBindingSource.Current);
                if(turma.Id < 1|| String.IsNullOrEmpty( turma.Descricao))
                {
                    MessageBox.Show("Selecione uma atividade");
                    return;
                }
                using(FormAtividade frm = new FormAtividade(turma))
                {
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            try
            {
                TurmaModels turma = new TurmaModels();
                turma = ((TurmaModels)turmaModelsBindingSource.Current);
                if (turma.Id < 1 || String.IsNullOrEmpty(turma.Descricao))
                {
                    MessageBox.Show("Selecione uma atividade");
                    return;
                }

                if (MessageBox.Show("As Atividades desta turma também serão excluidas. \n Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

              
                new TurmaBLL().Excluir(turma.Id);
                MessageBox.Show("Turma excluída com sucesso!");
                turmaModelsBindingSource.RemoveCurrent();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {

                //using (Principal frm = new Principal())
                //{
                //    frm.ShowDialog();


                //}
                //Close();
                Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
