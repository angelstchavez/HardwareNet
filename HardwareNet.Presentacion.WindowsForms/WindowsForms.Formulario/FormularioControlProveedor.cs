using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioControlProveedor : Form
    {
        public FormularioControlProveedor()
        {
            InitializeComponent();
        }

        #region Eventos

        private void FormularioControlProveedor_Load(object sender, EventArgs e)
        {
            mensajeInicial.Dock = DockStyle.Fill;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(true, btnProveedores);
            AbrirNuevoFormulario(new Formulario.FormularioProveedor());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(true, btnCategorias);
            AbrirNuevoFormulario(new Formulario.FormularioCategoriaProveedor());
        }

        #endregion

        #region Metodos

        #endregion

        #region Funciones

        private void CambiarEstadoBoton(bool state, Button button)
        {
            List<Button> buttons = new List<Button>
            {
                btnProveedores,
                btnCategorias,
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
