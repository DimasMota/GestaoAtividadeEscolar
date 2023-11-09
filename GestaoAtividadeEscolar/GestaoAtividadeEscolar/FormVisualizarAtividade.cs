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
    public partial class FormVisualizarAtividade : Form
    {
        private Turma turma = new Turma();
        public FormVisualizarAtividade(Turma _turma)
        {
            InitializeComponent();
            turma = _turma;
        }

        private void FormVisualizarAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                lblNomeTurma.Text = turma.Nome;
                lblUsuarioLogado.Text = Constantes.UsuarioLogado;

                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntCadastrarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                using(FormCadastrarAtividade frm = new FormCadastrarAtividade(turma))
                {
                    frm.ShowDialog();
                    if(frm.fechar == 1)
                    {
                        Close();
                    }
                }
                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblUsuarioLogado_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
