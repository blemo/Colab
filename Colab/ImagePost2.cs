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
    public partial class ImagePost2 : Form
    {
        public ImagePost2()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            textBoxBrowse.Text = "johns-image2.jpeg";
            pictureBoxPreview.BackgroundImage = Colab.Properties.Resources.johns_image;
            pictureBoxPreview.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            JohnHomePost2_1 foo = new JohnHomePost2_1();
            foo.Visible = true;
            this.Close();
        }
    }
}
