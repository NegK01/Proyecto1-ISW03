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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvTablaUsuarios = new System.Windows.Forms.DataGridView();
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
            this.BtnInsertarUsu = new System.Windows.Forms.Button();
            this.BtnModificarUsu = new System.Windows.Forms.Button();
            this.BtnEliminarUsu = new System.Windows.Forms.Button();
            this.TabControlUsuarios = new System.Windows.Forms.TabControl();
            this.TabCrudUsuarios = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PnlFondoRoles = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).BeginInit();
            this.TabControlUsuarios.SuspendLayout();
            this.TabCrudUsuarios.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.DgvTablaUsuarios.Location = new System.Drawing.Point(61, 29);
            this.DgvTablaUsuarios.Name = "DgvTablaUsuarios";
            this.DgvTablaUsuarios.RowTemplate.Height = 28;
            this.DgvTablaUsuarios.Size = new System.Drawing.Size(1008, 469);
            this.DgvTablaUsuarios.TabIndex = 17;
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
            dataGridViewCellStyle2.Format = "....";
            this.Rol.DefaultCellStyle = dataGridViewCellStyle2;
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
            // BtnInsertarUsu
            // 
            this.BtnInsertarUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarUsu.Location = new System.Drawing.Point(597, 506);
            this.BtnInsertarUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInsertarUsu.Name = "BtnInsertarUsu";
            this.BtnInsertarUsu.Size = new System.Drawing.Size(135, 63);
            this.BtnInsertarUsu.TabIndex = 18;
            this.BtnInsertarUsu.Text = "Insertar";
            this.BtnInsertarUsu.UseVisualStyleBackColor = true;
            this.BtnInsertarUsu.Click += new System.EventHandler(this.BtnInsertarUsu_Click);
            // 
            // BtnModificarUsu
            // 
            this.BtnModificarUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarUsu.Location = new System.Drawing.Point(740, 506);
            this.BtnModificarUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModificarUsu.Name = "BtnModificarUsu";
            this.BtnModificarUsu.Size = new System.Drawing.Size(135, 63);
            this.BtnModificarUsu.TabIndex = 19;
            this.BtnModificarUsu.Text = "Actualizar";
            this.BtnModificarUsu.UseVisualStyleBackColor = true;
            this.BtnModificarUsu.Click += new System.EventHandler(this.BtnModificarUsu_Click);
            // 
            // BtnEliminarUsu
            // 
            this.BtnEliminarUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarUsu.Location = new System.Drawing.Point(883, 506);
            this.BtnEliminarUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminarUsu.Name = "BtnEliminarUsu";
            this.BtnEliminarUsu.Size = new System.Drawing.Size(186, 63);
            this.BtnEliminarUsu.TabIndex = 20;
            this.BtnEliminarUsu.Text = "Cambiar estado";
            this.BtnEliminarUsu.UseVisualStyleBackColor = true;
            this.BtnEliminarUsu.Click += new System.EventHandler(this.BtnEliminarUsu_Click);
            // 
            // TabControlUsuarios
            // 
            this.TabControlUsuarios.Controls.Add(this.tabPage2);
            this.TabControlUsuarios.Controls.Add(this.TabCrudUsuarios);
            this.TabControlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.TabControlUsuarios.Name = "TabControlUsuarios";
            this.TabControlUsuarios.SelectedIndex = 0;
            this.TabControlUsuarios.Size = new System.Drawing.Size(1131, 780);
            this.TabControlUsuarios.TabIndex = 21;
            // 
            // TabCrudUsuarios
            // 
            this.TabCrudUsuarios.Controls.Add(this.panel1);
            this.TabCrudUsuarios.Location = new System.Drawing.Point(4, 29);
            this.TabCrudUsuarios.Name = "TabCrudUsuarios";
            this.TabCrudUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.TabCrudUsuarios.Size = new System.Drawing.Size(1123, 747);
            this.TabCrudUsuarios.TabIndex = 0;
            this.TabCrudUsuarios.Text = "Gestion de usuarios";
            this.TabCrudUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PnlFondoRoles);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1123, 747);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion de roles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PnlFondoRoles
            // 
            this.PnlFondoRoles.Location = new System.Drawing.Point(0, 0);
            this.PnlFondoRoles.Name = "PnlFondoRoles";
            this.PnlFondoRoles.Size = new System.Drawing.Size(1124, 751);
            this.PnlFondoRoles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnInsertarUsu);
            this.panel1.Controls.Add(this.DgvTablaUsuarios);
            this.panel1.Controls.Add(this.BtnEliminarUsu);
            this.panel1.Controls.Add(this.BtnModificarUsu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 751);
            this.panel1.TabIndex = 21;
            // 
            // CduUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControlUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CduUsuarios";
            this.Size = new System.Drawing.Size(1131, 780);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).EndInit();
            this.TabControlUsuarios.ResumeLayout(false);
            this.TabCrudUsuarios.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl TabControlUsuarios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TabCrudUsuarios;
        private System.Windows.Forms.Panel PnlFondoRoles;
        private System.Windows.Forms.Panel panel1;
    }
}
