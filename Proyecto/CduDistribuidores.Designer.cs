namespace Proyecto
{
    partial class CduDistribuidores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvTablaDistribuidores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaDistribuidores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaDistribuidores
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTablaDistribuidores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTablaDistribuidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaDistribuidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaDistribuidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvNombre,
            this.dgvContacto,
            this.dgvIdEstado});
            this.DgvTablaDistribuidores.Location = new System.Drawing.Point(88, 86);
            this.DgvTablaDistribuidores.Margin = new System.Windows.Forms.Padding(1);
            this.DgvTablaDistribuidores.Name = "DgvTablaDistribuidores";
            this.DgvTablaDistribuidores.RowTemplate.Height = 28;
            this.DgvTablaDistribuidores.Size = new System.Drawing.Size(579, 216);
            this.DgvTablaDistribuidores.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Distribuidor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(250, 316);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 35);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(341, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 35);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(432, 316);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 35);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvId
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvId.HeaderText = "Código";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            // 
            // dgvNombre
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvContacto
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvContacto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContacto.HeaderText = "Contacto";
            this.dgvContacto.Name = "dgvContacto";
            // 
            // dgvIdEstado
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIdEstado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIdEstado.HeaderText = "Estado";
            this.dgvIdEstado.Name = "dgvIdEstado";
            this.dgvIdEstado.ReadOnly = true;
            // 
            // CduDistribuidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvTablaDistribuidores);
            this.Name = "CduDistribuidores";
            this.Size = new System.Drawing.Size(730, 440);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaDistribuidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvTablaDistribuidores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEstado;
    }
}
