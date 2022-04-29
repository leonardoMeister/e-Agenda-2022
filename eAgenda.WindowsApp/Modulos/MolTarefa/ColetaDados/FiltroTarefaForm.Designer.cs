namespace eAgenda.WindowsApp.Modulos.MolTarefa.ColetaDados
{
    partial class FiltroTarefaForm
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
            this.rdbTarefasConcluidas = new System.Windows.Forms.RadioButton();
            this.rdbTarefasPendentes = new System.Windows.Forms.RadioButton();
            this.rdbTodasTarefas = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbTarefasConcluidas
            // 
            this.rdbTarefasConcluidas.AutoSize = true;
            this.rdbTarefasConcluidas.Location = new System.Drawing.Point(27, 107);
            this.rdbTarefasConcluidas.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTarefasConcluidas.Name = "rdbTarefasConcluidas";
            this.rdbTarefasConcluidas.Size = new System.Drawing.Size(253, 20);
            this.rdbTarefasConcluidas.TabIndex = 11;
            this.rdbTarefasConcluidas.TabStop = true;
            this.rdbTarefasConcluidas.Text = "Visualizar somente tarefas concluídas";
            this.rdbTarefasConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbTarefasPendentes
            // 
            this.rdbTarefasPendentes.AutoSize = true;
            this.rdbTarefasPendentes.Location = new System.Drawing.Point(27, 66);
            this.rdbTarefasPendentes.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTarefasPendentes.Name = "rdbTarefasPendentes";
            this.rdbTarefasPendentes.Size = new System.Drawing.Size(252, 20);
            this.rdbTarefasPendentes.TabIndex = 10;
            this.rdbTarefasPendentes.TabStop = true;
            this.rdbTarefasPendentes.Text = "Visualizar somente tarefas pendentes";
            this.rdbTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTodasTarefas
            // 
            this.rdbTodasTarefas.AutoSize = true;
            this.rdbTodasTarefas.Location = new System.Drawing.Point(27, 24);
            this.rdbTodasTarefas.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTodasTarefas.Name = "rdbTodasTarefas";
            this.rdbTodasTarefas.Size = new System.Drawing.Size(191, 20);
            this.rdbTodasTarefas.TabIndex = 9;
            this.rdbTodasTarefas.TabStop = true;
            this.rdbTodasTarefas.Text = "Visualizar todas as Tarefas";
            this.rdbTodasTarefas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(306, 172);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(198, 172);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // FiltroTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 211);
            this.Controls.Add(this.rdbTarefasConcluidas);
            this.Controls.Add(this.rdbTarefasPendentes);
            this.Controls.Add(this.rdbTodasTarefas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "FiltroTarefaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTarefasConcluidas;
        private System.Windows.Forms.RadioButton rdbTarefasPendentes;
        private System.Windows.Forms.RadioButton rdbTodasTarefas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}