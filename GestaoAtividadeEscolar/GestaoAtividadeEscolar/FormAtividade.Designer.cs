namespace GestaoAtividadeEscolar
{
    partial class FormAtividade
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
            this.groupBoxCadastrarAtividade = new System.Windows.Forms.GroupBox();
            this.txtDescricaoAtividade = new System.Windows.Forms.TextBox();
            this.btnSalvarAtividade = new System.Windows.Forms.Button();
            this.btnCancelarCadastroAtividade = new System.Windows.Forms.Button();
            this.btnNovaAtividade = new System.Windows.Forms.Button();
            this.atividadeModelsDataGridView = new System.Windows.Forms.DataGridView();
            this.atividadeModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarAtividade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCadastrarAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeModelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCadastrarAtividade
            // 
            this.groupBoxCadastrarAtividade.Controls.Add(this.label1);
            this.groupBoxCadastrarAtividade.Controls.Add(this.txtDescricaoAtividade);
            this.groupBoxCadastrarAtividade.Controls.Add(this.btnCancelarCadastroAtividade);
            this.groupBoxCadastrarAtividade.Controls.Add(this.btnSalvarAtividade);
            this.groupBoxCadastrarAtividade.Enabled = false;
            this.groupBoxCadastrarAtividade.Location = new System.Drawing.Point(36, 118);
            this.groupBoxCadastrarAtividade.Name = "groupBoxCadastrarAtividade";
            this.groupBoxCadastrarAtividade.Size = new System.Drawing.Size(726, 54);
            this.groupBoxCadastrarAtividade.TabIndex = 0;
            this.groupBoxCadastrarAtividade.TabStop = false;
            // 
            // txtDescricaoAtividade
            // 
            this.txtDescricaoAtividade.Location = new System.Drawing.Point(6, 25);
            this.txtDescricaoAtividade.Name = "txtDescricaoAtividade";
            this.txtDescricaoAtividade.Size = new System.Drawing.Size(511, 20);
            this.txtDescricaoAtividade.TabIndex = 0;
            // 
            // btnSalvarAtividade
            // 
            this.btnSalvarAtividade.Location = new System.Drawing.Point(564, 22);
            this.btnSalvarAtividade.Name = "btnSalvarAtividade";
            this.btnSalvarAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAtividade.TabIndex = 1;
            this.btnSalvarAtividade.Text = "Salvar";
            this.btnSalvarAtividade.UseVisualStyleBackColor = true;
            this.btnSalvarAtividade.Click += new System.EventHandler(this.btnSalvarAtividade_Click);
            // 
            // btnCancelarCadastroAtividade
            // 
            this.btnCancelarCadastroAtividade.Location = new System.Drawing.Point(645, 22);
            this.btnCancelarCadastroAtividade.Name = "btnCancelarCadastroAtividade";
            this.btnCancelarCadastroAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastroAtividade.TabIndex = 2;
            this.btnCancelarCadastroAtividade.Text = "Cancelar";
            this.btnCancelarCadastroAtividade.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroAtividade.Click += new System.EventHandler(this.btnCancelarCadastroAtividade_Click);
            // 
            // btnNovaAtividade
            // 
            this.btnNovaAtividade.Location = new System.Drawing.Point(36, 100);
            this.btnNovaAtividade.Name = "btnNovaAtividade";
            this.btnNovaAtividade.Size = new System.Drawing.Size(119, 23);
            this.btnNovaAtividade.TabIndex = 3;
            this.btnNovaAtividade.Text = "Cadastrar Atividade";
            this.btnNovaAtividade.UseVisualStyleBackColor = true;
            this.btnNovaAtividade.Click += new System.EventHandler(this.btnNovaAtividade_Click);
            // 
            // atividadeModelsDataGridView
            // 
            this.atividadeModelsDataGridView.AllowUserToAddRows = false;
            this.atividadeModelsDataGridView.AllowUserToDeleteRows = false;
            this.atividadeModelsDataGridView.AllowUserToOrderColumns = true;
            this.atividadeModelsDataGridView.AutoGenerateColumns = false;
            this.atividadeModelsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.atividadeModelsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.atividadeModelsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.atividadeModelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadeModelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.atividadeModelsDataGridView.DataSource = this.atividadeModelsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.atividadeModelsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.atividadeModelsDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.atividadeModelsDataGridView.Location = new System.Drawing.Point(36, 216);
            this.atividadeModelsDataGridView.Name = "atividadeModelsDataGridView";
            this.atividadeModelsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.atividadeModelsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.atividadeModelsDataGridView.RowHeadersVisible = false;
            this.atividadeModelsDataGridView.Size = new System.Drawing.Size(726, 220);
            this.atividadeModelsDataGridView.TabIndex = 4;
            // 
            // atividadeModelsBindingSource
            // 
            this.atividadeModelsBindingSource.DataSource = typeof(Models.AtividadeModels);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Atividade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnListarAtividade
            // 
            this.btnListarAtividade.Location = new System.Drawing.Point(36, 187);
            this.btnListarAtividade.Name = "btnListarAtividade";
            this.btnListarAtividade.Size = new System.Drawing.Size(119, 23);
            this.btnListarAtividade.TabIndex = 5;
            this.btnListarAtividade.Text = "Listar Atividade";
            this.btnListarAtividade.UseVisualStyleBackColor = true;
            this.btnListarAtividade.Click += new System.EventHandler(this.btnListarAtividade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição da atividade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Atividade";
            // 
            // txtTurma
            // 
            this.txtTurma.Enabled = false;
            this.txtTurma.Location = new System.Drawing.Point(36, 65);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(119, 20);
            this.txtTurma.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turma";
            // 
            // FormAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListarAtividade);
            this.Controls.Add(this.atividadeModelsDataGridView);
            this.Controls.Add(this.btnNovaAtividade);
            this.Controls.Add(this.groupBoxCadastrarAtividade);
            this.Name = "FormAtividade";
            this.Text = "FormAtividade";
            this.Load += new System.EventHandler(this.FormAtividade_Load);
            this.groupBoxCadastrarAtividade.ResumeLayout(false);
            this.groupBoxCadastrarAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeModelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastrarAtividade;
        private System.Windows.Forms.TextBox txtDescricaoAtividade;
        private System.Windows.Forms.Button btnCancelarCadastroAtividade;
        private System.Windows.Forms.Button btnSalvarAtividade;
        private System.Windows.Forms.Button btnNovaAtividade;
        private System.Windows.Forms.BindingSource atividadeModelsBindingSource;
        private System.Windows.Forms.DataGridView atividadeModelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnListarAtividade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label3;
    }
}