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
    public partial class FormFront : Form
    {
        public FormFront()
        {
            InitializeComponent();
            textBoxFrontLoginStID.Text = "1234";
            textBoxFrontLoginPassword.Text = "john";
        }

        private void buttonFrontLogin_Click(object sender, EventArgs e)
        {
            if (textBoxFrontLoginStID.Text != null && textBoxFrontLoginPassword.Text != null)
            {
                String stID = textBoxFrontLoginStID.Text;
                String password = textBoxFrontLoginPassword.Text;

                if (stID == "1234")
                {
                    if (password == "john")
                    {
                        this.Hide();
                        JohnHome fh = new JohnHome();
                        fh.Visible = true;
                    }

                    else if (password == "john2")
                    {
                        this.Hide();
                        JohnHomePost1_2 foo = new JohnHomePost1_2();
                        foo.Visible = true;
                    }

                    else if (password == "john3")
                    {
                        this.Hide();
                        JohnHomePost2 foo = new JohnHomePost2();
                        foo.Visible = true;
                    }

                    else
                    {
                        this.Hide();
                        HomeExample foo = new HomeExample();
                        foo.Visible = true;
                    }
                }
            }
            


        }

        private void buttonFrontSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxFrontSignStID.Text!= null && textBoxFrontSignBarcode.Text != null)
            {
                String stID = textBoxFrontSignStID.Text;
                String barcode = textBoxFrontSignBarcode.Text;

                FormSignedUp fsu = new FormSignedUp(stID);
                fsu.Visible = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
