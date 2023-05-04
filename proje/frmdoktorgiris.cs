using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oop3
{
    public partial class frmdoktorgiris : Form
    {
        public frmdoktorgiris()
        {
            InitializeComponent();
        }

       
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-1VBH1A8\\SSQL;Initial Catalog=oopproje;Integrated Security=True");
        private void btntc_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from tbldoktor where doktortc=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                btnsifre.Enabled = true;
                msktc.Enabled = false;
                txtsifre.Enabled = true;
                MessageBox.Show("Lütfen şifrenizi giriniz");
            }
            else
            {
                MessageBox.Show("Lütfen doğru tc kimlik no giriniz");
            }
            bgl.Close();
        }

        private void btnsifre_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut1 = new SqlCommand("select * from tbldoktor where sifre=@p2 ", bgl);
            komut1.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                btngiris.Enabled = true;
                txtsifre.Enabled = false;
                MessageBox.Show("lütfen giriş butonuna basınız");
            }
            else
            {
                MessageBox.Show("Lütfen doğru şifre giriniz");
            }
            bgl.Close();
        }
        
        private void btngiris_Click(object sender, EventArgs e)
        {
            frmdoktorpanel fr = new frmdoktorpanel();
            fr.Show();
            this.Hide();
        }
        
        private void btngeri_Click(object sender, EventArgs e)
        {
            frmgiris fr = new frmgiris();
            fr.Show();
            this.Hide();
        }


































     private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {}

       
    }   
}
