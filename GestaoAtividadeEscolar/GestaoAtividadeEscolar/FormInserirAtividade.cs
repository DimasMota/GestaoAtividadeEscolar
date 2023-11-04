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
    public partial class FormInserirAtividade : Form
    {
        private Turma turma = new Turma();
        public FormInserirAtividade(Turma _turma)
        {
            InitializeComponent();
            turma = _turma;
        }

        private void FormInserirAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor: " + Constantes.UsuarioLogado;
                lblNomeTurma.Text = turma.Nome;

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
                Atividade atividade = new Atividade();

                atividade.Nome = txtNomeAtividade.Text;
                if (String.IsNullOrEmpty(atividade.Nome))
                {
                    MessageBox.Show("Digite o conteúdo.");
                    return;
                }
                if (turma.Id == 0)
                {
                    MessageBox.Show("Não foi selecionado a turma.");
                }
                new AtividadeBLL().Cadastrar(atividade, turma.Id);
                MessageBox.Show("Conteúdo cadastrado com sucesso");
                Close();

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
