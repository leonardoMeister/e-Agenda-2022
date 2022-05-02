namespace eAgenda.WindowsApp.Modulos.MolCompromisso.ColetaDados
{
    partial class CadastroCompromissoForm
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
            this.radioPresencial = new System.Windows.Forms.RadioButton();
            this.radioOnline = new System.Windows.Forms.RadioButton();
            this.horaConclusao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.horaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateCompromisso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbContato = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.assunto = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPresencial);
            this.groupBox1.Controls.Add(this.radioOnline);
            this.groupBox1.Controls.Add(this.horaConclusao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.labelLocal);
            this.groupBox1.Controls.Add(this.horaInicio);
            this.groupBox1.Controls.Add(this.dateCompromisso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbContato);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAssunto);
            this.groupBox1.Controls.Add(this.assunto);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioPresencial
            // 
            this.radioPresencial.AutoSize = true;
            this.radioPresencial.Checked = true;
            this.radioPresencial.Location = new System.Drawing.Point(341, 34);
            this.radioPresencial.Name = "radioPresencial";
            this.radioPresencial.Size = new System.Drawing.Size(92, 20);
            this.radioPresencial.TabIndex = 52;
            this.radioPresencial.TabStop = true;
            this.radioPresencial.Text = "Presencial";
            this.radioPresencial.UseVisualStyleBackColor = true;
            // 
            // radioOnline
            // 
            this.radioOnline.AutoSize = true;
            this.radioOnline.Location = new System.Drawing.Point(452, 33);
            this.radioOnline.Name = "radioOnline";
            this.radioOnline.Size = new System.Drawing.Size(66, 20);
            this.radioOnline.TabIndex = 51;
            this.radioOnline.Text = "Online";
            this.radioOnline.UseVisualStyleBackColor = true;
            // 
            // horaConclusao
            // 
            this.horaConclusao.CalendarMonthBackground = System.Drawing.Color.DarkSeaGreen;
            this.horaConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaConclusao.Location = new System.Drawing.Point(402, 139);
            this.horaConclusao.Margin = new System.Windows.Forms.Padding(4);
            this.horaConclusao.Name = "horaConclusao";
            this.horaConclusao.ShowUpDown = true;
            this.horaConclusao.Size = new System.Drawing.Size(116, 22);
            this.horaConclusao.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hora Conclusâo:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(103, 68);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(227, 22);
            this.txtEndereco.TabIndex = 48;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(45, 71);
            this.labelLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(40, 16);
            this.labelLocal.TabIndex = 47;
            this.labelLocal.Text = "Local";
            // 
            // horaInicio
            // 
            this.horaInicio.CalendarMonthBackground = System.Drawing.Color.DarkSeaGreen;
            this.horaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicio.Location = new System.Drawing.Point(402, 102);
            this.horaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ShowUpDown = true;
            this.horaInicio.Size = new System.Drawing.Size(116, 22);
            this.horaInicio.TabIndex = 46;
            // 
            // dateCompromisso
            // 
            this.dateCompromisso.CalendarMonthBackground = System.Drawing.Color.DarkSeaGreen;
            this.dateCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompromisso.Location = new System.Drawing.Point(104, 101);
            this.dateCompromisso.Margin = new System.Windows.Forms.Padding(4);
            this.dateCompromisso.Name = "dateCompromisso";
            this.dateCompromisso.Size = new System.Drawing.Size(156, 22);
            this.dateCompromisso.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Hora Inicio:";
            // 
            // cmbContato
            // 
            this.cmbContato.FormattingEnabled = true;
            this.cmbContato.Location = new System.Drawing.Point(104, 137);
            this.cmbContato.Margin = new System.Windows.Forms.Padding(4);
            this.cmbContato.Name = "cmbContato";
            this.cmbContato.Size = new System.Drawing.Size(156, 24);
            this.cmbContato.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Contato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(104, 34);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(196, 22);
            this.txtAssunto.TabIndex = 40;
            // 
            // assunto
            // 
            this.assunto.AutoSize = true;
            this.assunto.Location = new System.Drawing.Point(28, 37);
            this.assunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assunto.Name = "assunto";
            this.assunto.Size = new System.Drawing.Size(55, 16);
            this.assunto.TabIndex = 39;
            this.assunto.Text = "Assunto";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(402, 68);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(79, 22);
            this.txtId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(418, 188);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(310, 188);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 35;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // CadastroCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroCompromissoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de cadastro compromisso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroCompromissoForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOnline;
        private System.Windows.Forms.DateTimePicker horaConclusao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.DateTimePicker horaInicio;
        private System.Windows.Forms.DateTimePicker dateCompromisso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label assunto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.RadioButton radioPresencial;
    }
}