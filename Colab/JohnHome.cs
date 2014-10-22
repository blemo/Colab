using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colab
{
    public partial class JohnHome : Form
    {
        public JohnHome()
        {
            InitializeComponent();
        }

        private void buttonHomeLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FormFront ff = new FormFront();
            ff.Visible = true;
        }

        private void buttonJohnHomeImage_Click(object sender, EventArgs e)
        {
            FormImagePost fip = new FormImagePost();
            fip.Visible = true;
        }

        private void buttonJohnHomePublic_Click(object sender, EventArgs e)
        {
            buttonJohnHomePublic.Enabled = false;
            buttonJohnHomeCGD.Enabled = true;
            buttonJohnHomeEnthus.Enabled = true;
        }

        private void buttonJohnHomeCGD_Click(object sender, EventArgs e)
        {
            buttonJohnHomePublic.Enabled = true;
            buttonJohnHomeCGD.Enabled = false;
            buttonJohnHomeEnthus.Enabled = true;
        }

        private void buttonJohnHomeEnthus_Click(object sender, EventArgs e)
        {
            buttonJohnHomePublic.Enabled = true;
            buttonJohnHomeCGD.Enabled = true;
            buttonJohnHomeEnthus.Enabled = false;
        }
    }
}
