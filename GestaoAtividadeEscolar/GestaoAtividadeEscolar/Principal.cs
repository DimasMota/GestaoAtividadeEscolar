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
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void turmaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Turma turma = new Turma();
                turma = ((Turma)turmaBindingSource.Current);

                if (turmaDataGridView.Columns[e.ColumnIndex].Name == "Excluir")

                {

                    if (turma.Id < 1 || String.IsNullOrEmpty(turma.Nome))
                    {
                        MessageBox.Show("Selecione uma atividade");
                        return;
                    }
                    List<Atividade> atividades = new List<Atividade>();
                    atividades = new AtividadeBLL().BuscarTodasAtividades(turma.Id);

                    if (atividades.Count()>0 )
                    {
                        MessageBox.Show("Não é possível excluir esta turma. Tem atividades vinculadas.");
                        return;
                    }
                    if (MessageBox.Show("Id: " + turma.Id + " Turma: " + turma.Nome + "\nAs Atividades desta turma também serão excluidas. \n Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;


                    new TurmaBLL().Excluir(turma.Id);
                    MessageBox.Show("Turma excluída com sucesso!");
                    turmaBindingSource.RemoveCurrent();

                }

                if (turmaDataGridView.Columns[e.ColumnIndex].Name == "Visualizar")
                {

                    using (FormVisualizarAtividade frm = new FormVisualizarAtividade(turma))
                    {
                        frm.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                using(FormLoginAcesso frm = new FormLoginAcesso())
                {
                    frm.ShowDialog();
                }
                lblUsuarioLogado.Text = "Professor: " + Constantes.UsuarioLogado;
                List<Turma> turmas = new List<Turma>();

                turmas = new TurmaBLL().BuscarTodasTurmas(Constantes.IdUsuarioLogado);
                turmaBindingSource.DataSource = turmas;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
