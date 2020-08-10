using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Babies_first_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnButton1_Click(object sender, EventArgs e)
        {
            if (lblMijnLabel.Text == "hello world")
            {
                lblMijnLabel.Text = "bye cruel world";
            }
            else
            {
                lblMijnLabel.Text = "hello world";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
