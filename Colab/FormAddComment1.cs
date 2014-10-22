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
    public partial class FormAddComment1 : Form
    {
        public FormAddComment1()
        {
            InitializeComponent();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            this.Close();
            JohnHomePost1_3 foo = new JohnHomePost1_3();
            foo.Visible = true;
        }
    }
}
