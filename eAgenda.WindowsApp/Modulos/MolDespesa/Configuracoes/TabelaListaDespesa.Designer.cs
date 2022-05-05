namespace eAgenda.WindowsApp.Modulos.MolDespesa.Configuracoes
{
    partial class TabelaListaDespesa
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
            this.gridDespesa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDespesa
            // 
            this.gridDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDespesa.Location = new System.Drawing.Point(0, 0);
            this.gridDespesa.Margin = new System.Windows.Forms.Padding(4);
            this.gridDespesa.Name = "gridDespesa";
            this.gridDespesa.RowHeadersWidth = 51;
            this.gridDespesa.Size = new System.Drawing.Size(603, 475);
            this.gridDespesa.TabIndex = 3;
            // 
            // TabelaListaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDespesa);
            this.Name = "TabelaListaDespesa";
            this.Size = new System.Drawing.Size(603, 475);
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDespesa;
    }
}
