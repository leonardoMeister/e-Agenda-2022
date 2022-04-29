namespace eAgenda.WindowsApp.Modulos.MolTarefa.ColetaDados
{
    partial class CadastroTarefaForm
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
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grupoTarefa = new System.Windows.Forms.GroupBox();
            this.grupoItens = new System.Windows.Forms.GroupBox();
            this.btnRemoverItemLista = new System.Windows.Forms.Button();
            this.btnAdicionarItemLista = new System.Windows.Forms.Button();
            this.labelConcluido = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.cmbStatusConclusão = new System.Windows.Forms.ComboBox();
            this.labelNomeItem = new System.Windows.Forms.Label();
            this.listBoxItens = new System.Windows.Forms.ListBox();
            this.btn_desSelecao = new System.Windows.Forms.Button();
            this.grupoTarefa.SuspendLayout();
            this.grupoItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Location = new System.Drawing.Point(112, 62);
            this.cmbPrioridade.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(132, 24);
            this.cmbPrioridade.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prioridade:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(90, 30);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(327, 22);
            this.txtTitulo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Título:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(454, 31);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 22);
            this.txtId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(547, 414);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(439, 414);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 46);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grupoTarefa
            // 
            this.grupoTarefa.Controls.Add(this.txtTitulo);
            this.grupoTarefa.Controls.Add(this.label1);
            this.grupoTarefa.Controls.Add(this.txtId);
            this.grupoTarefa.Controls.Add(this.label2);
            this.grupoTarefa.Controls.Add(this.label4);
            this.grupoTarefa.Controls.Add(this.cmbPrioridade);
            this.grupoTarefa.Location = new System.Drawing.Point(11, 303);
            this.grupoTarefa.Name = "grupoTarefa";
            this.grupoTarefa.Size = new System.Drawing.Size(635, 104);
            this.grupoTarefa.TabIndex = 29;
            this.grupoTarefa.TabStop = false;
            this.grupoTarefa.Text = "Dados Tarefa";
            // 
            // grupoItens
            // 
            this.grupoItens.Controls.Add(this.btn_desSelecao);
            this.grupoItens.Controls.Add(this.btnRemoverItemLista);
            this.grupoItens.Controls.Add(this.btnAdicionarItemLista);
            this.grupoItens.Controls.Add(this.labelConcluido);
            this.grupoItens.Controls.Add(this.txtNomeItem);
            this.grupoItens.Controls.Add(this.cmbStatusConclusão);
            this.grupoItens.Controls.Add(this.labelNomeItem);
            this.grupoItens.Controls.Add(this.listBoxItens);
            this.grupoItens.Location = new System.Drawing.Point(12, 12);
            this.grupoItens.Name = "grupoItens";
            this.grupoItens.Size = new System.Drawing.Size(635, 285);
            this.grupoItens.TabIndex = 30;
            this.grupoItens.TabStop = false;
            this.grupoItens.Text = "Dados Itens Tarefa";
            // 
            // btnRemoverItemLista
            // 
            this.btnRemoverItemLista.Location = new System.Drawing.Point(493, 151);
            this.btnRemoverItemLista.Name = "btnRemoverItemLista";
            this.btnRemoverItemLista.Size = new System.Drawing.Size(130, 53);
            this.btnRemoverItemLista.TabIndex = 32;
            this.btnRemoverItemLista.Text = "Remover Item";
            this.btnRemoverItemLista.UseVisualStyleBackColor = true;
            this.btnRemoverItemLista.Click += new System.EventHandler(this.btnRemoverItemLista_Click);
            // 
            // btnAdicionarItemLista
            // 
            this.btnAdicionarItemLista.Location = new System.Drawing.Point(493, 82);
            this.btnAdicionarItemLista.Name = "btnAdicionarItemLista";
            this.btnAdicionarItemLista.Size = new System.Drawing.Size(130, 53);
            this.btnAdicionarItemLista.TabIndex = 31;
            this.btnAdicionarItemLista.Text = "Adicionar Item";
            this.btnAdicionarItemLista.UseVisualStyleBackColor = true;
            this.btnAdicionarItemLista.Click += new System.EventHandler(this.btnAdicionarItemLista_Click);
            // 
            // labelConcluido
            // 
            this.labelConcluido.AutoSize = true;
            this.labelConcluido.Location = new System.Drawing.Point(386, 34);
            this.labelConcluido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConcluido.Name = "labelConcluido";
            this.labelConcluido.Size = new System.Drawing.Size(47, 16);
            this.labelConcluido.TabIndex = 29;
            this.labelConcluido.Text = "Status:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(95, 31);
            this.txtNomeItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(251, 22);
            this.txtNomeItem.TabIndex = 29;
            // 
            // cmbStatusConclusão
            // 
            this.cmbStatusConclusão.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusConclusão.FormattingEnabled = true;
            this.cmbStatusConclusão.Items.AddRange(new object[] {
            "Sem Concluir.",
            "Concluido."});
            this.cmbStatusConclusão.Location = new System.Drawing.Point(441, 31);
            this.cmbStatusConclusão.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatusConclusão.Name = "cmbStatusConclusão";
            this.cmbStatusConclusão.Size = new System.Drawing.Size(164, 24);
            this.cmbStatusConclusão.TabIndex = 30;
            // 
            // labelNomeItem
            // 
            this.labelNomeItem.AutoSize = true;
            this.labelNomeItem.Location = new System.Drawing.Point(16, 31);
            this.labelNomeItem.Name = "labelNomeItem";
            this.labelNomeItem.Size = new System.Drawing.Size(72, 16);
            this.labelNomeItem.TabIndex = 1;
            this.labelNomeItem.Text = "Nome Item";
            // 
            // listBoxItens
            // 
            this.listBoxItens.FormattingEnabled = true;
            this.listBoxItens.ItemHeight = 16;
            this.listBoxItens.Location = new System.Drawing.Point(19, 69);
            this.listBoxItens.Name = "listBoxItens";
            this.listBoxItens.Size = new System.Drawing.Size(458, 196);
            this.listBoxItens.TabIndex = 0;
            this.listBoxItens.SelectedValueChanged += new System.EventHandler(this.listBoxItens_SelectedValueChanged);
            // 
            // btn_desSelecao
            // 
            this.btn_desSelecao.Location = new System.Drawing.Point(493, 212);
            this.btn_desSelecao.Name = "btn_desSelecao";
            this.btn_desSelecao.Size = new System.Drawing.Size(130, 53);
            this.btn_desSelecao.TabIndex = 33;
            this.btn_desSelecao.Text = "Limpar Seleção";
            this.btn_desSelecao.UseVisualStyleBackColor = true;
            this.btn_desSelecao.Click += new System.EventHandler(this.btn_desSelecao_Click);
            // 
            // CadastroTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 475);
            this.Controls.Add(this.grupoItens);
            this.Controls.Add(this.grupoTarefa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "CadastroTarefaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Cadastro Tarefa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroTarefaForm_FormClosing);
            this.grupoTarefa.ResumeLayout(false);
            this.grupoTarefa.PerformLayout();
            this.grupoItens.ResumeLayout(false);
            this.grupoItens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grupoTarefa;
        private System.Windows.Forms.GroupBox grupoItens;
        private System.Windows.Forms.Label labelConcluido;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.ComboBox cmbStatusConclusão;
        private System.Windows.Forms.Label labelNomeItem;
        private System.Windows.Forms.ListBox listBoxItens;
        private System.Windows.Forms.Button btnRemoverItemLista;
        private System.Windows.Forms.Button btnAdicionarItemLista;
        private System.Windows.Forms.Button btn_desSelecao;
    }
}