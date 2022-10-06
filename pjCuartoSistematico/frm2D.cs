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
    public partial class frm2D : Form
    {
        public frm2D()
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
                case "Circulo":
                    Circulo cr = new Circulo();
                    cr.AreaCirculo = int.Parse(lblArea.Text);
                    cr.PerimetroCirculo = int.Parse(lblPerimetro.Text);
                    
                    break;

                case "Cuadrado":
                    txtRadio.Enabled = false;
                    Cuadrado cd = new Cuadrado();
                    cd.AreaCuadrado = int.Parse(lblArea.Text);
                    cd.VolumenCuadrado = int.Parse(lblPerimetro.Text);

                    break;

                case "Triangulo":
                    txtRadio.Enabled = false;
                    Triangulo tr = new Triangulo();
                    tr.AreaTriangulo = int.Parse(lblArea.Text);
                    tr.PerimetroTriangulo = int.Parse(lblPerimetro.Text);
                    
                    break;
            }
        }
    }
}

