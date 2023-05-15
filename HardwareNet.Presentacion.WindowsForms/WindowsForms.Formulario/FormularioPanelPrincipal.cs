using HardwareNet.Entidad;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioPanelPrincipal : Form
    {
        private static Empleado empleadoActual;

        public FormularioPanelPrincipal(Empleado empleado)
        {
            empleadoActual = empleado;
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Eventos

        private void FormularioPanelPrincipal_Load(object sender, System.EventArgs e)
        {
            AbrirNuevoFormulario(new FormularioBase());
            MostrarEmpleadoActual();
        }

        private void FormularioPanelPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verificar si el cierre del formulario fue provocado por una llamada a Application.Exit()
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                // Si la razón del cierre es ApplicationExitCall, salimos de la aplicación sin mostrar el mensaje.
                return;
            }

            // Mostrar un diálogo de confirmación para el usuario antes de salir de la aplicación
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario cancela el cierre, establecer la propiedad Cancel del evento como verdadera para evitar el cierre
            e.Cancel = (dialogResult == DialogResult.No);

            // Si el usuario confirma el cierre, salir de la aplicación
            if (!e.Cancel)
            {
                Application.Exit();
            }
        }

        private void venta_Click(object sender, System.EventArgs e)
        {

        }

        private void compra_Click(object sender, System.EventArgs e)
        {

        }

        private void registro_Click(object sender, System.EventArgs e)
        {

        }

        private void producto_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FormularioControlProducto(), producto, "Gestor de productos");
        }

        private void cliente_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FormularioCliente(), cliente, "Gestor de clientes");
        }

        private void empleado_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FormularioEmpleado(), empleado, "Gestor de empleados");
        }

        private void proveedor_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FormularioControlProveedor(), proveedor, "Gestor de proveedores");
        }

        private void reporte_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FormularioControlReporte(), reporte, "Gestor de reportes");
        }

        private void inicio_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new Formulario.FormularioBase(), inicio, "Menu principal");
        }

        private void sesion_Click(object sender, System.EventArgs e)
        {
            DialogResult respuestaResultante = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuestaResultante == DialogResult.No) { }
            else
            {
                this.Hide();
                FormularioLogin login = new FormularioLogin();
                login.Show();
            }
        }
        
        private void informacion_Click(object sender, System.EventArgs e)
        {
            FormularioInformacion formularioInformacion = new FormularioInformacion();
            formularioInformacion.ShowDialog();
        }
        #endregion

        #region Funciones

        void MostrarEmpleadoActual()
        {
            nombreEmpleadoActual.Text = $"{empleadoActual.InformacionPersonal.PrimerNombre} {empleadoActual.InformacionPersonal.PrimerApellido}";
            nombreRolActual.Text = $"{empleadoActual.RolEmpleado.Nombre}";
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

        private void AbrirModulo(Form panel, Button botonModulo, string titulo)
        {
            //MenuLateral.Visible = false;
            tituloModuloActual.Text = titulo;
            CambiarEstadoBoton(true, botonModulo);
            AbrirNuevoFormulario(panel);
        }

        private void CambiarEstadoBoton(bool state, Button button)
        {
            List<Button> buttons = new List<Button>
            {
                venta,
                compra,
                registro,
                producto,
                cliente,
                empleado,
                proveedor,
                reporte,
                inicio,
                configurar
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

        #endregion
    }
}
