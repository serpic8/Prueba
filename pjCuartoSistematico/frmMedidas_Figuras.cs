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
    public partial class frmMedidas_Figuras : Form
    {
        public frmMedidas_Figuras()
        {
            InitializeComponent();
        }

        private void AformHija(object formHija)
        {
            Form fr = new Form();
            fr.Show();

        }

        private void btn2D_Click(object sender, EventArgs e)
        {
            AformHija(new frm2D());
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            AformHija(new frm3D());
        }
    }
}
