namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    partial class FormularioSubcategoriaProducto
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.contador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.panBuscarCategoria = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrarPanel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.datosCategoria = new System.Windows.Forms.DataGridView();
            this.txtFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubcategoria = new System.Windows.Forms.TextBox();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.tabMantenimiento.SuspendLayout();
            this.panBuscarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.agregar;
            this.btnCrear.Location = new System.Drawing.Point(434, 489);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(80, 80);
            this.btnCrear.TabIndex = 25;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.editar;
            this.btnActualizar.Location = new System.Drawing.Point(520, 489);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 80);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(606, 489);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 80);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.adjuntar;
            this.btnReporte.Location = new System.Drawing.Point(692, 489);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(80, 80);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabConsulta);
            this.tabControl.Controls.Add(this.tabMantenimiento);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 471);
            this.tabControl.TabIndex = 26;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.contador);
            this.tabConsulta.Controls.Add(this.label2);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.txtFiltro);
            this.tabConsulta.Controls.Add(this.tablaDatos);
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(752, 442);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.Location = new System.Drawing.Point(179, 9);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(82, 16);
            this.contador.TabIndex = 6;
            this.contador.Text = "Cargando...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subcategorías registradas:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(596, 6);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(150, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Location = new System.Drawing.Point(6, 34);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(740, 402);
            this.tablaDatos.TabIndex = 1;
            this.tablaDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaDatos_CellFormatting);
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.panBuscarCategoria);
            this.tabMantenimiento.Controls.Add(this.btnBuscarCategoria);
            this.tabMantenimiento.Controls.Add(this.label5);
            this.tabMantenimiento.Controls.Add(this.txtCategoria);
            this.tabMantenimiento.Controls.Add(this.btnRetornar);
            this.tabMantenimiento.Controls.Add(this.btnGuardar);
            this.tabMantenimiento.Controls.Add(this.btnCancelar);
            this.tabMantenimiento.Controls.Add(this.label4);
            this.tabMantenimiento.Controls.Add(this.txtSubcategoria);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(752, 442);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // panBuscarCategoria
            // 
            this.panBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBuscarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.panBuscarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBuscarCategoria.Controls.Add(this.label7);
            this.panBuscarCategoria.Controls.Add(this.btnCerrarPanel);
            this.panBuscarCategoria.Controls.Add(this.label6);
            this.panBuscarCategoria.Controls.Add(this.datosCategoria);
            this.panBuscarCategoria.Controls.Add(this.txtFiltrarCategoria);
            this.panBuscarCategoria.Location = new System.Drawing.Point(302, 17);
            this.panBuscarCategoria.Name = "panBuscarCategoria";
            this.panBuscarCategoria.Size = new System.Drawing.Size(440, 408);
            this.panBuscarCategoria.TabIndex = 25;
            this.panBuscarCategoria.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filtrar:";
            // 
            // btnCerrarPanel
            // 
            this.btnCerrarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPanel.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.cancelar;
            this.btnCerrarPanel.Location = new System.Drawing.Point(398, 14);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(27, 27);
            this.btnCerrarPanel.TabIndex = 12;
            this.btnCerrarPanel.UseVisualStyleBackColor = true;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Listado de categorías disponibles:";
            // 
            // datosCategoria
            // 
            this.datosCategoria.AllowUserToAddRows = false;
            this.datosCategoria.AllowUserToDeleteRows = false;
            this.datosCategoria.AllowUserToOrderColumns = true;
            this.datosCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datosCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosCategoria.Location = new System.Drawing.Point(13, 69);
            this.datosCategoria.Name = "datosCategoria";
            this.datosCategoria.ReadOnly = true;
            this.datosCategoria.Size = new System.Drawing.Size(412, 323);
            this.datosCategoria.TabIndex = 11;
            this.datosCategoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datosCategoria_CellFormatting);
            // 
            // txtFiltrarCategoria
            // 
            this.txtFiltrarCategoria.BackColor = System.Drawing.Color.White;
            this.txtFiltrarCategoria.Location = new System.Drawing.Point(60, 16);
            this.txtFiltrarCategoria.Name = "txtFiltrarCategoria";
            this.txtFiltrarCategoria.Size = new System.Drawing.Size(170, 23);
            this.txtFiltrarCategoria.TabIndex = 11;
            this.txtFiltrarCategoria.TextChanged += new System.EventHandler(this.txtFiltrarCategoria_TextChanged);
            this.txtFiltrarCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrarCategoria_KeyPress);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCategoria.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.buscar;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(206, 45);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(90, 30);
            this.btnBuscarCategoria.TabIndex = 24;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Visible = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Categoría de producto:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Arial", 15F);
            this.txtCategoria.Location = new System.Drawing.Point(14, 43);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(186, 30);
            this.txtCategoria.TabIndex = 22;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.retornar;
            this.btnRetornar.Location = new System.Drawing.Point(206, 152);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(90, 30);
            this.btnRetornar.TabIndex = 21;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(110, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(14, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Subcategoría de producto:";
            // 
            // txtSubcategoria
            // 
            this.txtSubcategoria.Enabled = false;
            this.txtSubcategoria.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSubcategoria.Location = new System.Drawing.Point(14, 116);
            this.txtSubcategoria.Name = "txtSubcategoria";
            this.txtSubcategoria.Size = new System.Drawing.Size(282, 30);
            this.txtSubcategoria.TabIndex = 17;
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarExcel.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.excel;
            this.btnGenerarExcel.Location = new System.Drawing.Point(12, 489);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnGenerarExcel.Size = new System.Drawing.Size(198, 30);
            this.btnGenerarExcel.TabIndex = 27;
            this.btnGenerarExcel.Text = "Exportar en formato Excel";
            this.btnGenerarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerarExcel.UseVisualStyleBackColor = true;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // FormularioSubcategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.btnGenerarExcel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnReporte);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioSubcategoriaProducto";
            this.Text = "FormularioSubcategoria";
            this.Load += new System.EventHandler(this.FormularioSubcategoriaProducto_Load);
            this.tabControl.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.tabMantenimiento.ResumeLayout(false);
            this.tabMantenimiento.PerformLayout();
            this.panBuscarCategoria.ResumeLayout(false);
            this.panBuscarCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.Button btnGenerarExcel;
        private System.Windows.Forms.Panel panBuscarCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCerrarPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView datosCategoria;
        private System.Windows.Forms.TextBox txtFiltrarCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubcategoria;
    }
}