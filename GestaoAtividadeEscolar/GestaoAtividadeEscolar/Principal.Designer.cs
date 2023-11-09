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
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Visualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataSource = typeof(Models.Turma);
            // 
            // turmaDataGridView
            // 
            this.turmaDataGridView.AllowUserToAddRows = false;
            this.turmaDataGridView.AllowUserToDeleteRows = false;
            this.turmaDataGridView.AllowUserToOrderColumns = true;
            this.turmaDataGridView.AutoGenerateColumns = false;
            this.turmaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.turmaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turmaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Excluir,
            this.Visualizar});
            this.turmaDataGridView.DataSource = this.turmaBindingSource;
            this.turmaDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.turmaDataGridView.Location = new System.Drawing.Point(71, 177);
            this.turmaDataGridView.Name = "turmaDataGridView";
            this.turmaDataGridView.ReadOnly = true;
            this.turmaDataGridView.RowHeadersVisible = false;
            this.turmaDataGridView.RowHeadersWidth = 51;
            this.turmaDataGridView.RowTemplate.Height = 24;
            this.turmaDataGridView.Size = new System.Drawing.Size(879, 268);
            this.turmaDataGridView.TabIndex = 1;
            this.turmaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.turmaDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Turma";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Excluir.Width = 125;
            // 
            // Visualizar
            // 
            this.Visualizar.HeaderText = "Visualizar";
            this.Visualizar.MinimumWidth = 6;
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.ReadOnly = true;
            this.Visualizar.Width = 125;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(71, 33);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 29);
            this.lblUsuarioLogado.TabIndex = 2;
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Location = new System.Drawing.Point(815, 90);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(135, 39);
            this.btnCadastrarTurma.TabIndex = 3;
            this.btnCadastrarTurma.Text = "Cadastrar turma";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(895, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 33);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.turmaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource turmaBindingSource;
        private System.Windows.Forms.DataGridView turmaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewButtonColumn Visualizar;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Button btnSair;
    }
}

