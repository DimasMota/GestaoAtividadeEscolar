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
    public partial class FormLoginAcesso : Form
    {
        public FormLoginAcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();
                professor = new ProfessorBLL().ValidarProfessor(txtUsuario.Text, txtSenha.Text);
                if(String.IsNullOrEmpty(professor.Nome) || professor.Id == 0)
                {
                    MessageBox.Show("Usuário e/ou Senha Inválido");
                    txtSenha.Clear();
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }
                Constantes.IdUsuarioLogado = professor.Id;
                Constantes.UsuarioLogado = professor.Nome;
                Close();

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
