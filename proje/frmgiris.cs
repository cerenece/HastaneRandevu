using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            frmhastakayit fr = new frmhastakayit();
            fr.Show();
            this.Hide();
        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            frmdoktorgiris fr = new frmdoktorgiris();
            fr.Show();
            this.Hide();
        }

        private void btnhakkinda_Click(object sender, EventArgs e)
        {
            frmhakkinda fr = new frmhakkinda();
            fr.Show();
            this.Hide();
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            iletisim fr = new iletisim();
            fr.Show();
            this.Hide();
        }
    }
}
