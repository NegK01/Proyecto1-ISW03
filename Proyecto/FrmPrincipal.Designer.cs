namespace Proyecto
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvTablaUsuarios = new System.Windows.Forms.DataGridView();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreoUsu = new System.Windows.Forms.TextBox();
            this.TxtTelefonoUsu = new System.Windows.Forms.TextBox();
            this.TxtNombreUsu = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.CbxRol = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbxRol);
            this.panel1.Controls.Add(this.TxtContraseña);
            this.panel1.Controls.Add(this.DgvTablaUsuarios);
            this.panel1.Controls.Add(this.TxtCiudad);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.TxtCorreoUsu);
            this.panel1.Controls.Add(this.TxtTelefonoUsu);
            this.panel1.Controls.Add(this.TxtNombreUsu);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 472);
            this.panel1.TabIndex = 0;
            // 
            // DgvTablaUsuarios
            // 
            this.DgvTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaUsuarios.Location = new System.Drawing.Point(177, 21);
            this.DgvTablaUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvTablaUsuarios.Name = "DgvTablaUsuarios";
            this.DgvTablaUsuarios.RowTemplate.Height = 28;
            this.DgvTablaUsuarios.Size = new System.Drawing.Size(326, 400);
            this.DgvTablaUsuarios.TabIndex = 6;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(600, 171);
            this.TxtCiudad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(242, 26);
            this.TxtCiudad.TabIndex = 5;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(600, 141);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(242, 26);
            this.TxtDireccion.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(600, 111);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(242, 26);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtCorreoUsu
            // 
            this.TxtCorreoUsu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoUsu.Location = new System.Drawing.Point(600, 81);
            this.TxtCorreoUsu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCorreoUsu.Name = "TxtCorreoUsu";
            this.TxtCorreoUsu.Size = new System.Drawing.Size(242, 26);
            this.TxtCorreoUsu.TabIndex = 2;
            // 
            // TxtTelefonoUsu
            // 
            this.TxtTelefonoUsu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoUsu.Location = new System.Drawing.Point(600, 51);
            this.TxtTelefonoUsu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTelefonoUsu.Name = "TxtTelefonoUsu";
            this.TxtTelefonoUsu.Size = new System.Drawing.Size(242, 26);
            this.TxtTelefonoUsu.TabIndex = 1;
            // 
            // TxtNombreUsu
            // 
            this.TxtNombreUsu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsu.Location = new System.Drawing.Point(600, 21);
            this.TxtNombreUsu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombreUsu.Name = "TxtNombreUsu";
            this.TxtNombreUsu.Size = new System.Drawing.Size(242, 26);
            this.TxtNombreUsu.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(600, 201);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(242, 26);
            this.TxtContraseña.TabIndex = 7;
            // 
            // CbxRol
            // 
            this.CbxRol.FormattingEnabled = true;
            this.CbxRol.Location = new System.Drawing.Point(600, 232);
            this.CbxRol.Name = "CbxRol";
            this.CbxRol.Size = new System.Drawing.Size(242, 21);
            this.CbxRol.TabIndex = 8;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 473);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1072, 664);
            this.MinimumSize = new System.Drawing.Size(911, 512);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCorreoUsu;
        private System.Windows.Forms.TextBox TxtTelefonoUsu;
        private System.Windows.Forms.TextBox TxtNombreUsu;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.DataGridView DgvTablaUsuarios;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.ComboBox CbxRol;
    }
}

