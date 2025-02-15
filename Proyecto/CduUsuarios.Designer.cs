namespace Proyecto
{
    partial class CduUsuarios
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
            this.DgvTablaUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnInsertarUsu = new System.Windows.Forms.Button();
            this.BtnModificarUsu = new System.Windows.Forms.Button();
            this.BtnEliminarUsu = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaUsuarios
            // 
            this.DgvTablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cedula,
            this.Nombre,
            this.Apellido,
            this.Correo,
            this.Telefono,
            this.Direccion,
            this.Contraseña,
            this.Rol,
            this.Estado});
            this.DgvTablaUsuarios.Location = new System.Drawing.Point(34, 54);
            this.DgvTablaUsuarios.Name = "DgvTablaUsuarios";
            this.DgvTablaUsuarios.RowTemplate.Height = 28;
            this.DgvTablaUsuarios.Size = new System.Drawing.Size(1013, 469);
            this.DgvTablaUsuarios.TabIndex = 17;
            // 
            // BtnInsertarUsu
            // 
            this.BtnInsertarUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarUsu.Location = new System.Drawing.Point(567, 558);
            this.BtnInsertarUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInsertarUsu.Name = "BtnInsertarUsu";
            this.BtnInsertarUsu.Size = new System.Drawing.Size(135, 63);
            this.BtnInsertarUsu.TabIndex = 18;
            this.BtnInsertarUsu.Text = "Insertar";
            this.BtnInsertarUsu.UseVisualStyleBackColor = true;
            // 
            // BtnModificarUsu
            // 
            this.BtnModificarUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarUsu.Location = new System.Drawing.Point(717, 558);
            this.BtnModificarUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModificarUsu.Name = "BtnModificarUsu";
            this.BtnModificarUsu.Size = new System.Drawing.Size(135, 63);
            this.BtnModificarUsu.TabIndex = 19;
            this.BtnModificarUsu.Text = "Modificar";
            this.BtnModificarUsu.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarUsu
            // 
            this.BtnEliminarUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarUsu.Location = new System.Drawing.Point(861, 558);
            this.BtnEliminarUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminarUsu.Name = "BtnEliminarUsu";
            this.BtnEliminarUsu.Size = new System.Drawing.Size(186, 63);
            this.BtnEliminarUsu.TabIndex = 20;
            this.BtnEliminarUsu.Text = "Cambiar estado";
            this.BtnEliminarUsu.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            // 
            // Rol
            // 
            dataGridViewCellStyle1.Format = "....";
            this.Rol.DefaultCellStyle = dataGridViewCellStyle1;
            this.Rol.HeaderText = "Tipo de rol";
            this.Rol.Name = "Rol";
            this.Rol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CduUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEliminarUsu);
            this.Controls.Add(this.BtnModificarUsu);
            this.Controls.Add(this.BtnInsertarUsu);
            this.Controls.Add(this.DgvTablaUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CduUsuarios";
            this.Size = new System.Drawing.Size(1131, 780);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvTablaUsuarios;
        private System.Windows.Forms.Button BtnInsertarUsu;
        private System.Windows.Forms.Button BtnModificarUsu;
        private System.Windows.Forms.Button BtnEliminarUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
