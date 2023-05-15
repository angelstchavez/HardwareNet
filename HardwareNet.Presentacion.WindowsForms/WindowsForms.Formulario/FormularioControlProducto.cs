using System.Collections.Generic;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioControlProducto : Form
    {
        public FormularioControlProducto()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Eventos

        private void FormularioControlCategoria_Load(object sender, System.EventArgs e)
        {
            mensajeInicial.Dock = DockStyle.Fill;
        }

        private void btnCategorias_Click(object sender, System.EventArgs e)
        {
            CambiarEstadoBoton(true, btnCategorias);
            AbrirNuevoFormulario(new FormularioCategoriaProducto());
        }

        private void btnSubCategorias_Click(object sender, System.EventArgs e)
        {
            CambiarEstadoBoton(true, btnSubCategorias);
            AbrirNuevoFormulario(new FormularioSubcategoriaProducto());
        }

        private void btnProductos_Click(object sender, System.EventArgs e)
        {
            CambiarEstadoBoton(true, btnProductos);
            AbrirNuevoFormulario(new FormularioProducto());
        }

        private void btnMarcas_Click(object sender, System.EventArgs e)
        {
            CambiarEstadoBoton(true, btnMarcas);
            AbrirNuevoFormulario(new FormularioMarcaProducto());
        }
        #endregion

        #region Funciones

        private void CambiarEstadoBoton(bool state, Button button)
        {
            List<Button> buttons = new List<Button>
            {
                btnProductos,
                btnCategorias,
                btnSubCategorias,
                btnMarcas
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