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
    public partial class FormLoginSenha : Form
    {
        public FormLoginSenha()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = usuarioTextBox.Text;
                string senha = senhaTextBox.Text;

                ProfessorBLL professorBLL = new ProfessorBLL();
                ProfessorModels professor = new ProfessorModels();
                professor = professorBLL.BuscarVerificarUsuarioSenha(usuario, senha);
                if(professor == null|| professor.Id < 1 )
                {
                    MessageBox.Show("Usuário ou Senha Inválido");
                }
                else
                {
                    Constantes.IdUsuarioLogado = professor.Id;
                    Constantes.UsuarioLogado = professor.Nome;
                    Close();
                }

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

        private void FormLoginSenha_Load(object sender, EventArgs e)
        {
           
        }
    }
}
