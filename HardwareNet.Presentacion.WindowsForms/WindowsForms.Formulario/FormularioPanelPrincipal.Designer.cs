namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    partial class FormularioPanelPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPanelPrincipal));
            this.panelInferior = new System.Windows.Forms.Panel();
            this.nombreRolActual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreEmpleadoActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgRol = new System.Windows.Forms.PictureBox();
            this.imgEmpleado = new System.Windows.Forms.PictureBox();
            this.inicio = new System.Windows.Forms.Button();
            this.configurar = new System.Windows.Forms.Button();
            this.informacion = new System.Windows.Forms.Button();
            this.sesion = new System.Windows.Forms.Button();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.reporte = new System.Windows.Forms.Button();
            this.proveedor = new System.Windows.Forms.Button();
            this.empleado = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.Button();
            this.venta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloModuloActual = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmpleado)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInferior.Controls.Add(this.nombreRolActual);
            this.panelInferior.Controls.Add(this.label4);
            this.panelInferior.Controls.Add(this.nombreEmpleadoActual);
            this.panelInferior.Controls.Add(this.label2);
            this.panelInferior.Controls.Add(this.imgRol);
            this.panelInferior.Controls.Add(this.imgEmpleado);
            this.panelInferior.Controls.Add(this.inicio);
            this.panelInferior.Controls.Add(this.configurar);
            this.panelInferior.Controls.Add(this.informacion);
            this.panelInferior.Controls.Add(this.sesion);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 621);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(984, 40);
            this.panelInferior.TabIndex = 0;
            // 
            // nombreRolActual
            // 
            this.nombreRolActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nombreRolActual.AutoSize = true;
            this.nombreRolActual.Location = new System.Drawing.Point(233, 20);
            this.nombreRolActual.Name = "nombreRolActual";
            this.nombreRolActual.Size = new System.Drawing.Size(82, 16);
            this.nombreRolActual.TabIndex = 23;
            this.nombreRolActual.Text = "Cargando...";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rol del usuario:";
            // 
            // nombreEmpleadoActual
            // 
            this.nombreEmpleadoActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nombreEmpleadoActual.AutoSize = true;
            this.nombreEmpleadoActual.Location = new System.Drawing.Point(37, 20);
            this.nombreEmpleadoActual.Name = "nombreEmpleadoActual";
            this.nombreEmpleadoActual.Size = new System.Drawing.Size(82, 16);
            this.nombreEmpleadoActual.TabIndex = 21;
            this.nombreEmpleadoActual.Text = "Cargando...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usuario actual:";
            // 
            // imgRol
            // 
            this.imgRol.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.rol;
            this.imgRol.Location = new System.Drawing.Point(204, 6);
            this.imgRol.Name = "imgRol";
            this.imgRol.Size = new System.Drawing.Size(28, 28);
            this.imgRol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRol.TabIndex = 19;
            this.imgRol.TabStop = false;
            // 
            // imgEmpleado
            // 
            this.imgEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgEmpleado.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.empleado;
            this.imgEmpleado.Location = new System.Drawing.Point(6, 6);
            this.imgEmpleado.Name = "imgEmpleado";
            this.imgEmpleado.Size = new System.Drawing.Size(28, 28);
            this.imgEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEmpleado.TabIndex = 18;
            this.imgEmpleado.TabStop = false;
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.inicio.Enabled = false;
            this.inicio.FlatAppearance.BorderSize = 0;
            this.inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicio.ForeColor = System.Drawing.Color.White;
            this.inicio.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.inicio;
            this.inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicio.Location = new System.Drawing.Point(824, 0);
            this.inicio.Name = "inicio";
            this.inicio.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.inicio.Size = new System.Drawing.Size(40, 40);
            this.inicio.TabIndex = 17;
            this.inicio.Text = " ";
            this.inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inicio.UseVisualStyleBackColor = false;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // configurar
            // 
            this.configurar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.configurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.configurar.FlatAppearance.BorderSize = 0;
            this.configurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configurar.ForeColor = System.Drawing.Color.White;
            this.configurar.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.configuraciones;
            this.configurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configurar.Location = new System.Drawing.Point(864, 0);
            this.configurar.Name = "configurar";
            this.configurar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.configurar.Size = new System.Drawing.Size(40, 40);
            this.configurar.TabIndex = 16;
            this.configurar.Text = " ";
            this.configurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.configurar.UseVisualStyleBackColor = false;
            // 
            // informacion
            // 
            this.informacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.informacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.informacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.informacion.FlatAppearance.BorderSize = 0;
            this.informacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informacion.ForeColor = System.Drawing.Color.White;
            this.informacion.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.informacion;
            this.informacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informacion.Location = new System.Drawing.Point(904, 0);
            this.informacion.Name = "informacion";
            this.informacion.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.informacion.Size = new System.Drawing.Size(40, 40);
            this.informacion.TabIndex = 24;
            this.informacion.Text = " ";
            this.informacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.informacion.UseVisualStyleBackColor = false;
            this.informacion.Click += new System.EventHandler(this.informacion_Click);
            // 
            // sesion
            // 
            this.sesion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.sesion.FlatAppearance.BorderSize = 0;
            this.sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sesion.ForeColor = System.Drawing.Color.White;
            this.sesion.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.cerrar;
            this.sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sesion.Location = new System.Drawing.Point(944, 0);
            this.sesion.Name = "sesion";
            this.sesion.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sesion.Size = new System.Drawing.Size(40, 40);
            this.sesion.TabIndex = 12;
            this.sesion.Text = " ";
            this.sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sesion.UseVisualStyleBackColor = false;
            this.sesion.Click += new System.EventHandler(this.sesion_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.White;
            this.panelLateral.Controls.Add(this.reporte);
            this.panelLateral.Controls.Add(this.proveedor);
            this.panelLateral.Controls.Add(this.empleado);
            this.panelLateral.Controls.Add(this.cliente);
            this.panelLateral.Controls.Add(this.producto);
            this.panelLateral.Controls.Add(this.registro);
            this.panelLateral.Controls.Add(this.compra);
            this.panelLateral.Controls.Add(this.venta);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 40);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 581);
            this.panelLateral.TabIndex = 1;
            // 
            // reporte
            // 
            this.reporte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.reporte.FlatAppearance.BorderSize = 0;
            this.reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reporte.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.reporte;
            this.reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reporte.Location = new System.Drawing.Point(0, 280);
            this.reporte.Name = "reporte";
            this.reporte.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.reporte.Size = new System.Drawing.Size(200, 40);
            this.reporte.TabIndex = 11;
            this.reporte.Text = " Gestionar reportes";
            this.reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reporte.UseVisualStyleBackColor = false;
            this.reporte.Click += new System.EventHandler(this.reporte_Click);
            // 
            // proveedor
            // 
            this.proveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.proveedor.FlatAppearance.BorderSize = 0;
            this.proveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedor.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.proveedor;
            this.proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedor.Location = new System.Drawing.Point(0, 240);
            this.proveedor.Name = "proveedor";
            this.proveedor.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.proveedor.Size = new System.Drawing.Size(200, 40);
            this.proveedor.TabIndex = 10;
            this.proveedor.Text = " Gestionar proveedores";
            this.proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.proveedor.UseVisualStyleBackColor = false;
            this.proveedor.Click += new System.EventHandler(this.proveedor_Click);
            // 
            // empleado
            // 
            this.empleado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.empleado.FlatAppearance.BorderSize = 0;
            this.empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empleado.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.usuario;
            this.empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empleado.Location = new System.Drawing.Point(0, 200);
            this.empleado.Name = "empleado";
            this.empleado.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.empleado.Size = new System.Drawing.Size(200, 40);
            this.empleado.TabIndex = 9;
            this.empleado.Text = " Gestionar empleados";
            this.empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.empleado.UseVisualStyleBackColor = false;
            this.empleado.Click += new System.EventHandler(this.empleado_Click);
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.cliente.FlatAppearance.BorderSize = 0;
            this.cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cliente.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.cliente;
            this.cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cliente.Location = new System.Drawing.Point(0, 160);
            this.cliente.Name = "cliente";
            this.cliente.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cliente.Size = new System.Drawing.Size(200, 40);
            this.cliente.TabIndex = 8;
            this.cliente.Text = " Gestionar clientes";
            this.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cliente.UseVisualStyleBackColor = false;
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // producto
            // 
            this.producto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.producto.FlatAppearance.BorderSize = 0;
            this.producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.producto.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.producto;
            this.producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.producto.Location = new System.Drawing.Point(0, 120);
            this.producto.Name = "producto";
            this.producto.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.producto.Size = new System.Drawing.Size(200, 40);
            this.producto.TabIndex = 6;
            this.producto.Text = " Gestionar productos";
            this.producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.producto.UseVisualStyleBackColor = false;
            this.producto.Click += new System.EventHandler(this.producto_Click);
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registro.Dock = System.Windows.Forms.DockStyle.Top;
            this.registro.FlatAppearance.BorderSize = 0;
            this.registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registro.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.registro;
            this.registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registro.Location = new System.Drawing.Point(0, 80);
            this.registro.Name = "registro";
            this.registro.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.registro.Size = new System.Drawing.Size(200, 40);
            this.registro.TabIndex = 4;
            this.registro.Text = " Consultar registros";
            this.registro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registro.UseVisualStyleBackColor = false;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // compra
            // 
            this.compra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compra.Dock = System.Windows.Forms.DockStyle.Top;
            this.compra.FlatAppearance.BorderSize = 0;
            this.compra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compra.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.compra;
            this.compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compra.Location = new System.Drawing.Point(0, 40);
            this.compra.Name = "compra";
            this.compra.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.compra.Size = new System.Drawing.Size(200, 40);
            this.compra.TabIndex = 3;
            this.compra.Text = " Realizar suministro";
            this.compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.compra.UseVisualStyleBackColor = false;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // venta
            // 
            this.venta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.venta.FlatAppearance.BorderSize = 0;
            this.venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.venta.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.venta;
            this.venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.venta.Location = new System.Drawing.Point(0, 0);
            this.venta.Name = "venta";
            this.venta.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.venta.Size = new System.Drawing.Size(200, 40);
            this.venta.TabIndex = 2;
            this.venta.Text = " Realizar venta";
            this.venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.venta.UseVisualStyleBackColor = false;
            this.venta.Click += new System.EventHandler(this.venta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tituloModuloActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 40);
            this.panel1.TabIndex = 2;
            // 
            // tituloModuloActual
            // 
            this.tituloModuloActual.AutoSize = true;
            this.tituloModuloActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloModuloActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tituloModuloActual.Location = new System.Drawing.Point(6, 11);
            this.tituloModuloActual.Name = "tituloModuloActual";
            this.tituloModuloActual.Size = new System.Drawing.Size(121, 19);
            this.tituloModuloActual.TabIndex = 1;
            this.tituloModuloActual.Text = "Menú principal";
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(200, 40);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(784, 581);
            this.panelBase.TabIndex = 3;
            // 
            // FormularioPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "FormularioPanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardwareNet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPanelPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPanelPrincipal_Load);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmpleado)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button configurar;
        private System.Windows.Forms.Button sesion;
        private System.Windows.Forms.PictureBox imgRol;
        private System.Windows.Forms.PictureBox imgEmpleado;
        private System.Windows.Forms.Label nombreEmpleadoActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombreRolActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tituloModuloActual;
        private System.Windows.Forms.Button reporte;
        private System.Windows.Forms.Button proveedor;
        private System.Windows.Forms.Button empleado;
        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.Button producto;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.Button venta;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button informacion;
    }
}