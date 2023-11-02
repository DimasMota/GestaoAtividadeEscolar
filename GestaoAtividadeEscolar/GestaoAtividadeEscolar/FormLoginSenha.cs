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
                if(professor == null)
                {
                    MessageBox.Show("Usuário ou Senha Inválido");
                }
                else
                {
                  
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
