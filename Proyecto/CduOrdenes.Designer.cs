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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlOrdenes = new System.Windows.Forms.TabControl();
            this.TabOrdenes = new System.Windows.Forms.TabPage();
            this.BtnCarrito = new System.Windows.Forms.Button();
            this.DgvTablaOrdenes = new System.Windows.Forms.DataGridView();
            this.AgregarO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabDetalles = new System.Windows.Forms.TabPage();
            this.TxtPrecioTotal = new System.Windows.Forms.TextBox();
            this.TxtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCaracteristicas = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SpCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TabCarrito = new System.Windows.Forms.TabPage();
            this.DgvDetalleCarrito = new System.Windows.Forms.DataGridView();
            this.DgvOrdenCarrito = new System.Windows.Forms.DataGridView();
            this.IdOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRetroceder = new System.Windows.Forms.Button();
            this.EliminarDC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUniDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDC = new DataGridViewNumericUpDownColumn.DataGridViewNumericUpDownColumn();
            this.TotalDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControlOrdenes.SuspendLayout();
            this.TabOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaOrdenes)).BeginInit();
            this.TabDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpCantidad)).BeginInit();
            this.TabCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenCarrito)).BeginInit();
            this.TabPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlOrdenes
            // 
            this.TabControlOrdenes.Controls.Add(this.TabOrdenes);
            this.TabControlOrdenes.Controls.Add(this.TabDetalles);
            this.TabControlOrdenes.Controls.Add(this.TabCarrito);
            this.TabControlOrdenes.Controls.Add(this.TabPago);
            this.TabControlOrdenes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlOrdenes.Location = new System.Drawing.Point(0, 0);
            this.TabControlOrdenes.Name = "TabControlOrdenes";
            this.TabControlOrdenes.SelectedIndex = 0;
            this.TabControlOrdenes.Size = new System.Drawing.Size(730, 490);
            this.TabControlOrdenes.TabIndex = 0;
            // 
            // TabOrdenes
            // 
            this.TabOrdenes.Controls.Add(this.BtnCarrito);
            this.TabOrdenes.Controls.Add(this.DgvTablaOrdenes);
            this.TabOrdenes.Location = new System.Drawing.Point(4, 23);
            this.TabOrdenes.Name = "TabOrdenes";
            this.TabOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.TabOrdenes.Size = new System.Drawing.Size(722, 463);
            this.TabOrdenes.TabIndex = 0;
            this.TabOrdenes.Text = "Ordenes";
            this.TabOrdenes.UseVisualStyleBackColor = true;
            // 
            // BtnCarrito
            // 
            this.BtnCarrito.Location = new System.Drawing.Point(620, 36);
            this.BtnCarrito.Name = "BtnCarrito";
            this.BtnCarrito.Size = new System.Drawing.Size(82, 34);
            this.BtnCarrito.TabIndex = 1;
            this.BtnCarrito.Text = "Tu carrito";
            this.BtnCarrito.UseVisualStyleBackColor = true;
            this.BtnCarrito.Click += new System.EventHandler(this.BtnCarrito_Click);
            // 
            // DgvTablaOrdenes
            // 
            this.DgvTablaOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgregarO,
            this.IdO,
            this.NombreO,
            this.PrecioO,
            this.FechaO});
            this.DgvTablaOrdenes.Location = new System.Drawing.Point(20, 76);
            this.DgvTablaOrdenes.Name = "DgvTablaOrdenes";
            this.DgvTablaOrdenes.Size = new System.Drawing.Size(682, 342);
            this.DgvTablaOrdenes.TabIndex = 0;
            this.DgvTablaOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTablaOrdenes_CellContentClick);
            // 
            // AgregarO
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarO.DefaultCellStyle = dataGridViewCellStyle12;
            this.AgregarO.FillWeight = 30F;
            this.AgregarO.HeaderText = "";
            this.AgregarO.Name = "AgregarO";
            // 
            // IdO
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdO.DefaultCellStyle = dataGridViewCellStyle13;
            this.IdO.HeaderText = "Codigo";
            this.IdO.Name = "IdO";
            // 
            // NombreO
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreO.DefaultCellStyle = dataGridViewCellStyle14;
            this.NombreO.HeaderText = "Nombre";
            this.NombreO.Name = "NombreO";
            // 
            // PrecioO
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioO.DefaultCellStyle = dataGridViewCellStyle15;
            this.PrecioO.HeaderText = "Precio";
            this.PrecioO.Name = "PrecioO";
            // 
            // FechaO
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaO.DefaultCellStyle = dataGridViewCellStyle16;
            this.FechaO.HeaderText = "Fecha de expiracion";
            this.FechaO.Name = "FechaO";
            // 
            // TabDetalles
            // 
            this.TabDetalles.Controls.Add(this.TxtPrecioTotal);
            this.TabDetalles.Controls.Add(this.TxtPrecioUnidad);
            this.TabDetalles.Controls.Add(this.TxtFecha);
            this.TabDetalles.Controls.Add(this.TxtDescripcion);
            this.TabDetalles.Controls.Add(this.TxtCaracteristicas);
            this.TabDetalles.Controls.Add(this.TxtNombre);
            this.TabDetalles.Controls.Add(this.TxtCodigo);
            this.TabDetalles.Controls.Add(this.label9);
            this.TabDetalles.Controls.Add(this.SpCantidad);
            this.TabDetalles.Controls.Add(this.label8);
            this.TabDetalles.Controls.Add(this.label4);
            this.TabDetalles.Controls.Add(this.label5);
            this.TabDetalles.Controls.Add(this.label6);
            this.TabDetalles.Controls.Add(this.label3);
            this.TabDetalles.Controls.Add(this.label2);
            this.TabDetalles.Controls.Add(this.label1);
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
            // TxtPrecioTotal
            // 
            this.TxtPrecioTotal.Location = new System.Drawing.Point(219, 279);
            this.TxtPrecioTotal.Name = "TxtPrecioTotal";
            this.TxtPrecioTotal.Size = new System.Drawing.Size(191, 22);
            this.TxtPrecioTotal.TabIndex = 19;
            // 
            // TxtPrecioUnidad
            // 
            this.TxtPrecioUnidad.Location = new System.Drawing.Point(219, 238);
            this.TxtPrecioUnidad.Name = "TxtPrecioUnidad";
            this.TxtPrecioUnidad.Size = new System.Drawing.Size(191, 22);
            this.TxtPrecioUnidad.TabIndex = 18;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(219, 197);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(191, 22);
            this.TxtFecha.TabIndex = 17;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(219, 156);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(382, 22);
            this.TxtDescripcion.TabIndex = 16;
            // 
            // TxtCaracteristicas
            // 
            this.TxtCaracteristicas.Location = new System.Drawing.Point(219, 115);
            this.TxtCaracteristicas.Name = "TxtCaracteristicas";
            this.TxtCaracteristicas.Size = new System.Drawing.Size(382, 22);
            this.TxtCaracteristicas.TabIndex = 15;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(219, 74);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(382, 22);
            this.TxtNombre.TabIndex = 13;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(219, 33);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(191, 22);
            this.TxtCodigo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Precio por unidad:";
            // 
            // SpCantidad
            // 
            this.SpCantidad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpCantidad.Location = new System.Drawing.Point(219, 320);
            this.SpCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpCantidad.Name = "SpCantidad";
            this.SpCantidad.Size = new System.Drawing.Size(191, 26);
            this.SpCantidad.TabIndex = 10;
            this.SpCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpCantidad.Click += new System.EventHandler(this.SpCantidad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cantidad de unidades:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha expiracion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caracteristicas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo del producto:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(496, 380);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(184, 37);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar producto";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            // TabCarrito
            // 
            this.TabCarrito.Controls.Add(this.btnPagarCarrito);
            this.TabCarrito.Controls.Add(this.DgvDetalleCarrito);
            this.TabCarrito.Controls.Add(this.DgvOrdenCarrito);
            this.TabCarrito.Controls.Add(this.BtnRetroceder);
            this.TabCarrito.Location = new System.Drawing.Point(4, 23);
            this.TabCarrito.Name = "TabCarrito";
            this.TabCarrito.Padding = new System.Windows.Forms.Padding(3);
            this.TabCarrito.Size = new System.Drawing.Size(722, 463);
            this.TabCarrito.TabIndex = 2;
            this.TabCarrito.Text = "Tu carrito";
            this.TabCarrito.UseVisualStyleBackColor = true;
            // 
            // DgvDetalleCarrito
            // 
            this.DgvDetalleCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalleCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarDC,
            this.IdDC,
            this.NombreDC,
            this.PrecioUniDC,
            this.CantidadDC,
            this.TotalDC});
            this.DgvDetalleCarrito.Location = new System.Drawing.Point(29, 155);
            this.DgvDetalleCarrito.Name = "DgvDetalleCarrito";
            this.DgvDetalleCarrito.Size = new System.Drawing.Size(677, 195);
            this.DgvDetalleCarrito.TabIndex = 3;
            this.DgvDetalleCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleCarrito_CellContentClick);
            this.DgvDetalleCarrito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleCarrito_CellValueChanged);
            // 
            // DgvOrdenCarrito
            // 
            this.DgvOrdenCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrdenCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOC,
            this.NombreOC,
            this.FechaOC,
            this.MontoOC});
            this.DgvOrdenCarrito.Location = new System.Drawing.Point(38, 51);
            this.DgvOrdenCarrito.Name = "DgvOrdenCarrito";
            this.DgvOrdenCarrito.Size = new System.Drawing.Size(668, 72);
            this.DgvOrdenCarrito.TabIndex = 2;
            // 
            // IdOC
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOC.DefaultCellStyle = dataGridViewCellStyle17;
            this.IdOC.HeaderText = "Codigo de orden";
            this.IdOC.Name = "IdOC";
            // 
            // NombreOC
            // 
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreOC.DefaultCellStyle = dataGridViewCellStyle18;
            this.NombreOC.HeaderText = "Nombre del cliente";
            this.NombreOC.Name = "NombreOC";
            // 
            // FechaOC
            // 
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaOC.DefaultCellStyle = dataGridViewCellStyle19;
            this.FechaOC.HeaderText = "Fecha de creacion";
            this.FechaOC.Name = "FechaOC";
            // 
            // MontoOC
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoOC.DefaultCellStyle = dataGridViewCellStyle20;
            this.MontoOC.HeaderText = "Monto Total";
            this.MontoOC.Name = "MontoOC";
            // 
            // BtnRetroceder
            // 
            this.BtnRetroceder.Location = new System.Drawing.Point(29, 380);
            this.BtnRetroceder.Name = "BtnRetroceder";
            this.BtnRetroceder.Size = new System.Drawing.Size(114, 37);
            this.BtnRetroceder.TabIndex = 1;
            this.BtnRetroceder.Text = "Retroceder";
            this.BtnRetroceder.UseVisualStyleBackColor = true;
            this.BtnRetroceder.Click += new System.EventHandler(this.BtnRetroceder_Click);
            // 
            // EliminarDC
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.NullValue = "-";
            this.EliminarDC.DefaultCellStyle = dataGridViewCellStyle11;
            this.EliminarDC.FillWeight = 20F;
            this.EliminarDC.HeaderText = "";
            this.EliminarDC.Name = "EliminarDC";
            // 
            // IdDC
            // 
            this.IdDC.HeaderText = "Codigo";
            this.IdDC.Name = "IdDC";
            // 
            // NombreDC
            // 
            this.NombreDC.HeaderText = "Nombre del producto";
            this.NombreDC.Name = "NombreDC";
            // 
            // PrecioUniDC
            // 
            this.PrecioUniDC.HeaderText = "Precio unitario";
            this.PrecioUniDC.Name = "PrecioUniDC";
            // 
            // CantidadDC
            // 
            this.CantidadDC.HeaderText = "Cantidad de unidades";
            this.CantidadDC.Name = "CantidadDC";
            this.CantidadDC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CantidadDC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TotalDC
            // 
            this.TotalDC.HeaderText = "Total";
            this.TotalDC.Name = "TotalDC";
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
            this.TabDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpCantidad)).EndInit();
            this.TabCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenCarrito)).EndInit();
            this.TabPago.ResumeLayout(false);
            this.TabPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlOrdenes;
        private System.Windows.Forms.TabPage TabOrdenes;
        private System.Windows.Forms.TabPage TabDetalles;
        private System.Windows.Forms.DataGridView DgvTablaOrdenes;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SpCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPrecioTotal;
        private System.Windows.Forms.TextBox TxtPrecioUnidad;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCaracteristicas;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TabCarrito;
        private System.Windows.Forms.Button BtnCarrito;
        private System.Windows.Forms.Button BtnRetroceder;
        private System.Windows.Forms.DataGridView DgvOrdenCarrito;
        private System.Windows.Forms.DataGridView DgvDetalleCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoOC;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaO;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUniDC;
        private DataGridViewNumericUpDownColumn.DataGridViewNumericUpDownColumn CantidadDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDC;
        private System.Windows.Forms.TabPage TabPago;
        private System.Windows.Forms.RadioButton rdbtnTarjetaCredDebit;
        private System.Windows.Forms.RadioButton rdbtnTransferencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkTerminosYCondiciones;
        private System.Windows.Forms.TextBox txtIdOrdenPago;
        private System.Windows.Forms.Button btnFinalizarPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.TextBox txtFechaHoraPago;
        private System.Windows.Forms.Button btnPagarCarrito;
    }
}
