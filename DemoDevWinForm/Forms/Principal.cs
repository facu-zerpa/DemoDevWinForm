using DemoDevWinForm.Logic;
using DemoDevWinForm.Models;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DemoDevWinForm
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            dgvInfracciones.Visible = false;
            lblError.Text = string.Empty;
            lblError.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            lblError.Visible = false;
            Regex regex = new Regex(@"[0-9]");

            if (documento.Length > 0)
            {
                if (!regex.IsMatch(documento))
                {
                    MostrarError("Solo se permite caracteres numericos.");
                    return;
                }

                if (documento.Length != 8)
                {
                    MostrarError("Solo se permite 8 digitos.");
                    return;
                }
            }

            List<Infraccion> listaInfracciones = LogicaInfracciones.GetInfracciones(documento);
            CargarInfracciones(listaInfracciones);
        }

        private void CargarInfracciones(List<Infraccion> listaInfracciones)
        {
            dgvInfracciones.Rows.Clear();
            dgvInfracciones.Refresh();
            if (listaInfracciones.Count != 0)
            {
                dgvInfracciones.Visible = true;
                lblMessage.Visible = false;
                foreach (Infraccion infraccion in listaInfracciones)
                {
                    dgvInfracciones.Rows.Add(
                        infraccion.Id,
                        infraccion.Documento, 
                        infraccion.Fecha.ToShortDateString(), 
                        infraccion.Codigo, 
                        $"${Math.Round(infraccion.Importe, 2)}", 
                        infraccion.FechaPago is null ? "" : Convert.ToDateTime(infraccion.FechaPago).ToShortDateString());
                }
                foreach (DataGridViewRow row in dgvInfracciones.Rows)
                {
                    string fechaPago = row.Cells["FechaPago"].Value.ToString();
                    if (!string.IsNullOrEmpty(fechaPago))
                    {
                        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
                        dataGridViewCellStyle2.Padding = new Padding(0, 0, 1000, 0);
                        row.Cells["Accion"].Style = dataGridViewCellStyle2;
                    }
                    else
                    {
                        row.Cells["Accion"].Value = "Pagar";
                    }
                }
            } 
            else
            {
                dgvInfracciones.Visible = false;
                lblMessage.Visible = true;
            }
        }

        private void MostrarError(string error)
        {
            lblError.Visible = true;
            lblError.Text = error;
        }

        private void dgvInfracciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dgvInfracciones.Columns["Accion"].Index)
            {
                return;
            }

            string id = dgvInfracciones[0, e.RowIndex].Value.ToString();

            bool pagar = LogicaInfracciones.PagarInfraccion(id);
            if (!pagar)
            {
                MessageBox.Show("Ha ocurrido un problema en el pago de la infraccion.");
            }
            else
            {
                MessageBox.Show("Se concreto el pago de la infraccion.");
                List<Infraccion> listaInfracciones = LogicaInfracciones.GetInfracciones("");
                CargarInfracciones(listaInfracciones);
            }
        }
    }
}