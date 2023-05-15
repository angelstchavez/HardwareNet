using System;
using System.Globalization;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Eventos
        private void FormularioBase_Load(object sender, EventArgs e)
        {
            MostrarSaludo(labelSaludo, pictureSaludo);
        }
        private void ControlFechaHora_Tick(object sender, EventArgs e)
        {
            TxHora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            TxFecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region Funciones
        public void MostrarSaludo(Label labelSaludo, PictureBox pictureBoxIcono)
        {
            DateTime horaActual = DateTime.Now;
            int hora = horaActual.Hour;
            int minuto = horaActual.Minute;

            if (hora >= 6 && hora < 9)
            {
                labelSaludo.Text = "Buenos días";
                pictureBoxIcono.Image = Properties.Resources.icono_buenos_dias;
            }
            else if (hora == 9 && minuto < 30)
            {
                labelSaludo.Text = "Buenos días";
                pictureBoxIcono.Image = Properties.Resources.icono_buenos_dias;
            }
            else if (hora == 9 && minuto >= 30 || hora == 10 || hora == 11 && minuto < 59)
            {
                labelSaludo.Text = "Buenos días y buen provecho";
                pictureBoxIcono.Image = Properties.Resources.icono_buenos_dias_y_buen_provecho;
            }
            else if (hora >= 12 && hora < 20)
            {
                labelSaludo.Text = "Buenas tardes";
                pictureBoxIcono.Image = Properties.Resources.icono_buenas_tardes;
            }
            else
            {
                labelSaludo.Text = "Buenas noches";
                pictureBoxIcono.Image = Properties.Resources.icono_buenas_noches;
            }
        }
        #endregion
    }
}
