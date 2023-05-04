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
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmgiris fr = new frmgiris();
            fr.Show();
            this.Hide();
        }
    }
}
