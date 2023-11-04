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
    public partial class FormCadastrarTurma : Form
    {
        public FormCadastrarTurma()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor: " + Constantes.UsuarioLogado;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomeTurma.Text))
                {
                    MessageBox.Show("Digite o nome da Turma");
                    return;
                }
                Turma turma = new Turma();
                turma.Nome = txtNomeTurma.Text;


                new TurmaBLL().Cadastrar(turma);

                MessageBox.Show("Turma cadastrada com sucesso!");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
