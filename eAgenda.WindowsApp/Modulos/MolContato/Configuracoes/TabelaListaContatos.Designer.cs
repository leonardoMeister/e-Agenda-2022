namespace eAgenda.WindowsApp.Modulos.MolContato.Configuracoes
{
    partial class TabelaListaContatos
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
            this.gridContato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridContato)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContato
            // 
            this.gridContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContato.Location = new System.Drawing.Point(0, 0);
            this.gridContato.Margin = new System.Windows.Forms.Padding(4);
            this.gridContato.Name = "gridContato";
            this.gridContato.RowHeadersWidth = 51;
            this.gridContato.Size = new System.Drawing.Size(603, 475);
            this.gridContato.TabIndex = 2;
            // 
            // TabelaListaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridContato);
            this.Name = "TabelaListaContatos";
            this.Size = new System.Drawing.Size(603, 475);
            ((System.ComponentModel.ISupportInitialize)(this.gridContato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridContato;
    }
}
