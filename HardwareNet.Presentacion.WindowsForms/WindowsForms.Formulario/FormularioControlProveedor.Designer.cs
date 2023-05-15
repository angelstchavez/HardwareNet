﻿namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    partial class FormularioControlProveedor
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
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.mensajeInicial = new System.Windows.Forms.Label();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.proveedores;
            this.btnProveedores.Location = new System.Drawing.Point(12, 12);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(118, 30);
            this.btnProveedores.TabIndex = 13;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Image = global::HardwareNet.Presentacion.WindowsForms.Properties.Resources.categoria_proveedor;
            this.btnCategorias.Location = new System.Drawing.Point(136, 12);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(109, 30);
            this.btnCategorias.TabIndex = 12;
            this.btnCategorias.Text = "Catergorías";
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
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
            this.panelBase.TabIndex = 14;
            // 
            // mensajeInicial
            // 
            this.mensajeInicial.Font = new System.Drawing.Font("Arial", 12F);
            this.mensajeInicial.ForeColor = System.Drawing.Color.Gray;
            this.mensajeInicial.Location = new System.Drawing.Point(283, 18);
            this.mensajeInicial.Name = "mensajeInicial";
            this.mensajeInicial.Size = new System.Drawing.Size(461, 123);
            this.mensajeInicial.TabIndex = 0;
            this.mensajeInicial.Text = "Por favor, seleccione una opción disponible: Proveedores o Categorías";
            this.mensajeInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormularioControlProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnCategorias);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioControlProveedor";
            this.Text = "FormularioControlProveedor";
            this.Load += new System.EventHandler(this.FormularioControlProveedor_Load);
            this.panelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label mensajeInicial;
    }
}