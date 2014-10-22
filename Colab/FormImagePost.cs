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
    public partial class FormImagePost : Form
    {
        public FormImagePost()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            textBoxBrowse.Text = "johns-image.jpeg";
            pictureBoxPreview.BackgroundImage = Colab.Properties.Resources.johns_image1;
            pictureBoxPreview.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            JohnHomePost1 foo = new JohnHomePost1();
            foo.Visible = true;
            this.Close();
        }
    }
}
