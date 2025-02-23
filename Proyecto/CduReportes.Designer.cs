namespace Proyecto
{
    partial class CduReportes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvTablaReportes = new System.Windows.Forms.DataGridView();
            this.CbxTipoReportes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaReportes
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTablaReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTablaReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTablaReportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTablaReportes.Location = new System.Drawing.Point(54, 171);
            this.DgvTablaReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvTablaReportes.Name = "DgvTablaReportes";
            this.DgvTablaReportes.Size = new System.Drawing.Size(974, 432);
            this.DgvTablaReportes.TabIndex = 0;
            // 
            // CbxTipoReportes
            // 
            this.CbxTipoReportes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoReportes.FormattingEnabled = true;
            this.CbxTipoReportes.Items.AddRange(new object[] {
            "Informacion de ventas por categoria",
            "Informacion de ordenes de usuarios",
            "Item 3"});
            this.CbxTipoReportes.Location = new System.Drawing.Point(54, 128);
            this.CbxTipoReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxTipoReportes.Name = "CbxTipoReportes";
            this.CbxTipoReportes.Size = new System.Drawing.Size(432, 22);
            this.CbxTipoReportes.TabIndex = 1;
            this.CbxTipoReportes.SelectedIndexChanged += new System.EventHandler(this.CbxTipoReportes_SelectedIndexChanged);
            // 
            // CduReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbxTipoReportes);
            this.Controls.Add(this.DgvTablaReportes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CduReportes";
            this.Size = new System.Drawing.Size(1050, 660);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTablaReportes;
        private System.Windows.Forms.ComboBox CbxTipoReportes;
    }
}
