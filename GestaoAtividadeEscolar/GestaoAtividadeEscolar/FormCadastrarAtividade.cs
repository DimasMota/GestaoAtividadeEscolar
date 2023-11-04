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
    public partial class FormCadastrarAtividade : Form
    {
        private Turma turma = new Turma();
        public FormCadastrarAtividade(Turma _turma)
        {
            InitializeComponent();
            turma = _turma;
        }

        private void FormCadastrarAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor: " + Constantes.UsuarioLogado;
                lblNomeTurma.Text = turma.Nome;

                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInserirAtividade_Click(object sender, EventArgs e)
        {
            try
            {

                using (FormInserirAtividade frm = new FormInserirAtividade(turma))
                {
                    frm.ShowDialog();
                }
                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
