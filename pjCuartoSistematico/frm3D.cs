using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCuartoSistematico
{
    public partial class frm3D : Form
    {
        public frm3D()
        {
            InitializeComponent();
        }

        private void ObtenerDatos()
        {
            int b = int.Parse(txtBase.Text);
            int h = int.Parse(txtAltura.Text);
            int l = int.Parse(txtLado.Text);
            int r = int.Parse(txtRadio.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string op = cboFiguras.Text;
            ObtenerDatos();
            switch (op)
            {
                case "Esfera":

                    Esfera ef = new Esfera();
                    ef.VolumenEsfera = int.Parse(lblVolumen.Text);
                    ef.AreaEsfera = int.Parse(lblArea.Text);
                    break;
                    
                case "Cubo":
                    txtRadio.Enabled = false;
                    Cubo cb = new Cubo();
                    cb.VolumenCubo = int.Parse(lblVolumen.Text);
                    cb.AreaCubo = int.Parse(lblArea.Text);

                    break;

                case "Tetaedro":
                    txtRadio.Enabled = false;
                    Tetraedro tt = new Tetraedro();
                    tt.VolumenTetraedro = int.Parse(lblVolumen.Text);
                    tt.AreaTetraedro = int.Parse(lblArea.Text);
                    break;
            }
        }
    }
}
