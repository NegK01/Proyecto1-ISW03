namespace Proyecto
{
    partial class CduProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTablaProductos = new System.Windows.Forms.DataGridView();
            this.dgvIdPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdCategoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvIdDistribuidor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvIdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaExpiracion = new DataGridViewDateTimePickerColumn.DataGridViewDateTimePickerColumn();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.btnActualizarPro = new System.Windows.Forms.Button();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.tcProductos = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnActualizarCat = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.dgvTablaCategorias = new System.Windows.Forms.DataGridView();
            this.dgvIdCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdEstadoCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProductos)).BeginInit();
            this.tcProductos.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaProductos
            // 
            this.dgvTablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdPro,
            this.dgvNombreProducto,
            this.dgvPrecio,
            this.dgvCaracteristicas,
            this.dgvDescProducto,
            this.dgvIdCategoria,
            this.dgvIdDistribuidor,
            this.dgvIdEstado,
            this.dgvFechaExpiracion});
            this.dgvTablaProductos.Location = new System.Drawing.Point(16, 35);
            this.dgvTablaProductos.Name = "dgvTablaProductos";
            this.dgvTablaProductos.Size = new System.Drawing.Size(701, 349);
            this.dgvTablaProductos.TabIndex = 0;
            // 
            // dgvIdPro
            // 
            this.dgvIdPro.HeaderText = "Código";
            this.dgvIdPro.Name = "dgvIdPro";
            this.dgvIdPro.ReadOnly = true;
            this.dgvIdPro.Width = 50;
            // 
            // dgvNombreProducto
            // 
            this.dgvNombreProducto.HeaderText = "Nombre";
            this.dgvNombreProducto.Name = "dgvNombreProducto";
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.Width = 50;
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.HeaderText = "Caracteristicas";
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            // 
            // dgvDescProducto
            // 
            this.dgvDescProducto.HeaderText = "Descripción";
            this.dgvDescProducto.Name = "dgvDescProducto";
            // 
            // dgvIdCategoria
            // 
            this.dgvIdCategoria.HeaderText = "Categoria";
            this.dgvIdCategoria.Name = "dgvIdCategoria";
            this.dgvIdCategoria.Width = 50;
            // 
            // dgvIdDistribuidor
            // 
            this.dgvIdDistribuidor.HeaderText = "Distribuidor";
            this.dgvIdDistribuidor.Name = "dgvIdDistribuidor";
            this.dgvIdDistribuidor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdDistribuidor.Width = 50;
            // 
            // dgvIdEstado
            // 
            this.dgvIdEstado.HeaderText = "Estado";
            this.dgvIdEstado.Name = "dgvIdEstado";
            this.dgvIdEstado.ReadOnly = true;
            this.dgvIdEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvIdEstado.Width = 50;
            // 
            // dgvFechaExpiracion
            // 
            this.dgvFechaExpiracion.HeaderText = "Fecha Expiración";
            this.dgvFechaExpiracion.Name = "dgvFechaExpiracion";
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.Location = new System.Drawing.Point(229, 399);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Size = new System.Drawing.Size(92, 39);
            this.btnAgregarPro.TabIndex = 1;
            this.btnAgregarPro.Text = "Agregar";
            this.btnAgregarPro.UseVisualStyleBackColor = true;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // btnActualizarPro
            // 
            this.btnActualizarPro.Location = new System.Drawing.Point(327, 399);
            this.btnActualizarPro.Name = "btnActualizarPro";
            this.btnActualizarPro.Size = new System.Drawing.Size(92, 39);
            this.btnActualizarPro.TabIndex = 2;
            this.btnActualizarPro.Text = "Actualizar";
            this.btnActualizarPro.UseVisualStyleBackColor = true;
            this.btnActualizarPro.Click += new System.EventHandler(this.btnActualizarPro_Click);
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Location = new System.Drawing.Point(425, 399);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(92, 39);
            this.btnEliminarPro.TabIndex = 3;
            this.btnEliminarPro.Text = "Eliminar";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
            // 
            // tcProductos
            // 
            this.tcProductos.Controls.Add(this.tabProductos);
            this.tcProductos.Controls.Add(this.tabCategorias);
            this.tcProductos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProductos.Location = new System.Drawing.Point(3, 3);
            this.tcProductos.Name = "tcProductos";
            this.tcProductos.SelectedIndex = 0;
            this.tcProductos.Size = new System.Drawing.Size(751, 503);
            this.tcProductos.TabIndex = 4;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.btnEliminarPro);
            this.tabProductos.Controls.Add(this.dgvTablaProductos);
            this.tabProductos.Controls.Add(this.btnActualizarPro);
            this.tabProductos.Controls.Add(this.btnAgregarPro);
            this.tabProductos.Location = new System.Drawing.Point(4, 23);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(743, 476);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.btnEliminarCat);
            this.tabCategorias.Controls.Add(this.btnActualizarCat);
            this.tabCategorias.Controls.Add(this.btnAgregarCat);
            this.tabCategorias.Controls.Add(this.dgvTablaCategorias);
            this.tabCategorias.Location = new System.Drawing.Point(4, 23);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategorias.Size = new System.Drawing.Size(743, 476);
            this.tabCategorias.TabIndex = 1;
            this.tabCategorias.Text = "Categorias";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(439, 318);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(92, 35);
            this.btnEliminarCat.TabIndex = 6;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnActualizarCat
            // 
            this.btnActualizarCat.Location = new System.Drawing.Point(341, 318);
            this.btnActualizarCat.Name = "btnActualizarCat";
            this.btnActualizarCat.Size = new System.Drawing.Size(92, 35);
            this.btnActualizarCat.TabIndex = 5;
            this.btnActualizarCat.Text = "Actualizar";
            this.btnActualizarCat.UseVisualStyleBackColor = true;
            this.btnActualizarCat.Click += new System.EventHandler(this.btnActualizarCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(243, 318);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(92, 35);
            this.btnAgregarCat.TabIndex = 4;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // dgvTablaCategorias
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTablaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdCat,
            this.dgvNombreCat,
            this.dgvIdEstadoCat});
            this.dgvTablaCategorias.Location = new System.Drawing.Point(117, 37);
            this.dgvTablaCategorias.Name = "dgvTablaCategorias";
            this.dgvTablaCategorias.Size = new System.Drawing.Size(536, 275);
            this.dgvTablaCategorias.TabIndex = 0;
            // 
            // dgvIdCat
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIdCat.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIdCat.HeaderText = "Código";
            this.dgvIdCat.Name = "dgvIdCat";
            this.dgvIdCat.ReadOnly = true;
            // 
            // dgvNombreCat
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNombreCat.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNombreCat.HeaderText = "Nombre";
            this.dgvNombreCat.Name = "dgvNombreCat";
            // 
            // dgvIdEstadoCat
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIdEstadoCat.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIdEstadoCat.HeaderText = "Estado";
            this.dgvIdEstadoCat.Name = "dgvIdEstadoCat";
            this.dgvIdEstadoCat.ReadOnly = true;
            // 
            // CduProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcProductos);
            this.Name = "CduProductos";
            this.Size = new System.Drawing.Size(754, 506);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProductos)).EndInit();
            this.tcProductos.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaProductos;
        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Button btnActualizarPro;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.TabControl tcProductos;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.DataGridView dgvTablaCategorias;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnActualizarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCaracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescProducto;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvIdCategoria;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvIdDistribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEstado;
        private DataGridViewDateTimePickerColumn.DataGridViewDateTimePickerColumn dgvFechaExpiracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEstadoCat;
    }
}
