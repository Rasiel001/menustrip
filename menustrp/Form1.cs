using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Sergio Dimas.","Acerca de . . .", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rojoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarColor();
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void BorrarColor()
        {
            rojoToolStripMenuItem.Checked=false;
            azulToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked=false;
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked=true;
            label1.Font = new Font("Comic Sans MS", 20, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
