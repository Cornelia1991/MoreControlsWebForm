using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreControls
{
    public partial class FrmMoreControls : Form
    {
        public FrmMoreControls()
        {
            InitializeComponent();
        }

        private void HsbNumber_Scroll(object sender, ScrollEventArgs e)
        {
            TxtNumber.Text = HsbNumber.Value.ToString();
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSecondForm_Click(object sender, EventArgs e)
        {
            FrmTwo x = new FrmTwo();
            x.Show();
        }
    }
}
