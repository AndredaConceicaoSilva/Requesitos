﻿namespace ReqFerramentas
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrequisicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.Location = new System.Drawing.Point(117, 199);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(150, 84);
            this.btnColaboradores.TabIndex = 1;
            this.btnColaboradores.Text = "Gerir Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerir Ferramentas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnrequisicoes
            // 
            this.btnrequisicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequisicoes.Location = new System.Drawing.Point(300, 199);
            this.btnrequisicoes.Name = "btnrequisicoes";
            this.btnrequisicoes.Size = new System.Drawing.Size(150, 84);
            this.btnrequisicoes.TabIndex = 3;
            this.btnrequisicoes.Text = "Gerir Requisições";
            this.btnrequisicoes.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrequisicoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnColaboradores);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnrequisicoes;
    }
}

