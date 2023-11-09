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
        public int fechar = 0;
        public FormCadastrarAtividade(Turma _turma)
        {
            InitializeComponent();
            turma = _turma;
        }

        private void FormCadastrarAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                Hide();
                lblNomeTurma.Text = turma.Nome;
                lblUsuarioLogado.Text = Constantes.UsuarioLogado;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblUsuarioLogado_Click(object sender, EventArgs e)
        {
            fechar = 1;
            this.Hide();


        }

        private void btnCadastrarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (String.IsNullOrEmpty(txtNomeAtividade.Text))
                {
                    MessageBox.Show("Insira uma atividade");
                    txtNomeAtividade.Focus();
                    return;
                }
                Atividade atividade = new Atividade();
                atividade.Nome = txtNomeAtividade.Text;


                new AtividadeBLL().Cadastrar(atividade, turma.Id);

                MessageBox.Show("Atividade castrada com sucesso!");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
