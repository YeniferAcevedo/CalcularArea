using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double radio = Double.Parse(txtradio.Text);
            Double area = 0;

            area = Math.PI * radio * radio;

            lblresultado.Text = Convert.ToString(area);

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtradio.Text = String.Empty;
            lblresultado.Text = "0";
            txtradio.Focus();
        }
    }
}
