namespace GestaoAtividadeEscolar
{
    partial class FormVisualizarAtividade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.atividadeDataGridView = new System.Windows.Forms.DataGridView();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.bntCadastrarAtividade = new System.Windows.Forms.Button();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(875, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 35);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // atividadeDataGridView
            // 
            this.atividadeDataGridView.AllowUserToAddRows = false;
            this.atividadeDataGridView.AllowUserToDeleteRows = false;
            this.atividadeDataGridView.AllowUserToOrderColumns = true;
            this.atividadeDataGridView.AutoGenerateColumns = false;
            this.atividadeDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.atividadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.atividadeDataGridView.DataSource = this.atividadeBindingSource;
            this.atividadeDataGridView.Location = new System.Drawing.Point(46, 162);
            this.atividadeDataGridView.Name = "atividadeDataGridView";
            this.atividadeDataGridView.ReadOnly = true;
            this.atividadeDataGridView.RowHeadersVisible = false;
            this.atividadeDataGridView.RowHeadersWidth = 51;
            this.atividadeDataGridView.RowTemplate.Height = 24;
            this.atividadeDataGridView.Size = new System.Drawing.Size(900, 307);
            this.atividadeDataGridView.TabIndex = 2;
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataSource = typeof(Models.Atividade);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(41, 18);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(227, 29);
            this.lblUsuarioLogado.TabIndex = 3;
            this.lblUsuarioLogado.Text = "USUARIO LOGADO";
            // 
            // bntCadastrarAtividade
            // 
            this.bntCadastrarAtividade.Location = new System.Drawing.Point(760, 101);
            this.bntCadastrarAtividade.Name = "bntCadastrarAtividade";
            this.bntCadastrarAtividade.Size = new System.Drawing.Size(173, 45);
            this.bntCadastrarAtividade.TabIndex = 4;
            this.bntCadastrarAtividade.Text = "Cadastrar Atividade";
            this.bntCadastrarAtividade.UseVisualStyleBackColor = true;
            this.bntCadastrarAtividade.Click += new System.EventHandler(this.bntCadastrarAtividade_Click);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.Location = new System.Drawing.Point(41, 105);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(98, 29);
            this.lblNomeTurma.TabIndex = 5;
            this.lblNomeTurma.Text = "TURMA";
            // 
            // FormVisualizarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.lblNomeTurma);
            this.Controls.Add(this.bntCadastrarAtividade);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.atividadeDataGridView);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualizarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisualizarAtividade";
            this.Load += new System.EventHandler(this.FormVisualizarAtividade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private System.Windows.Forms.DataGridView atividadeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button bntCadastrarAtividade;
        private System.Windows.Forms.Label lblNomeTurma;
    }
}