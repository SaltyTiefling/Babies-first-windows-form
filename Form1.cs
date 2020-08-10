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
            cbFirstCombo.Items.Add("jonas");
            cbFirstCombo.Items.Add("nog eens jonas");
            cbFirstCombo.Items.Add("jonas again");
            cbFirstCombo.Items.Add("jonas wants your lovin\'");
            cbFirstCombo.Items.Add("jonas is bored but in a list woohoo");
            foreach (var item in cbFirstCombo.Items)
            {
                lbFirstListBox.Items.Add(item);
            }
        }

        private void lblMijnLabel_Click(object sender, EventArgs e)
        {

        }

        private void cbFirstCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMijnLabel.Text = cbFirstCombo.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbFirstListBox.Items.Add(tbxNewItem.Text);
            cbFirstCombo.Items.Clear();
            foreach (var item in lbFirstListBox.Items)
            {
                cbFirstCombo.Items.Add(item);
            }
        }

    }
}
