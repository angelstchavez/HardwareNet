using HardwareNet.Entidad;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Eventos
        
        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Focus();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            
            empleado.InformacionPersonal = new InformacionPersonal()
            {
                PrimerNombre = "Angel",
                PrimerApellido = "Chavez",
            };

            empleado.RolEmpleado = new RolEmpleado()
            {
                Nombre = "Administrador"
            };

            this.Hide();
            FormularioCarga formularioCarga = new FormularioCarga();
            formularioCarga.ShowDialog();

            FormularioPanelPrincipal dashboard = new FormularioPanelPrincipal(empleado);
            dashboard.Show();
        }

        private void FormularioLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        #endregion

        #region Funciones

        #endregion
    }
}
