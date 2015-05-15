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
        private JegyController Kontrol;
        public frm_meres()
        {
            Kontrol = JegyController.Instance;
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mérés1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = false;
            er.Text = "";
            Cim.Text = "Mérés 1 eredményei:";
            Kontrol.MeresIndex = 1;
        }

        private void mérés2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = false;
            er.Text = "";
            Cim.Text = "Mérés 2 eredményei:";
            Kontrol.MeresIndex = 2;
        }

        private void mérés3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = false;
            er.Text = "";
            Cim.Text = "Mérés 3 eredményei:";
            Kontrol.MeresIndex = 3;
        }

        private void mérés4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Enabled = true;
            er.Text = "";
            Cim.Text = "Mérés 4 eredményei:";
            Kontrol.MeresIndex = 4;
        }

        private void frm_meres_Load(object sender, EventArgs e)
        {
            m1.Enabled = false;
            m1.Text = "0";
            Kontrol.MeresIndex = 1;
            Kontrol.ClearTheResults();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrol.ClearTheResults();
            
            double[] t = new double[] {
               double.Parse(m1.Text),
               double.Parse(m2.Text),
               double.Parse(m3.Text),
               double.Parse(m4.Text),
               double.Parse(m5.Text),
               double.Parse(em.Text)
           };

            Kontrol.AddResults(t);
            er.Text = Kontrol.GetTheResult().ToString();
        }
    }
}
