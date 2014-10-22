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
    public partial class FormSignedUp : Form
    {
        public FormSignedUp(String id)
        {
            InitializeComponent();
            labelSignedUpId.Text = id;
        }

        private void buttonSignedUpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
