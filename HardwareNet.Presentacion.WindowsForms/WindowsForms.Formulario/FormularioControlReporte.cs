using HardwareNet.Presentacion.WindowsForms.WindowsForms.Reporte.Formulario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioControlReporte : Form
    {
        public FormularioControlReporte()
        {
            InitializeComponent();
        }

        #region Eventos

        private void FormularioControlReporte_Load(object sender, EventArgs e)
        {
            mensajeInicial.Dock = DockStyle.Fill;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(true, btnVentas);
            AbrirNuevoFormulario(new ReporteVenta());
        }

        private void btnSuministros_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(true, btnSuministros);
            AbrirNuevoFormulario(new ReporteSuministro());
        }

        #endregion

        #region Funciones

        private void CambiarEstadoBoton(bool state, Button button)
        {
            List<Button> buttons = new List<Button>
            {
                btnVentas,
                btnSuministros,
            };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                foreach (Button btn in buttons)
                {
                    if (btn != button) { btn.Enabled = state; }
                }
            }
        }

        private void AbrirNuevoFormulario(Form modulo)
        {
            panelBase.Controls.Clear();
            modulo.TopLevel = false;
            modulo.Dock = DockStyle.Fill;
            panelBase.Controls.Add(modulo);
            panelBase.Tag = modulo;
            modulo.Show();
            panelBase.BringToFront();
        }

        #endregion
    }
}
