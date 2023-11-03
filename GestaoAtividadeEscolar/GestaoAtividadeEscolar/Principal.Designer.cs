namespace GestaoAtividadeEscolar
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.textBoxDescricaoTurma = new System.Windows.Forms.TextBox();
            this.lblDescricaoDaTurma = new System.Windows.Forms.Label();
            this.btnSalvarTurma = new System.Windows.Forms.Button();
            this.groupBoxCadastrarTurma = new System.Windows.Forms.GroupBox();
            this.btnCancelarCadastroDeTurma = new System.Windows.Forms.Button();
            this.btnNovaTurma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.turmaModelsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluirTurma = new System.Windows.Forms.Button();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBoxCadastrarTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turmaModelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(622, 9);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioLogado.TabIndex = 0;
            // 
            // textBoxDescricaoTurma
            // 
            this.textBoxDescricaoTurma.Location = new System.Drawing.Point(10, 33);
            this.textBoxDescricaoTurma.Name = "textBoxDescricaoTurma";
            this.textBoxDescricaoTurma.Size = new System.Drawing.Size(569, 20);
            this.textBoxDescricaoTurma.TabIndex = 2;
            // 
            // lblDescricaoDaTurma
            // 
            this.lblDescricaoDaTurma.AutoSize = true;
            this.lblDescricaoDaTurma.Location = new System.Drawing.Point(7, 17);
            this.lblDescricaoDaTurma.Name = "lblDescricaoDaTurma";
            this.lblDescricaoDaTurma.Size = new System.Drawing.Size(99, 13);
            this.lblDescricaoDaTurma.TabIndex = 9;
            this.lblDescricaoDaTurma.Text = "Descrição da turma";
            // 
            // btnSalvarTurma
            // 
            this.btnSalvarTurma.Location = new System.Drawing.Point(585, 30);
            this.btnSalvarTurma.Name = "btnSalvarTurma";
            this.btnSalvarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTurma.TabIndex = 3;
            this.btnSalvarTurma.Text = "Salvar";
            this.btnSalvarTurma.UseVisualStyleBackColor = true;
            this.btnSalvarTurma.Click += new System.EventHandler(this.btnSalvarTurma_Click);
            // 
            // groupBoxCadastrarTurma
            // 
            this.groupBoxCadastrarTurma.Controls.Add(this.btnCancelarCadastroDeTurma);
            this.groupBoxCadastrarTurma.Controls.Add(this.btnSalvarTurma);
            this.groupBoxCadastrarTurma.Controls.Add(this.textBoxDescricaoTurma);
            this.groupBoxCadastrarTurma.Controls.Add(this.lblDescricaoDaTurma);
            this.groupBoxCadastrarTurma.Enabled = false;
            this.groupBoxCadastrarTurma.Location = new System.Drawing.Point(30, 113);
            this.groupBoxCadastrarTurma.Name = "groupBoxCadastrarTurma";
            this.groupBoxCadastrarTurma.Size = new System.Drawing.Size(748, 65);
            this.groupBoxCadastrarTurma.TabIndex = 10;
            this.groupBoxCadastrarTurma.TabStop = false;
            // 
            // btnCancelarCadastroDeTurma
            // 
            this.btnCancelarCadastroDeTurma.Location = new System.Drawing.Point(666, 30);
            this.btnCancelarCadastroDeTurma.Name = "btnCancelarCadastroDeTurma";
            this.btnCancelarCadastroDeTurma.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastroDeTurma.TabIndex = 4;
            this.btnCancelarCadastroDeTurma.Text = "Cancelar";
            this.btnCancelarCadastroDeTurma.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroDeTurma.Click += new System.EventHandler(this.btnCancelarCadastroDeTurma_Click);
            // 
            // btnNovaTurma
            // 
            this.btnNovaTurma.Location = new System.Drawing.Point(40, 84);
            this.btnNovaTurma.Name = "btnNovaTurma";
            this.btnNovaTurma.Size = new System.Drawing.Size(105, 23);
            this.btnNovaTurma.TabIndex = 1;
            this.btnNovaTurma.Text = "Cadastrar Turma";
            this.btnNovaTurma.UseVisualStyleBackColor = true;
            this.btnNovaTurma.Click += new System.EventHandler(this.btnNovaTurma_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lista de Turma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turmaModelsDataGridView
            // 
            this.turmaModelsDataGridView.AllowUserToAddRows = false;
            this.turmaModelsDataGridView.AllowUserToDeleteRows = false;
            this.turmaModelsDataGridView.AllowUserToOrderColumns = true;
            this.turmaModelsDataGridView.AutoGenerateColumns = false;
            this.turmaModelsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.turmaModelsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.turmaModelsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.turmaModelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turmaModelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.turmaModelsDataGridView.DataSource = this.turmaModelsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.turmaModelsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.turmaModelsDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.turmaModelsDataGridView.Location = new System.Drawing.Point(40, 225);
            this.turmaModelsDataGridView.Name = "turmaModelsDataGridView";
            this.turmaModelsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.turmaModelsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.turmaModelsDataGridView.RowHeadersVisible = false;
            this.turmaModelsDataGridView.Size = new System.Drawing.Size(618, 273);
            this.turmaModelsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Turma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // turmaModelsBindingSource
            // 
            this.turmaModelsBindingSource.DataSource = typeof(Models.TurmaModels);
            // 
            // btnExcluirTurma
            // 
            this.btnExcluirTurma.Location = new System.Drawing.Point(664, 336);
            this.btnExcluirTurma.Name = "btnExcluirTurma";
            this.btnExcluirTurma.Size = new System.Drawing.Size(107, 23);
            this.btnExcluirTurma.TabIndex = 7;
            this.btnExcluirTurma.Text = "Excluir Turma";
            this.btnExcluirTurma.UseVisualStyleBackColor = true;
            this.btnExcluirTurma.Click += new System.EventHandler(this.btnExcluirTurma_Click);
            // 
            // btnAtividade
            // 
            this.btnAtividade.Location = new System.Drawing.Point(664, 278);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(107, 23);
            this.btnAtividade.TabIndex = 6;
            this.btnAtividade.Text = "Atividade";
            this.btnAtividade.UseVisualStyleBackColor = true;
            this.btnAtividade.Click += new System.EventHandler(this.btnAtividade_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(711, 47);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 25);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtividade);
            this.Controls.Add(this.btnExcluirTurma);
            this.Controls.Add(this.turmaModelsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNovaTurma);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.groupBoxCadastrarTurma);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBoxCadastrarTurma.ResumeLayout(false);
            this.groupBoxCadastrarTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turmaModelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.TextBox textBoxDescricaoTurma;
        private System.Windows.Forms.Label lblDescricaoDaTurma;
        private System.Windows.Forms.Button btnSalvarTurma;
        private System.Windows.Forms.GroupBox groupBoxCadastrarTurma;
        private System.Windows.Forms.Button btnNovaTurma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource turmaModelsBindingSource;
        private System.Windows.Forms.DataGridView turmaModelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnCancelarCadastroDeTurma;
        private System.Windows.Forms.Button btnExcluirTurma;
        private System.Windows.Forms.Button btnAtividade;
        private System.Windows.Forms.Button btnSair;
    }
}