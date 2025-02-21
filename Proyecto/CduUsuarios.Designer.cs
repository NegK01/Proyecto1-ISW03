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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvTablaUsuarios = new System.Windows.Forms.DataGridView();
            this.IdU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraseñaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EstadoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInsertarU = new System.Windows.Forms.Button();
            this.BtnModificarU = new System.Windows.Forms.Button();
            this.BtnEliminarU = new System.Windows.Forms.Button();
            this.TabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PnlFondoRoles = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvTablaRoles = new System.Windows.Forms.DataGridView();
            this.IdR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInsertarR = new System.Windows.Forms.Button();
            this.BtnEliminarR = new System.Windows.Forms.Button();
            this.BtnModificarR = new System.Windows.Forms.Button();
            this.TabCrudUsuarios = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).BeginInit();
            this.TabControlUsuarios.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PnlFondoRoles.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaRoles)).BeginInit();
            this.TabCrudUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvTablaUsuarios
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdU,
            this.CedulaU,
            this.NombreU,
            this.ApellidoU,
            this.CorreoU,
            this.TelefonoU,
            this.DireccionU,
            this.ContraseñaU,
            this.RolU,
            this.EstadoU});
            this.DgvTablaUsuarios.Location = new System.Drawing.Point(30, 19);
            this.DgvTablaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DgvTablaUsuarios.Name = "DgvTablaUsuarios";
            this.DgvTablaUsuarios.RowTemplate.Height = 28;
            this.DgvTablaUsuarios.Size = new System.Drawing.Size(646, 314);
            this.DgvTablaUsuarios.TabIndex = 17;
            // 
            // IdU
            // 
            this.IdU.HeaderText = "ID";
            this.IdU.Name = "IdU";
            // 
            // CedulaU
            // 
            this.CedulaU.HeaderText = "Cedula";
            this.CedulaU.Name = "CedulaU";
            // 
            // NombreU
            // 
            this.NombreU.HeaderText = "Nombre";
            this.NombreU.Name = "NombreU";
            // 
            // ApellidoU
            // 
            this.ApellidoU.HeaderText = "Apellido";
            this.ApellidoU.Name = "ApellidoU";
            // 
            // CorreoU
            // 
            this.CorreoU.HeaderText = "Correo";
            this.CorreoU.Name = "CorreoU";
            // 
            // TelefonoU
            // 
            this.TelefonoU.HeaderText = "Telefono";
            this.TelefonoU.Name = "TelefonoU";
            // 
            // DireccionU
            // 
            this.DireccionU.HeaderText = "Direccion";
            this.DireccionU.Name = "DireccionU";
            // 
            // ContraseñaU
            // 
            this.ContraseñaU.HeaderText = "Contraseña";
            this.ContraseñaU.Name = "ContraseñaU";
            // 
            // RolU
            // 
            dataGridViewCellStyle2.Format = "....";
            this.RolU.DefaultCellStyle = dataGridViewCellStyle2;
            this.RolU.HeaderText = "Tipo de rol";
            this.RolU.Name = "RolU";
            this.RolU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RolU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EstadoU
            // 
            this.EstadoU.HeaderText = "Estado";
            this.EstadoU.Name = "EstadoU";
            this.EstadoU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BtnInsertarU
            // 
            this.BtnInsertarU.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarU.Location = new System.Drawing.Point(210, 338);
            this.BtnInsertarU.Name = "BtnInsertarU";
            this.BtnInsertarU.Size = new System.Drawing.Size(90, 41);
            this.BtnInsertarU.TabIndex = 18;
            this.BtnInsertarU.Text = "Insertar";
            this.BtnInsertarU.UseVisualStyleBackColor = true;
            this.BtnInsertarU.Click += new System.EventHandler(this.BtnInsertarUsu_Click);
            // 
            // BtnModificarU
            // 
            this.BtnModificarU.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarU.Location = new System.Drawing.Point(305, 338);
            this.BtnModificarU.Name = "BtnModificarU";
            this.BtnModificarU.Size = new System.Drawing.Size(90, 41);
            this.BtnModificarU.TabIndex = 19;
            this.BtnModificarU.Text = "Actualizar";
            this.BtnModificarU.UseVisualStyleBackColor = true;
            this.BtnModificarU.Click += new System.EventHandler(this.BtnModificarUsu_Click);
            // 
            // BtnEliminarU
            // 
            this.BtnEliminarU.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarU.Location = new System.Drawing.Point(401, 338);
            this.BtnEliminarU.Name = "BtnEliminarU";
            this.BtnEliminarU.Size = new System.Drawing.Size(124, 41);
            this.BtnEliminarU.TabIndex = 20;
            this.BtnEliminarU.Text = "Cambiar estado";
            this.BtnEliminarU.UseVisualStyleBackColor = true;
            this.BtnEliminarU.Click += new System.EventHandler(this.BtnEliminarUsu_Click);
            // 
            // TabControlUsuarios
            // 
            this.TabControlUsuarios.Controls.Add(this.tabPage2);
            this.TabControlUsuarios.Controls.Add(this.TabCrudUsuarios);
            this.TabControlUsuarios.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.TabControlUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.TabControlUsuarios.Name = "TabControlUsuarios";
            this.TabControlUsuarios.SelectedIndex = 0;
            this.TabControlUsuarios.Size = new System.Drawing.Size(719, 507);
            this.TabControlUsuarios.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PnlFondoRoles);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(711, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion de roles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PnlFondoRoles
            // 
            this.PnlFondoRoles.Controls.Add(this.panel2);
            this.PnlFondoRoles.Location = new System.Drawing.Point(0, 0);
            this.PnlFondoRoles.Margin = new System.Windows.Forms.Padding(2);
            this.PnlFondoRoles.Name = "PnlFondoRoles";
            this.PnlFondoRoles.Size = new System.Drawing.Size(715, 488);
            this.PnlFondoRoles.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DgvTablaRoles);
            this.panel2.Controls.Add(this.BtnInsertarR);
            this.panel2.Controls.Add(this.BtnEliminarR);
            this.panel2.Controls.Add(this.BtnModificarR);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 488);
            this.panel2.TabIndex = 22;
            // 
            // DgvTablaRoles
            // 
            this.DgvTablaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvTablaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdR,
            this.NombreR,
            this.EstadoR});
            this.DgvTablaRoles.Location = new System.Drawing.Point(30, 19);
            this.DgvTablaRoles.Margin = new System.Windows.Forms.Padding(2);
            this.DgvTablaRoles.Name = "DgvTablaRoles";
            this.DgvTablaRoles.RowTemplate.Height = 28;
            this.DgvTablaRoles.Size = new System.Drawing.Size(646, 305);
            this.DgvTablaRoles.TabIndex = 21;
            // 
            // IdR
            // 
            this.IdR.HeaderText = "ID";
            this.IdR.Name = "IdR";
            // 
            // NombreR
            // 
            this.NombreR.HeaderText = "Nombre";
            this.NombreR.Name = "NombreR";
            // 
            // EstadoR
            // 
            this.EstadoR.HeaderText = "Estado";
            this.EstadoR.Name = "EstadoR";
            this.EstadoR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BtnInsertarR
            // 
            this.BtnInsertarR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarR.Location = new System.Drawing.Point(210, 329);
            this.BtnInsertarR.Name = "BtnInsertarR";
            this.BtnInsertarR.Size = new System.Drawing.Size(90, 27);
            this.BtnInsertarR.TabIndex = 18;
            this.BtnInsertarR.Text = "Insertar";
            this.BtnInsertarR.UseVisualStyleBackColor = true;
            this.BtnInsertarR.Click += new System.EventHandler(this.BtnInsertarR_Click);
            // 
            // BtnEliminarR
            // 
            this.BtnEliminarR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarR.Location = new System.Drawing.Point(401, 329);
            this.BtnEliminarR.Name = "BtnEliminarR";
            this.BtnEliminarR.Size = new System.Drawing.Size(124, 27);
            this.BtnEliminarR.TabIndex = 20;
            this.BtnEliminarR.Text = "Cambiar estado";
            this.BtnEliminarR.UseVisualStyleBackColor = true;
            this.BtnEliminarR.Click += new System.EventHandler(this.BtnEliminarR_Click);
            // 
            // BtnModificarR
            // 
            this.BtnModificarR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarR.Location = new System.Drawing.Point(305, 329);
            this.BtnModificarR.Name = "BtnModificarR";
            this.BtnModificarR.Size = new System.Drawing.Size(90, 27);
            this.BtnModificarR.TabIndex = 19;
            this.BtnModificarR.Text = "Actualizar";
            this.BtnModificarR.UseVisualStyleBackColor = true;
            this.BtnModificarR.Click += new System.EventHandler(this.BtnModificarR_Click);
            // 
            // TabCrudUsuarios
            // 
            this.TabCrudUsuarios.Controls.Add(this.panel1);
            this.TabCrudUsuarios.Location = new System.Drawing.Point(4, 23);
            this.TabCrudUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.TabCrudUsuarios.Name = "TabCrudUsuarios";
            this.TabCrudUsuarios.Padding = new System.Windows.Forms.Padding(2);
            this.TabCrudUsuarios.Size = new System.Drawing.Size(711, 480);
            this.TabCrudUsuarios.TabIndex = 0;
            this.TabCrudUsuarios.Text = "Gestion de usuarios";
            this.TabCrudUsuarios.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnInsertarU);
            this.panel1.Controls.Add(this.DgvTablaUsuarios);
            this.panel1.Controls.Add(this.BtnEliminarU);
            this.panel1.Controls.Add(this.BtnModificarU);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 488);
            this.panel1.TabIndex = 21;
            // 
            // CduUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TabControlUsuarios);
            this.Name = "CduUsuarios";
            this.Size = new System.Drawing.Size(719, 507);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).EndInit();
            this.TabControlUsuarios.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.PnlFondoRoles.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaRoles)).EndInit();
            this.TabCrudUsuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvTablaUsuarios;
        private System.Windows.Forms.Button BtnInsertarU;
        private System.Windows.Forms.Button BtnModificarU;
        private System.Windows.Forms.Button BtnEliminarU;
        private System.Windows.Forms.TabControl TabControlUsuarios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TabCrudUsuarios;
        private System.Windows.Forms.Panel PnlFondoRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnInsertarR;
        private System.Windows.Forms.Button BtnEliminarR;
        private System.Windows.Forms.Button BtnModificarR;
        private System.Windows.Forms.DataGridView DgvTablaRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreR;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraseñaU;
        private System.Windows.Forms.DataGridViewComboBoxColumn RolU;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoU;
    }
}
