﻿namespace GestaoAtividadeEscolar
{
    partial class FormInserirAtividade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuarioLogdo = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNomeAtividade = new System.Windows.Forms.TextBox();
            this.btnInserirAtividade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lblUsuarioLogdo);
            this.groupBox1.Controls.Add(this.lblUsuarioLogado);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 34);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblUsuarioLogdo
            // 
            this.lblUsuarioLogdo.AutoSize = true;
            this.lblUsuarioLogdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogdo.Location = new System.Drawing.Point(10, 11);
            this.lblUsuarioLogdo.Name = "lblUsuarioLogdo";
            this.lblUsuarioLogdo.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioLogdo.TabIndex = 8;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(10, 14);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioLogado.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(727, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Location = new System.Drawing.Point(35, 135);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Size = new System.Drawing.Size(630, 26);
            this.txtNomeAtividade.TabIndex = 5;
            // 
            // btnInserirAtividade
            // 
            this.btnInserirAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAtividade.Location = new System.Drawing.Point(671, 135);
            this.btnInserirAtividade.Name = "btnInserirAtividade";
            this.btnInserirAtividade.Size = new System.Drawing.Size(107, 30);
            this.btnInserirAtividade.TabIndex = 6;
            this.btnInserirAtividade.Text = "Cadastrar";
            this.btnInserirAtividade.UseVisualStyleBackColor = true;
            this.btnInserirAtividade.Click += new System.EventHandler(this.btnInserirAtividade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição do conteúdo";
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.Location = new System.Drawing.Point(31, 67);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(0, 20);
            this.lblNomeTurma.TabIndex = 8;
            // 
            // FormInserirAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.lblNomeTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserirAtividade);
            this.Controls.Add(this.txtNomeAtividade);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInserirAtividade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormInserirAtividade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNomeAtividade;
        private System.Windows.Forms.Button btnInserirAtividade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogdo;
        private System.Windows.Forms.Label lblNomeTurma;
    }
}