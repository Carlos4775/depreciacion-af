using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciacionAF
{
    public partial class FrmDepreciacion : Form
    {
        public FrmDepreciacion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double CostoActivo = 0;
            double ValorResidual = 0;
            int VidaUtilActivo;
            double GastoAnual = 0;

            try
            {
                CostoActivo = double.Parse(txtCostoActivo.Text);
                ValorResidual = double.Parse(txtValorResidual.Text);
                VidaUtilActivo = int.Parse(txtVidaUtil.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe introducir caracteres validos. " + ex.Message);
                return;
            }

            GastoAnual = (CostoActivo - ValorResidual) / VidaUtilActivo;
            txtGastoAnual.Text = GastoAnual.ToString("#,###,##0.00");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtCostoActivo.Clear();
                txtValorResidual.Clear();
                txtVidaUtil.Clear();
                txtGastoAnual.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar resultados. " + ex.Message);
            }
        }
    }
}
