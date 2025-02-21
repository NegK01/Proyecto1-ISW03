namespace Proyecto
{
    partial class CduOrdenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlOrdenes = new System.Windows.Forms.TabControl();
            this.TabOrdenes = new System.Windows.Forms.TabPage();
            this.DgvTablaOrdenes = new System.Windows.Forms.DataGridView();
            this.TabDetalles = new System.Windows.Forms.TabPage();
            this.BotonO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TabControlOrdenes.SuspendLayout();
            this.TabOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaOrdenes)).BeginInit();
            this.TabDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlOrdenes
            // 
            this.TabControlOrdenes.Controls.Add(this.TabOrdenes);
            this.TabControlOrdenes.Controls.Add(this.TabDetalles);
            this.TabControlOrdenes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlOrdenes.Location = new System.Drawing.Point(0, 0);
            this.TabControlOrdenes.Name = "TabControlOrdenes";
            this.TabControlOrdenes.SelectedIndex = 0;
            this.TabControlOrdenes.Size = new System.Drawing.Size(730, 490);
            this.TabControlOrdenes.TabIndex = 0;
            // 
            // TabOrdenes
            // 
            this.TabOrdenes.Controls.Add(this.DgvTablaOrdenes);
            this.TabOrdenes.Location = new System.Drawing.Point(4, 23);
            this.TabOrdenes.Name = "TabOrdenes";
            this.TabOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.TabOrdenes.Size = new System.Drawing.Size(722, 463);
            this.TabOrdenes.TabIndex = 0;
            this.TabOrdenes.Text = "Ordenes";
            this.TabOrdenes.UseVisualStyleBackColor = true;
            // 
            // DgvTablaOrdenes
            // 
            this.DgvTablaOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BotonO,
            this.IdO,
            this.NombreO,
            this.PrecioO,
            this.FechaO});
            this.DgvTablaOrdenes.Location = new System.Drawing.Point(45, 64);
            this.DgvTablaOrdenes.Name = "DgvTablaOrdenes";
            this.DgvTablaOrdenes.Size = new System.Drawing.Size(638, 342);
            this.DgvTablaOrdenes.TabIndex = 0;
            this.DgvTablaOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTablaOrdenes_CellContentClick);
            // 
            // TabDetalles
            // 
            this.TabDetalles.Controls.Add(this.BtnAgregar);
            this.TabDetalles.Controls.Add(this.BtnCancelar);
            this.TabDetalles.Location = new System.Drawing.Point(4, 23);
            this.TabDetalles.Name = "TabDetalles";
            this.TabDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.TabDetalles.Size = new System.Drawing.Size(722, 463);
            this.TabDetalles.TabIndex = 1;
            this.TabDetalles.Text = "Detalles del producto";
            this.TabDetalles.UseVisualStyleBackColor = true;
            // 
            // BotonO
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.NullValue = "Agregar";
            this.BotonO.DefaultCellStyle = dataGridViewCellStyle6;
            this.BotonO.FillWeight = 60F;
            this.BotonO.HeaderText = "";
            this.BotonO.Name = "BotonO";
            // 
            // IdO
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdO.DefaultCellStyle = dataGridViewCellStyle7;
            this.IdO.HeaderText = "Codigo";
            this.IdO.Name = "IdO";
            // 
            // NombreO
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreO.DefaultCellStyle = dataGridViewCellStyle8;
            this.NombreO.HeaderText = "Nombre";
            this.NombreO.Name = "NombreO";
            // 
            // PrecioO
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioO.DefaultCellStyle = dataGridViewCellStyle9;
            this.PrecioO.HeaderText = "Precio";
            this.PrecioO.Name = "PrecioO";
            // 
            // FechaO
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaO.DefaultCellStyle = dataGridViewCellStyle10;
            this.FechaO.HeaderText = "Fecha de expiracion";
            this.FechaO.Name = "FechaO";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(48, 380);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 37);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(496, 380);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(184, 37);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar producto";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // CduOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControlOrdenes);
            this.Name = "CduOrdenes";
            this.Size = new System.Drawing.Size(730, 490);
            this.TabControlOrdenes.ResumeLayout(false);
            this.TabOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaOrdenes)).EndInit();
            this.TabDetalles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlOrdenes;
        private System.Windows.Forms.TabPage TabOrdenes;
        private System.Windows.Forms.TabPage TabDetalles;
        private System.Windows.Forms.DataGridView DgvTablaOrdenes;
        private System.Windows.Forms.DataGridViewButtonColumn BotonO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaO;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}
