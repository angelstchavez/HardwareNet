namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    partial class FormularioControlReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioControlReporte));
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSuministros = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.mensajeInicial = new System.Windows.Forms.Label();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(12, 12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 30);
            this.btnVentas.TabIndex = 13;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnSuministros
            // 
            this.btnSuministros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuministros.Image = ((System.Drawing.Image)(resources.GetObject("btnSuministros.Image")));
            this.btnSuministros.Location = new System.Drawing.Point(93, 12);
            this.btnSuministros.Name = "btnSuministros";
            this.btnSuministros.Size = new System.Drawing.Size(108, 30);
            this.btnSuministros.TabIndex = 12;
            this.btnSuministros.Text = "Suministros";
            this.btnSuministros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuministros.UseVisualStyleBackColor = true;
            this.btnSuministros.Click += new System.EventHandler(this.btnSuministros_Click);
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
            this.mensajeInicial.Text = "Por favor, seleccione una reporte disponible: Ventas o siministros";
            this.mensajeInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormularioControlReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnSuministros);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioControlReporte";
            this.Text = "FormularioReporte";
            this.Load += new System.EventHandler(this.FormularioControlReporte_Load);
            this.panelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSuministros;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label mensajeInicial;
    }
}