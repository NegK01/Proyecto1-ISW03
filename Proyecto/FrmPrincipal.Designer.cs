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
            this.btnDistribuidores = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnExpandirMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnDistribuidores);
            this.panel1.Controls.Add(this.btnOrdenes);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnExpandirMenu);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 477);
            this.panel1.TabIndex = 0;
            // 
            // btnDistribuidores
            // 
            this.btnDistribuidores.Location = new System.Drawing.Point(12, 341);
            this.btnDistribuidores.Name = "btnDistribuidores";
            this.btnDistribuidores.Size = new System.Drawing.Size(157, 28);
            this.btnDistribuidores.TabIndex = 4;
            this.btnDistribuidores.Text = "Distribuidores";
            this.btnDistribuidores.UseVisualStyleBackColor = true;
            this.btnDistribuidores.Click += new System.EventHandler(this.btnDistribuidores_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Location = new System.Drawing.Point(12, 273);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(157, 28);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Órdenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(12, 205);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(157, 28);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(12, 137);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(157, 28);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnExpandirMenu
            // 
            this.btnExpandirMenu.Location = new System.Drawing.Point(126, 3);
            this.btnExpandirMenu.Name = "btnExpandirMenu";
            this.btnExpandirMenu.Size = new System.Drawing.Size(61, 28);
            this.btnExpandirMenu.TabIndex = 0;
            this.btnExpandirMenu.Text = "button1";
            this.btnExpandirMenu.UseVisualStyleBackColor = true;
            this.btnExpandirMenu.Click += new System.EventHandler(this.btnExpandirMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(186, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 477);
            this.panel2.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1072, 664);
            this.MinimumSize = new System.Drawing.Size(911, 512);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExpandirMenu;
        private System.Windows.Forms.Button btnDistribuidores;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
    }
}

