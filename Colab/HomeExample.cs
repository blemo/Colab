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
    public partial class HomeExample : Form
    {
        public HomeExample()
        {
            InitializeComponent();
        }

        private void buttonHomeLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FormFront ff = new FormFront();
            ff.Visible = true;
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

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelName.Text = "John Shepard";
            pictureBoxClose.Visible = true;
            pictureBox3.BackgroundImage = Colab.Properties.Resources.johns_image1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            labelCaption.Text = "Any tips?";
            linkLabelComments.Text = "Comments (3)";
            linkLabelShares.Text = "Shares (0)";
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelName.Text = "John Shepard";
            pictureBoxClose.Visible = true;
            pictureBox3.BackgroundImage = Colab.Properties.Resources.johns_image;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            labelCaption.Text = "All finished!! :)";
            linkLabelComments.Text = "Comments (0)";
            linkLabelShares.Text = "Shares (0)";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelName.Text = "Adam Watson";
            pictureBoxClose.Visible = false;
            pictureBox3.BackgroundImage = Colab.Properties.Resources.video;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            labelCaption.Text = "Check it out...";
            linkLabelComments.Text = "Comments (13)";
            linkLabelShares.Text = "Shares (7)";
        }
    }
}
