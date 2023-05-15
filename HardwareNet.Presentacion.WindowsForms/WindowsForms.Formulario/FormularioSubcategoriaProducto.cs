using SpreadsheetLight;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HardwareNet.Presentacion.WindowsForms.WindowsForms.Formulario
{
    public partial class FormularioSubcategoriaProducto : Form
    {
        public FormularioSubcategoriaProducto()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Eventos
        private void FormularioSubcategoriaProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltrarCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PrepararFormulario(true, true, true, 1, true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PrepararFormulario(true, true, true, 1, true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            panBuscarCategoria.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtSubcategoria.Clear();
            PrepararFormulario(false, false, false, 0, false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtSubcategoria.Clear();
            PrepararFormulario(false, false, false, 0, false);
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            panBuscarCategoria.Visible = false;
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarDatos(txtFiltro, tablaDatos);
        }
        
        private void txtFiltrarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarDatos(txtFiltro, datosCategoria);
        }

        private void datosCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // filas pares
            {
                e.CellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
            else // filas impares
            {
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void tablaDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // filas pares
            {
                e.CellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
            else // filas impares
            {
                e.CellStyle.BackColor = Color.White;
            }
        }

        #endregion

        #region Funciones

        private void FiltrarDatos(TextBox cajaTexto, DataGridView datos)
        {
            try
            {
                string searchText = cajaTexto.Text.Trim();

                // Filtrar los datos en función de la cadena de búsqueda
                datos.CurrentCell = null;
                datos.Rows.Cast<DataGridViewRow>()
                    .ToList()
                    .ForEach(row => row.Visible = string.IsNullOrEmpty(searchText) ||
                        row.Cells.Cast<DataGridViewCell>()
                            .Any(cell => cell.Value != null && cell.Value.ToString().Contains(searchText)));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambiarEstadoBotonesPrincipales(bool estado)
        {
            btnGenerarExcel.Enabled = estado;
            btnCrear.Enabled = estado;
            btnActualizar.Enabled = estado;
            btnEliminar.Enabled = estado;
            btnReporte.Enabled = estado;

            txtFiltro.Enabled = estado;
            tablaDatos.Enabled = estado;
        }

        private void PrepararFormulario
            (
            bool mostrarRetornar,
            bool mostrarGuardarCancelar,
            bool cambiarEstadoBotones,
            int cambiarPagina,
            bool habilitarTexto
            )
        {
            CambiarEstadoBotonesPrincipales(!cambiarEstadoBotones);
            tabControl.SelectedIndex = cambiarPagina;
            txtCategoria.Enabled = habilitarTexto;
            txtSubcategoria.Enabled = habilitarTexto;
            txtCategoria.Focus();

            btnRetornar.Visible = !mostrarRetornar;
            btnBuscarCategoria.Visible = mostrarGuardarCancelar;
            btnCancelar.Visible = mostrarGuardarCancelar;
            btnGuardar.Visible = mostrarGuardarCancelar;
        }

        private void ExportarExcel(DataGridView tablaDatos, string nombreEntidad)
        {
            if (tablaDatos.Rows.Count == 0)
            {
                MessageBox.Show("No existen registros para exportar.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Objeto que permite crear el excel (Se utilizó una librería externa llamada SpreadSheetLigth)
                    SLDocument sL = new SLDocument();

                    //Le da estilos a el archivo excel
                    SLStyle sLStyle = new SLStyle();
                    sLStyle.Font.FontSize = 12;
                    sLStyle.Font.Bold = true;

                    //Recorre las columnas
                    int iColumn = 1;
                    foreach (DataGridViewColumn column in tablaDatos.Columns)
                    {
                        sL.SetCellValue(1, iColumn, column.HeaderText.ToString());
                        sL.SetCellStyle(1, iColumn, sLStyle);
                        iColumn++;
                    }

                    //Recorre las filas
                    int irow = 2;
                    foreach (DataGridViewRow row in tablaDatos.Rows)
                    {
                        sL.SetCellValue(irow, 1, row.Cells[0].Value.ToString());
                        sL.SetCellValue(irow, 2, row.Cells[1].Value.ToString());
                        sL.SetCellValue(irow, 3, row.Cells[2].Value.ToString());
                        sL.SetCellValue(irow, 4, row.Cells[3].Value.ToString());
                        sL.SetCellValue(irow, 5, row.Cells[4].Value.ToString());
                        irow++;
                    }


                    // Establecer el nombre de archivo predeterminado
                    string nombreArchivo = $"{nombreEntidad.ToLower()} - {DateTime.Now.ToString("dd-MM-yyyy hh.mm tt")}.xlsx";
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog
                    {
                        Title = "Guardar archivo",
                        CheckPathExists = true,
                        DefaultExt = "xlsx",
                        Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                        FileName = nombreArchivo
                    };


                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sL.SaveAs(saveFileDialog1.FileName);
                        MessageBox.Show($"Las {nombreEntidad} han sido exportadas exitosamente.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion
    }
}
