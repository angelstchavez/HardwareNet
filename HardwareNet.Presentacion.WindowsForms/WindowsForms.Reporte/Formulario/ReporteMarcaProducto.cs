using System;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Reporte.Formulario
{
    public partial class ReporteMarcaProducto : Form
    {
        public ReporteMarcaProducto()
        {
            InitializeComponent();
        }

        private void ReporteMarcaProducto_Load(object sender, EventArgs e)
        {
            NombrarFormulario("marcas");
            this.reportViewer1.RefreshReport();
        }

        #region Variables

        #endregion

        #region Eventos del formulario

        #endregion

        #region Funciones

        private void NombrarFormulario(string nombreReporte)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Asignar el título con la fecha actual al control Label
            this.Text = $"Reporte de {nombreReporte}: " + fechaActual.ToString("dd/MM/yyyy");
        }

        #endregion
    }
}
