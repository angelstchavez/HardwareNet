namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    partial class FormularioControlProducto
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
            this.panelBase = new System.Windows.Forms.Panel();
            this.mensajeInicial = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnSubCategorias = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelBase.Controls.Add(this.mensajeInicial);
            this.panelBase.Location = new System.Drawing.Point(12, 48);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(760, 521);
            this.panelBase.TabIndex = 9;
            // 
            // mensajeInicial
            // 
            this.mensajeInicial.Font = new System.Drawing.Font("Arial", 12F);
            this.mensajeInicial.ForeColor = System.Drawing.Color.Gray;
            this.mensajeInicial.Location = new System.Drawing.Point(283, 18);
            this.mensajeInicial.Name = "mensajeInicial";
            this.mensajeInicial.Size = new System.Drawing.Size(461, 123);
            this.mensajeInicial.TabIndex = 0;
            this.mensajeInicial.Text = "Por favor, seleccione una opción disponible.";
            this.mensajeInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.producto_pequeño;
            this.btnProductos.Location = new System.Drawing.Point(12, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(98, 30);
            this.btnProductos.TabIndex = 11;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.marca_pequeña;
            this.btnMarcas.Location = new System.Drawing.Point(371, 12);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(82, 30);
            this.btnMarcas.TabIndex = 10;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnSubCategorias
            // 
            this.btnSubCategorias.AllowDrop = true;
            this.btnSubCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubCategorias.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.subcaja;
            this.btnSubCategorias.Location = new System.Drawing.Point(235, 12);
            this.btnSubCategorias.Name = "btnSubCategorias";
            this.btnSubCategorias.Size = new System.Drawing.Size(130, 30);
            this.btnSubCategorias.TabIndex = 8;
            this.btnSubCategorias.Text = "Subcategorias";
            this.btnSubCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubCategorias.UseVisualStyleBackColor = true;
            this.btnSubCategorias.Click += new System.EventHandler(this.btnSubCategorias_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.caja;
            this.btnCategorias.Location = new System.Drawing.Point(116, 12);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(113, 30);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "Catergorías";
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // FormularioControlProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnSubCategorias);
            this.Controls.Add(this.btnCategorias);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioControlProducto";
            this.Text = "FormularioControlCategoria";
            this.Load += new System.EventHandler(this.FormularioControlCategoria_Load);
            this.panelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label mensajeInicial;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnProductos;
    }
}