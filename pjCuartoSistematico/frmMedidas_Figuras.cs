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

        

        private void btn2D_Click(object sender, EventArgs e)
        {
            Form fr = new frm2D();
            fr.Show();
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            Form fr = new frm3D();
            fr.Show();
        }
    }
}
