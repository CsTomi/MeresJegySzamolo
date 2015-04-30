using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeresJegySzamolo
{
    
    public partial class frm_meres : Form
    {
        public frm_meres()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anyád IIT!");
            Application.Exit();
        }

        private void mérés1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = false;
            //Index = 1;
            er.Text = "";
            Cim.Text = "Mérés 1 eredményei:";
        }

        private void mérés2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = false;
            //Index = 2;
            er.Text = "";
            Cim.Text = "Mérés 2 eredményei:";
        }

        private void mérés3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = false;
            //Index = 3;
            er.Text = "";
            Cim.Text = "Mérés 3 eredményei:";
        }

        private void mérés4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = true;
            //Index = 4;
            er.Text = "";
            Cim.Text = "Mérés 4 eredményei:";
        }

        private void frm_meres_Load(object sender, EventArgs e)
        {
            m1.Enabled = false;
            m1.Text = "0";
            //Index = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
