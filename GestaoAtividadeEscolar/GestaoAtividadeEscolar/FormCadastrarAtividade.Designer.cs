namespace GestaoAtividadeEscolar
{
    partial class FormCadastrarAtividade
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            this.txtNomeAtividade = new System.Windows.Forms.TextBox();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atividade";
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(784, 187);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(132, 37);
            this.btnCadastrarAtividade.TabIndex = 1;
            this.btnCadastrarAtividade.Text = "Cadastrar";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = true;
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Location = new System.Drawing.Point(74, 190);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Size = new System.Drawing.Size(678, 34);
            this.txtNomeAtividade.TabIndex = 2;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(62, 34);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(127, 16);
            this.lblUsuarioLogado.TabIndex = 3;
            this.lblUsuarioLogado.Text = "USUARIO LOGADO";
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Location = new System.Drawing.Point(80, 117);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(56, 16);
            this.lblNomeTurma.TabIndex = 4;
            this.lblNomeTurma.Text = "TURMA";
            // 
            // FormCadastrarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.lblNomeTurma);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.txtNomeAtividade);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarAtividade";
            this.Load += new System.EventHandler(this.FormCadastrarAtividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarAtividade;
        private System.Windows.Forms.TextBox txtNomeAtividade;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblNomeTurma;
    }
}