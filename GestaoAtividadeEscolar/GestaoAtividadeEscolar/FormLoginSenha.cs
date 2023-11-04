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

        private void FormLoginSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Insira o Usuário");
                    return;
                }
                if (String.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Insira o Senha");
                    return;
                }
                Professor professor = new Professor();
                professor = new ProfessorBLL().ValidarUsuarioSenha(txtUsuario.Text, txtSenha.Text);
                Constantes.IdUsuarioLogado = professor.Id;
                Constantes.UsuarioLogado = professor.Nome;

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
