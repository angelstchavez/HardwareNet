using HardwareNet.Entidad;
using System;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioCarga : Form
    {
        public FormularioCarga()
        {
            InitializeComponent();
        }

        #region Variable
        private const double OpacityIncrement = 0.05;
        private const double OpacityDecrement = 0.1;
        private const int ProgressBarMaxValue = 100;
        #endregion

        #region Eventos
        private void FormularioCarga_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Mostrar.Start();
        }

        private void Mostrar_Tick(object sender, EventArgs e)
        {
            //Mostrar gradualmente la ventana
            if (this.Opacity < 1)
            {
                this.Opacity += OpacityIncrement;
            }

            //Incrementar el valor de la barra de progreso
            progressBar.Increment(1);

            //Detener el timer de mostrar y comenzar el de ocultar
            if (progressBar.Value == ProgressBarMaxValue)
            {
                Mostrar.Stop();
                Ocultar.Start();
            }
        }

        private void Ocultar_Tick(object sender, EventArgs e)
        {
            //Desaparecer gradualmente la ventana
            this.Opacity -= OpacityDecrement;
            if (this.Opacity <= 0)
            {
                Ocultar.Stop();
                this.Close();
            }
        }
        #endregion

        #region Funciones
        
        private void BienvenidaEmpleado()
        {

        }
        
        #endregion
    }
}
