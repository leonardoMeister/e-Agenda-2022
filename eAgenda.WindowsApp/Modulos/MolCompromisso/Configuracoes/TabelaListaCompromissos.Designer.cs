namespace eAgenda.WindowsApp.Modulos.MolCompromisso.Configuracoes
{
    partial class TabelaListaCompromissos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridCompromisso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromisso)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCompromisso
            // 
            this.gridCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompromisso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCompromisso.Location = new System.Drawing.Point(0, 0);
            this.gridCompromisso.Margin = new System.Windows.Forms.Padding(4);
            this.gridCompromisso.Name = "gridCompromisso";
            this.gridCompromisso.RowHeadersWidth = 51;
            this.gridCompromisso.Size = new System.Drawing.Size(603, 475);
            this.gridCompromisso.TabIndex = 2;
            // 
            // TabelaListaCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCompromisso);
            this.Name = "TabelaListaCompromissos";
            this.Size = new System.Drawing.Size(603, 475);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromisso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCompromisso;
    }
}
