namespace eAgenda.WindowsApp.Modulos.MolDespesa.ColetaDados
{
    partial class FiltroDespesaForm
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
            this.rdbOrdemAlfa = new System.Windows.Forms.RadioButton();
            this.rdbTodosContatos = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbOrdemAlfa
            // 
            this.rdbOrdemAlfa.AutoSize = true;
            this.rdbOrdemAlfa.Location = new System.Drawing.Point(13, 55);
            this.rdbOrdemAlfa.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOrdemAlfa.Name = "rdbOrdemAlfa";
            this.rdbOrdemAlfa.Size = new System.Drawing.Size(244, 20);
            this.rdbOrdemAlfa.TabIndex = 14;
            this.rdbOrdemAlfa.TabStop = true;
            this.rdbOrdemAlfa.Text = "Visualizar contatos ordem alfabetica";
            this.rdbOrdemAlfa.UseVisualStyleBackColor = true;
            // 
            // rdbTodosContatos
            // 
            this.rdbTodosContatos.AutoSize = true;
            this.rdbTodosContatos.Location = new System.Drawing.Point(13, 13);
            this.rdbTodosContatos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTodosContatos.Name = "rdbTodosContatos";
            this.rdbTodosContatos.Size = new System.Drawing.Size(195, 20);
            this.rdbTodosContatos.TabIndex = 13;
            this.rdbTodosContatos.TabStop = true;
            this.rdbTodosContatos.Text = "Visualizar todos os contatos";
            this.rdbTodosContatos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(345, 215);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(237, 215);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 11;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // FiltroDespesaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 255);
            this.Controls.Add(this.rdbOrdemAlfa);
            this.Controls.Add(this.rdbTodosContatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "FiltroDespesaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros de Despesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbOrdemAlfa;
        private System.Windows.Forms.RadioButton rdbTodosContatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}